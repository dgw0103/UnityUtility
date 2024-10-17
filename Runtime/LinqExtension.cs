using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace System.Linq
{
    public static class LinqExtension
    {
        public static IEnumerable<TSource> Except<TSource>(this IEnumerable<TSource> first, TSource second)
        {
            foreach (var item in first)
            {
                if ((item == null && second == null) || item.Equals(second))
                {
                    continue;
                }

                yield return item;
            }
        }
    }
}