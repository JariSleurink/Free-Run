using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Difficulty
{
    EASY, MEDIUM, HARD
}
public class MovingPlatform : MonoBehaviour
{
    public Difficulty difficulty;
    public Vector3 destination;
    private float speed;
    Vector3 source;
    Vector3 moveTo;


    void Start()
    {
        source = transform.position;
        moveTo = destination;

        switch (difficulty)
        {
            case Difficulty.EASY:
                speed = 3;
                break;
            case Difficulty.MEDIUM:
                speed = 4;
                break;
            case Difficulty.HARD:
                speed = 5;
                break;
            default: speed = 3; break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, moveTo, Time.deltaTime * speed);
        if (transform.position == destination)
            moveTo = source;
        if (transform.position == source)
            moveTo = destination;
    }
}