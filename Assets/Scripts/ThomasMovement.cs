using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThomasMovement: MonoBehaviour {

    static Animator animateJump;
    private AudioSource audio;
    private float speed=5;
    private float jumpHeight=5;

    private void Start()
    {
        animateJump = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
        
    }
    void Update () {

        Move();
        Jump();
    }

    private void OnMouseDown()
    {
        SendMessageUpwards("StopClaire");
    }
    private void Move()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Time.deltaTime * speed * Input.GetAxis("Horizontal"),0, 0);
    }

    private void Jump()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0, Time.deltaTime * jumpHeight, 0);
        }
        //animation

        if(Input.GetKeyDown(KeyCode.Space))
        {
            animateJump.SetTrigger("isJumping");
            audio.Play();
            
        }
          
    }


}
