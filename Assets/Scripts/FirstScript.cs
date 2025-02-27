using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    public float cloudSpeed = 0.01f;

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

        if(screenPos.x > Screen.width + 1) 
        {
            pos.x = -1;
        }

        transform.position = pos;
    }
}
