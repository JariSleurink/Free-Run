using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : Health
{
    public int damage;
    float waitTime = 1.0f;

    public void Update()
    {
        waitTime -= Time.deltaTime;
    }


    void OnTriggerStay(Collider other)
    {
        for (int i = 0; i < damage; i++)
        {
            if (other.gameObject.tag == "Player" && waitTime <= 0)
            {
                other.gameObject.GetComponent<Health>().health -= damage;
                waitTime = 1.0f;
            }
        }
    }
}