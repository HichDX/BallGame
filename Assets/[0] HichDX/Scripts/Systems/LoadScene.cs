using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LoadLevel(string scene)
    {
        SceneManager.LoadSceneAsync(scene);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
