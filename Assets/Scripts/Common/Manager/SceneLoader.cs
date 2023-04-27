using System.Collections.Generic;
using ScriptableObjects;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Common {
    public class SceneLoader : PersistentSingleton<SceneLoader> {
        public static void LoadScene( SceneName sceneName ) {
            SceneManager.LoadSceneAsync( sceneName.ToString() );
        }
    }
}
