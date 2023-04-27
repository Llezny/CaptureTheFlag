using System.Collections.Generic;
using ScriptableObjects;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Common {
    public class SceneLoader : PersistentSingleton<SceneLoader> {
    
        [ SerializeField ] private List<SceneSO> scenes;
        private Dictionary<SceneName, SceneAsset> scenesDictionary;

        protected override void Awake( ) {
            base.Awake();
            scenesDictionary = new Dictionary<SceneName, SceneAsset>( );
            foreach ( var sceneSO in scenes ) {
                if ( scenesDictionary.ContainsKey( sceneSO.sceneName ) ) {
                    Debug.LogWarning( "Duplicated scene names: " + sceneSO.sceneName );
                    continue;
                }
                scenesDictionary.Add( sceneSO.sceneName, sceneSO.sceneAsset );
            }
        }

        public void LoadScene( SceneName sceneName) {
            if ( !scenesDictionary.TryGetValue( sceneName, out var sceneAsset ) ) {
                Debug.LogWarning( "There is no such scene: " + sceneName );
                return;
            }

            SceneManager.LoadSceneAsync( sceneAsset.name );
        }
    }
}
