using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : Health
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")

            item += 1;
    }
    void Update()
    {
        if (item == 1)
        {
            SceneManager.LoadScene(nextLevel);
        }
    }
}