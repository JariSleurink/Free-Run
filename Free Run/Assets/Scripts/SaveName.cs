using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SaveName : MonoBehaviour
{
    public InputField textBox;

    public void clickSaveButton()
    {
        PlayerPrefs.SetString("name", textBox.text);
        SceneManager.LoadScene("Main Menu");
    }
}