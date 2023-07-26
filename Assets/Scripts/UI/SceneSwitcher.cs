using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public string sceneNameToLoad;

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneNameToLoad);
    }
}
