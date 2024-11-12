using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;
using System;

/// <summary>
/// Call into 'OnPostprocessAllAssets' of 'AssetPostprocessor'.
/// </summary>
public class CreateAssetMenuGenerator
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="importedAssets"></param>
    /// <param name="inheritedTypeName">Add attribute to files that inherited from this or don't have 'CreateAssetMenu'.</param>
    public static void AddToImportedAssets(string[] importedAssets, string inheritedTypeName)
    {
        AddToImportedAssets(
            importedAssets,
            (path) =>
            {
                string fileName = $"nameof({AssetDatabase.LoadAssetAtPath<MonoScript>(path).GetClass().Name})";
                string menuName = $"nameof({inheritedTypeName}) + \"/\" + {fileName}";

                AddCreateAssetMenuAttribute(path, inheritedTypeName, fileName, menuName);
            },
            inheritedTypeName);
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="importedAssets"></param>
    /// <param name="inheritedTypeName">Add attribute to files that inherited from this or don't have 'CreateAssetMenu'.</param>
    public static void AddToImportedAssets(string[] importedAssets, string inheritedTypeName, string fileName, string menuName)
    {
        AddToImportedAssets(
            importedAssets,
            (path) => AddCreateAssetMenuAttribute(path, inheritedTypeName, fileName, menuName),
            inheritedTypeName);
    }
    private static void AddToImportedAssets(string[] importedAssets, Action<string> action, string inheritedTypeName)
    {
        foreach (string path in importedAssets)
        {
            if (path.EndsWith(".cs"))
            {
                string fileContent = File.ReadAllText(path);

                if (fileContent.Contains($": {inheritedTypeName}") && fileContent.Contains("[CreateAssetMenu") == false)
                {
                    Debug.Log($"{inheritedTypeName} is changed.");
                    action.Invoke(path);
                }
            }
        }
    }
    private static void AddCreateAssetMenuAttribute(string scriptPath, string inheritiedTypeName, string fileName, string menuName)
    {
        string[] lines = File.ReadAllLines(scriptPath);

        using (StreamWriter writer = new StreamWriter(scriptPath))
        {
            bool attributeAdded = false;

            foreach (string line in lines)
            {
                if (attributeAdded == false && line.Contains("class") && line.Contains($": {inheritiedTypeName}"))
                {
                    writer.WriteLine($"[CreateAssetMenu(fileName = {fileName}, menuName = {menuName})]");
                    attributeAdded = true;
                }

                writer.WriteLine(line);
            }
        }

        AssetDatabase.Refresh();
    }
}
