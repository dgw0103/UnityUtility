using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.Requests;

namespace UnityUtilityEditor
{
    public static class UnityEditorUtility
    {
        public static string projectManifestPath = Application.dataPath.Substring(0, Application.dataPath.Length - 6) + "Packages/manifest.json";
        public const string menuItemPath = "Unity utility/";



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

        public static IEnumerable<SerializedProperty> GetArray(this SerializedProperty serializedProperty)
        {
            List<SerializedProperty> elements = new List<SerializedProperty>(serializedProperty.arraySize);

            for (int i = 0; i < serializedProperty.arraySize; i++)
            {
                elements.Add(serializedProperty.GetArrayElementAtIndex(i));
            }

            return elements;
        }

        public static IEnumerable<UnityEditor.PackageManager.PackageInfo> GetPackges()
        {
            ListRequest listRequest = Client.List(true);

            if (listRequest.Error != null)
            {
                Debug.Log("Error: " + listRequest.Error.message);
                return null;
            }

            return listRequest.Result;
        }
    }
}