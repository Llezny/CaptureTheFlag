using Common;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "SceneSO", menuName = "ScriptableObjects/SceneSO", order = 1)]
public class SceneSO : ScriptableObject {
    public SceneAsset sceneAsset;
    public SceneName sceneName;
}