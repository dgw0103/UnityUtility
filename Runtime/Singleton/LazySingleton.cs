using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityUtility.Singleton
{
    /// <summary>
    /// Lazy singleton pattern. It dosen't need to create in hierarchy.
    /// </summary>
    /// <typeparam name="T">MonoBehaviour that will be added to an instantiated GameObject.</typeparam>
    public abstract class LazySingleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T instance;



        public static T Instance
        {
            get
            {
                if (instance == (Object)null || instance.gameObject == null)
                {
                    CreateInstance();
                }

                return instance;
            }
        }
        private static void CreateInstance()
        {
            var gameObject = new GameObject($"{typeof(T).Name}");
            instance = gameObject.AddComponent<T>();
            DontDestroyOnLoad(gameObject);
        }
    }
}