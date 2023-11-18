using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace UnityUtility.Editor
{
    public class EditorWindowDataSaver<T>
    {
        public static void Save(T t)
        {
            string sightDetectorWindowData = JsonUtility.ToJson(t, false);
            EditorPrefs.SetString(nameof(T), sightDetectorWindowData);
        }
        public static void Load(T sightDetectorWindow)
        {
            string sightDetectorWindowData = EditorPrefs.GetString(nameof(T), JsonUtility.ToJson(sightDetectorWindow, false));
            JsonUtility.FromJsonOverwrite(sightDetectorWindowData, sightDetectorWindow);
        }
    }
}