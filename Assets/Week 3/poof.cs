using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poof : MonoBehaviour
{
    public float speed = 1;

    // bool hasBeenFired = false; This is a private variable

    public bool hasBeenFired = false;
    void Update()
    {
        // if poof is fired, go in this direction

        if (hasBeenFired)
        {
            Movement();
        }
    }

    void Movement()
    {
        //transform.position += Vector3.one * speed * Time.deltaTime;

        transform.position += transform.up * speed * Time.deltaTime;

        //transform.Translate(transform.up * speed * Time.deltaTime); This one doesn't quite work... Kit doesn't even know why lol. Sometime you just have to try things out!
    }
}