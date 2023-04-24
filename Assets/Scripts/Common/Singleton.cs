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

        private void Awake( ) {
            DontDestroyOnLoad( this );
            OnAwake( );
        }

        protected void OnAwake( ) { }
    }
}
