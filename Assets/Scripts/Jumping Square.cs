using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class JumpingSquare : MonoBehaviour
{
    private float speed = 0.02f;
    private float jumpingHeight = 3f;

    [Range(0, 1)]
    public float t;

    public AnimationCurve jumpCurve;

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

        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        if(screenPos.x < 0 || screenPos.x > Screen.width)
        {
            speed = speed * -1;
        }

        if()

        if(spacePressed == true)
        { 
            t += Time.deltaTime;
        }

        transform.position = pos;
 
    }
}
