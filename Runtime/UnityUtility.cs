using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UnityUtility
{
    public static IEnumerable<Vector3> GetBoundsVertices(this BoxCollider boxCollider)
    {
        return new Vector3[]
        {
            boxCollider.bounds.center + Vector3.Scale(0.5f * boxCollider.bounds.size, new Vector3(1f, 1f, 1f)),
            boxCollider.bounds.center + Vector3.Scale(0.5f * boxCollider.bounds.size, new Vector3(1f, 1f, -1f)),
            boxCollider.bounds.center + Vector3.Scale(0.5f * boxCollider.bounds.size, new Vector3(-1f, 1f, -1f)),
            boxCollider.bounds.center + Vector3.Scale(0.5f * boxCollider.bounds.size, new Vector3(-1f, 1f, 1f)),
            boxCollider.bounds.center + Vector3.Scale(0.5f * boxCollider.bounds.size, new Vector3(1f, -1f, 1f)),
            boxCollider.bounds.center + Vector3.Scale(0.5f * boxCollider.bounds.size, new Vector3(1f, -1f, -1f)),
            boxCollider.bounds.center + Vector3.Scale(0.5f * boxCollider.bounds.size, new Vector3(-1f, -1f, -1f)),
            boxCollider.bounds.center + Vector3.Scale(0.5f * boxCollider.bounds.size, new Vector3(-1f, -1f, 1f)),
        };
    }
}