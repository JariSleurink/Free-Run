using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int health = 100;
    public string respawn;
    public string nextLevel;
    public int item = 0;
    void Start()
    {

    }
    void Update()
    {
        if(health <= 0)
        {
            SceneManager.LoadScene(respawn);
        }
    }
}