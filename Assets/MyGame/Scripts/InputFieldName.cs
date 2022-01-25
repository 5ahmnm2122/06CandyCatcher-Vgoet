using UnityEngine;
using UnityEngine.UI;

public class InputFieldName : MonoBehaviour
{

    public static InputFieldName instance;
    public InputField inputField;
    /* Save Name ------------------------------------------- */
    public void TakeName()
    {
        PlayerPrefs.SetString("user_name", inputField.text);
        Debug.Log("Your Name is" + PlayerPrefs.GetString(" user_name"));

    }

}
