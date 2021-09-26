using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{

    public bool isRight;

    public float speed;

    public Transform pointR;
    public Transform pointL;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if(isRight)
        {
            transform.Translate(Vector2.right * speed *Time.deltaTime);

        }
        else
        {
            transform.Translate(-Vector2.right * speed *Time.deltaTime);

        }

        if(Input.GetMouseButtonDown(0))
        {
            isRight = !isRight;
        }

        if((Vector2.Distance(transform.position, pointL.position)<0.3f) || (Vector2.Distance(transform.position, pointR.position )<0.3f))
        {
           isRight = !isRight;
        }

    }

    
}
