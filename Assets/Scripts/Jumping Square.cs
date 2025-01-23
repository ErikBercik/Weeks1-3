using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class JumpingSquare : MonoBehaviour
{
    private float speed = 0.02f;
    private float jumpingHeight = 3f;
    public float rotateAmount = 100f;

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
        pos.x += speed;
        pos.y = jumpCurve.Evaluate(t) * jumpingHeight;

        Vector3 rot = transform.eulerAngles;
        rot.z = spinzCurve.Evaluate(t) * rotateAmount;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        if (screenPos.x < 0 || screenPos.x > Screen.width)
        {
            speed = speed * -1;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            spacePressed = true;
        }

        if (spacePressed == true)
        { 
            t += Time.deltaTime;
        }

        if (t > 1)
        {
            t = 0;
            spacePressed = false;
        }

        transform.position = pos;
        transform.eulerAngles = rot;

        
 
    }
}
