using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class JumpingSquare : MonoBehaviour
{
    // private float speed = 0.02f;
    private float jumpingHeight = 3f;
    public float rotateAmountZ = 100f;
    public float rotateAmountX = 50f;
    public float trainPositionX = 4f;

    [Range(0, 1)]
    public float t;

    public AnimationCurve jumpCurve;
    public AnimationCurve spinzCurve;

    bool spacePressed = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 pos = transform.position;
        
        pos.y = jumpCurve.Evaluate(t) * jumpingHeight - 5;

        // This literally follows what we learned in class, but I added some rotation in 3d to show off the asset!

        Vector3 rot = transform.eulerAngles;
        rot.z = spinzCurve.Evaluate(t) * rotateAmountZ;

        //Now we can see it do a trick with some flair! :)

        rot.x = spinzCurve.Evaluate(t) * -rotateAmountX;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

       //if (screenPos.x < 0 || screenPos.x > Screen.width)
       // {
       //     speed = speed * -1;
       // }
       // None of this is needed as the train remains in place.

        if (Input.GetKeyDown(KeyCode.Space))
        {
            spacePressed = true;
        }

        // when space is pressed, train does a fun trick!

        if (spacePressed == true)
        {
            t += Time.deltaTime;
        }

        if (t > 1)
        {
            t = 0;
            spacePressed = false;
        }

        // make sure the things happen

        transform.position = pos;
        transform.eulerAngles = rot;



    }
}
