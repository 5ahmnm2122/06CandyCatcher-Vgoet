using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadName : MonoBehaviour
{


    void Start()
    {
        Text inputField = gameObject.GetComponent<Text>();

        inputField.text = PlayerPrefs.GetString("username").ToString();
    }



}
