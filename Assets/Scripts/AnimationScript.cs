using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public AnimationCurve curve;

    // This is an attribute [Range] it must go the line before or directly before. So put the public variable right after.
    [Range(0, 2)]
    public float t;
    // Now we have a slider

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Lets animate this per frame
        t += Time.deltaTime;
        // Now lets make sure it doesn't get bigger than 2
        if(t > 2) 
        {
            t = 0;
        }

        transform.localScale = Vector2.one * curve.Evaluate(t);
    }
}
