using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    Scene scene;

    private void Start()
    {
        scene = SceneManager.GetActiveScene();
    }
    public void StartGame()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void Play()
    {
        
        SceneManager.LoadScene("MainScene");

        if (scene.buildIndex == 0)
        {
            InputFieldName.instance.TakeName();
        }

    }
}
