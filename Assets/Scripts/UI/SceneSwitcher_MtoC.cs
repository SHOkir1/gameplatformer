using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher_MtoC : MonoBehaviour
{
    public string sceneNameToLoad;

    public void LoadScene()
    {
        SceneManager.LoadScene("Credits");
    }
}
