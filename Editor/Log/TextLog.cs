using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Linq;
using UnityEngine.UI;

public class TextLog
{
    private static string canvasPrefabGUID = "2f5279a684768ba478de7cee9d331734";
    private static string textPrefabGUID = "d663526b84ed19a4cb4880ff6da42899";



    public static void Log(object text)
    {
        GameObject canvasPrefab = CanvasPrefab;
        GameObject canvasInScene = Object.FindObjectsOfType<GameObject>().
            SingleOrDefault((x) => PrefabUtility.GetCorrespondingObjectFromSource(x) == canvasPrefab);

        if (canvasInScene == null)
        {
            canvasInScene = PrefabUtility.InstantiatePrefab(canvasPrefab) as GameObject;
        }

        CreateText(canvasInScene.transform.GetChild(0).GetChild(0).GetChild(0), text);
    }
    private static void CreateText(Transform textRoot, string text)
    {
        CreateText(textRoot, text);
    }
    private static void CreateText(Transform textRoot, object text)
    {
        GameObject textPrefab = AssetDatabase.LoadAssetAtPath(AssetDatabase.GUIDToAssetPath(textPrefabGUID), typeof(GameObject)) as GameObject;
        GameObject textObject = PrefabUtility.InstantiatePrefab(textPrefab, textRoot) as GameObject;

        textObject.GetComponent<Text>().text = text.ToString();
    }
    private static GameObject CanvasPrefab
    {
        get
        {
            return AssetDatabase.LoadAssetAtPath(AssetDatabase.GUIDToAssetPath(canvasPrefabGUID), typeof(GameObject)) as GameObject;
        }
    }
}