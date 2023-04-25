using System;
using UnityEngine;

namespace CaptureTheFlag.Common  { 
    public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour {
        
        private static T instance;
        public static T Instance {
            get {
                if ( instance is null ) {
                    instance = ( T ) FindObjectOfType( typeof( T ) );
                    if ( instance is null ) {
                        instance = new GameObject( nameof( T ), typeof( T ) ).GetComponent<T>();
                    }
                }
                return instance;
            }
        }
        
        protected virtual void Awake( ) { }
    }
    
    public abstract class PersistentSingleton<T> : Singleton<T> where T : MonoBehaviour {
        protected override void Awake( ) {
            DontDestroyOnLoad( this );
        }
    }
}
