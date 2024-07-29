using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.IO;

public class PathTest
{
    [InitializeOnLoadMethod]
    private static void PathTestMethod()
    {
        Debug.Log(Directory.GetCurrentDirectory());
        Debug.Log(new FileInfo("PathTest.cs").Directory.FullName);
        Debug.Log(new FileInfo("PathTest.cs").FullName);
        Debug.Log(Path.GetFullPath("PathTest.cs"));
    }
}