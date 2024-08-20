using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Test : AssetPostprocessor
{
    private static void OnPostprocessAllAssets(System.String[] importedAssets, System.String[] deletedAssets,
            System.String[] movedAssets, System.String[] movedFromAssetPaths)
    {
        Debug.Log(true);
    }
}