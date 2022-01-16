using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Text lifesholder;
    public Text scoreText;

    int score = 0;
    int lives = 3;

    bool gameOver = false;

    private void Awake()
    {
        instance = this;
    }

    public void IncrementScore()
    {
        if(gameOver == false)
        {
            score++;
            scoreText.text = score.ToString();

            print(score);
        }

    }

    public void DecreaseLives()
    {
        if (lives > 0)
        {
            lives--;
            lifesholder.text = lives.ToString();
            print(lives);
        }


        if (lives <= 0)
        {
            SceneManager.LoadScene("GOver");
        }
    }


    
}

