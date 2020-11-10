using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    public List<GameObject> destroyFloor = new List<GameObject>();
    public int Object = 1;

    void Start()
    {
        GameObject firstObject = destroyFloor[0];
        GameObject secondObject = destroyFloor[1];

        NewFloor();
    }

    void NewFloor()
    {
        Object = Random.Range(transform.position);
        destroyFloor[Object].SetActive(true);
    }
}
