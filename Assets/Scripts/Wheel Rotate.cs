using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotate : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 rot = transform.eulerAngles;
        // rot.x += 1;

        // I did some sleuthing online to figure this out: 
        transform.Rotate(Vector3.right, 1);
        // euler angles were giving me a VERY weird issue where the wheel stopped rotating after a quarter turn...
        // Something to do with pitch angle? Not sure I understood it fully, but this simplified line works much better!     
    }
}