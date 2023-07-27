using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher_MtoS : MonoBehaviour
{
    public string sceneNameToLoad;

    public void LoadScene()
    {
        SceneManager.LoadScene("Settings");
    }
}
