using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Text scoreText = gameObject.GetComponent<Text>();

        scoreText.text = PlayerPrefs.GetInt("amountOfBeans").ToString();
    }
    
}
