using System.Collections;
using System.Collections.Generic;
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
        if (scene.buildIndex == 0)
        {
            GameManager.instance.SaveName(); }

        SceneManager.LoadScene("MainScene");
    }
}
