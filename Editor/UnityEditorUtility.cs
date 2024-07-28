using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace UnityUtilityEditor
{
    public static class UnityEditorUtility
    {
        public static string projectManifestPath = Application.dataPath.Substring(0, Application.dataPath.Length - 6) + "Packages/manifest.json";

        public static string GetFolderPathOfThis(this ScriptableObject scriptableObject)
        {
            return GetFolderPathOfThis(MonoScript.FromScriptableObject(scriptableObject));
        }
        public static string GetFolderPathOfThis(this MonoBehaviour monoBehaviour)
        {
            return GetFolderPathOfThis(MonoScript.FromMonoBehaviour(monoBehaviour));
        }
        private static string GetFolderPathOfThis(MonoScript monoScript)
        {
            return AssetDatabase.GetAssetPath(monoScript).Replace($"/{monoScript.name}.cs", string.Empty);
        }
    }
}