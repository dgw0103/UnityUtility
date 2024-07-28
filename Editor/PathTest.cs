using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.IO;

[InitializeOnLoad]
public class PathTest
{
    static PathTest()
    {
        Debug.Log(Directory.GetCurrentDirectory());
    }
}