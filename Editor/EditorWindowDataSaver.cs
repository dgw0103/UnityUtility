using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace UnityUtilityEditor
{
    public class EditorWindowDataSaver<T>
    {
        public static void Save(T t)
        {
            if (t == null)
            {
                return;
            }

            string windowData = JsonUtility.ToJson(t, false);



            EditorPrefs.SetString(nameof(T), windowData);
        }



        public static void Load(T window)
        {
            if (window == null)
            {
                return;
            }

            string windowData = EditorPrefs.GetString(nameof(T), JsonUtility.ToJson(window, false));



            JsonUtility.FromJsonOverwrite(windowData, window);
        }
    }
}