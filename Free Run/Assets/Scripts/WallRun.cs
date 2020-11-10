using System.Collections;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WallRun : MonoBehaviour

{
    RaycastHit hitR;
    RaycastHit hitL;
    int jumpCount = 0;
    RigidbodyFirstPersonController cc;
    Rigidbody rb;
    public float runTime = 0.5f;
    

    void Start()
    {
        cc = GetComponent<RigidbodyFirstPersonController>();
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (cc.Grounded)
        {
            jumpCount = 0;
        }
        if (!cc.Grounded && jumpCount <= 1)
        
        {
            if (Physics.Raycast(transform.position, -transform.right, out hitL, 1))
            {
                if (hitL.transform.tag == "Wall")
                {
                    WallRunning();
                }
            }
            if (Physics.Raycast(transform.position, transform.right, out hitR, 1))
            {
                if (hitR.transform.tag == "Wall")
                {
                    WallRunning();
                }
            }
        }
    }
    private void WallRunning()
    {
        jumpCount += 1;
        rb.useGravity = false;
        StartCoroutine(afterRun());
    }

    IEnumerator afterRun()
    {
        yield return new WaitForSeconds(runTime);
        rb.useGravity = true;
    }
}