using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScript : MonoBehaviour
{
    public float cloudSpeed = 0.02f;
    public float cloudReturn = (Screen.width + 20f);


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += cloudSpeed;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        // If the cloud goes off the screen, spawn it back on the left!

        if (screenPos.x > cloudReturn)
        {
            pos.x = -12;
        }

        // I could not get clouds to work properly when spawning and despawning. I kept getting a compile error despite following the guide...?
        // This code is basic and ugly and doesn't work smoothly, but I'm near deadline and don't know what else to do.... UGH
        

        transform.position = pos;
    }
}