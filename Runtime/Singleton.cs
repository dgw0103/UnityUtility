using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityUtility
{
    public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
    {
        private static T instance;



        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameObject(typeof(T).Name).AddComponent<T>();

                    DontDestroyOnLoad(instance);
                }

                return instance;
            }
        }
    }
}