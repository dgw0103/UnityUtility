using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.IO;

[CreateAssetMenu(fileName = nameof(PathTest), menuName = nameof(PathTest))]
public class PathTest : ScriptableObject, ISerializationCallbackReceiver
{
    private void PathTestMethod()
    {
        Debug.Log(Directory.GetCurrentDirectory());
        Debug.Log(new FileInfo("PathTest.cs").Directory.FullName);
        Debug.Log(new FileInfo("PathTest.cs").FullName);
        Debug.Log(Path.GetFullPath("PathTest.cs"));
    }
    public void OnAfterDeserialize()
    {
        Debug.Log(nameof(OnAfterDeserialize));
    }
    public void OnBeforeSerialize()
    {
        Debug.Log(nameof(OnBeforeSerialize));
    }
}