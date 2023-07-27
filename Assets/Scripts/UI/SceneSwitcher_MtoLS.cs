using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher_MtoLS : MonoBehaviour
{
    public string sceneNameToLoad;

    public void LoadScene()
    {
        SceneManager.LoadScene("LevelSelector");
    }
}
