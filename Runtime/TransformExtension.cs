using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace UnityEngine
{
    public static class TransformExtension
    {
        public static int GetChildCount(this Transform transform, bool includeInactivate)
        {
            return transform.GetComponentsInChildren<Transform>(includeInactivate).Except(transform).Count();
        }
    }
}