using UnityEngine;

namespace Settings.Utils.Singletons
{
    public class  SingletonMono<T> where T : Component
    {
        private static T _instance;
        
        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    var go = new GameObject(nameof(T));
                    _instance = go.AddComponent<T>();
                    Object.DontDestroyOnLoad(go);
                }

                return _instance;
            }
        }
    }
}