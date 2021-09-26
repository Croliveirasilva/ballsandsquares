using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class square : MonoBehaviour
{
    public Rigidbody2D rig;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(new Vector3(0, 0, UnityEngine.Random.Range(-145,-45)));
    }

    // Update is called once per frame
   void FixedUpdate()
 
    {
        rig.MovePosition(transform.position + transform.right*speed *Time.deltaTime);
    }

     private void OnTriggerEnter2D(Collider2D other)
   
    {
        if(other.CompareTag("Player"))
        {
            GameController.instance.ShowGameOver();
        }
    }
}
