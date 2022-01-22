using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public string levelToLoad;
    private float timer = 30;
    private Text timerSeconds;


    void Start()
    {
        timerSeconds = GetComponent<Text>();
    }

    void Update()
    {
        timer -= Time.deltaTime;
        timerSeconds.text = timer.ToString("f2");
        
        if (timer <= 0)
        {
            GameManager.instance.SaveScore();
            Application.LoadLevel(levelToLoad);
        }
    }
}
