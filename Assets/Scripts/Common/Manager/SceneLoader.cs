using UnityEngine.SceneManagement;

namespace CaptureTheFlag.Common.Manager {
    public class SceneLoader : PersistentSingleton<SceneLoader> {
        public static void LoadScene( SceneName sceneName ) {
            SceneManager.LoadSceneAsync( sceneName.ToString() );
        }
    }
}
