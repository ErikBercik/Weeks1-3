using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5;
    // bool hasBeenFired = false; This is a private variable
    public bool hasBeenFired = false;
    void Update()
    {
        if (hasBeenFired)
        {
            Movement();
        }
        else
        {
            PointAtMouse();
        }
    }

    void PointAtMouse()
    {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse.z = 0;
        Vector2 direction = mouse - transform.position;

        transform.up = direction;
    }

    void Movement()
    {
        //transform.position += Vector3.one * speed * Time.deltaTime;

        transform.position += transform.up * speed * Time.deltaTime;

        //transform.Translate(transform.up * speed * Time.deltaTime); This one doesn't quite work... Kit doesn't even know why lol. Sometime you just have to try things out!
    }
}
