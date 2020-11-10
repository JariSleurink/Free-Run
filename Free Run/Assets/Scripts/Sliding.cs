using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sliding : MonoBehaviour
{
    public bool isGliding = false;
    public int slideDestination = -65;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetButton("Sliding"))
        {
            //transform.rotation = Quaternion.Euler(new Vector3(-70, 0, 0));
            isGliding = true;
            transform.Rotate(slideDestination, 0, 0  * Time.deltaTime);
        }
        else
        {
            isGliding = false;
        }
    }
}