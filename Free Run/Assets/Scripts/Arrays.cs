using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour
{
    public GameObject[] trophies;
    public int activeTrophie;

    void Start()
    {
        NewTrophie();
    }


    void NewTrophie()
    {
        activeTrophie = Random.Range(0, trophies.Length);
        trophies[activeTrophie].SetActive(true);
    }
}