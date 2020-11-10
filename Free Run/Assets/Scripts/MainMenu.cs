using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string levelName = "LevelName";

    public void StartGame()
    {
        if (Time.timeScale == 0)
            Time.timeScale = 1;
        SceneManager.LoadScene(levelName);
    }
}
