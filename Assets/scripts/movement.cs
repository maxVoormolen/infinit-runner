﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float playerSpeed;  //allows us to be able to change speed in Unity

    public Vector2 jumpHeight;

    public BoxCollider2D col;

    public bool isGrounded = false;
    public bool isDead = false;
    

    void Update()
    {
        if (!isDead) {
            if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
            {
                if (isGrounded)
                {
                    GetComponent<Rigidbody2D>().AddForce(jumpHeight, ForceMode2D.Impulse);
                    isGrounded = false;
                }


            }
        }
    }

    public bool GetGrounded(){
        return isGrounded;
    }

    public void SetGrounded(bool toggle){
        isGrounded = toggle;
    }
   

    void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.collider.tag == "Ground")
        {

            isGrounded = true;

        }

        if (collision.collider.tag == "Spike")
        {

            col.enabled = false;
            Debug.Log("ded");
            isDead = true;

        }
    }

}