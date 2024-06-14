using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace HoJin.UnityUtilityEditor
{
    public static class UnityEditorUtility
    {
        public static string projectManifestPath = Application.dataPath.Substring(0, Application.dataPath.Length - 6) + "Packages/manifest.json";
    }
}
