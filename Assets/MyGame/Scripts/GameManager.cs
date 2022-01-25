using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Text lifesholder;
    public int lives = 3;

    public Text scoreText;
    public int score = 0;

    public InputField inputField;

    bool gameOver = false;
    /*---------------------------------------------*/
    /*---------------------------------------------*/

    /* Save Name ------------------------------------------- */
    public void TakeName()
    {
        PlayerPrefs.SetString("user_name", inputField.text);
        Debug.Log("Your Name is" + PlayerPrefs.GetString(" user_name"));
      
    }

    private void Awake()
    {
        instance = this;
    }


   

    /* Save Score ------------------------------------------- */
    public void SaveScore()
    {

        PlayerPrefs.SetInt("amountOfBeans", score);
    }



    /* Increase Score (Text) --------------------------------- */
    public void IncrementScore(int differentScores)
    {
        if(gameOver == false)
        {
            score+= differentScores;
            scoreText.text = score.ToString();
            
        }

    }
    

    /* Decrease Lives ---------------------------------------- */
    public void DecreaseLives()
    {
        if (lives > 0)
        {
            lives--;
            lifesholder.text = lives.ToString();
            print(lives);
        }

    /* When 0 Lives -> Load GameOver Scene ------------------- */
        if (lives <= 0)
        {
            SceneManager.LoadScene("GOver");
            
        }
    }


    

}

