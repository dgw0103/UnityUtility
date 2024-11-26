using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityUtility.Singleton
{
    /// <summary>
    /// Singleton pattern. It has to create in hierarchy. The instance is instantiate at 'Awake'.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
    {
        private static T instance;



        private void Awake()
        {
            if (instance == null)
            {
                instance = (T)this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }



        public static T Instance { get => instance; }
    }
}