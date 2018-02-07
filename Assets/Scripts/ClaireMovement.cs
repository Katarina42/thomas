using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClaireMovement : MonoBehaviour {

    static Animator animateJump;
    private AudioSource audio;
    private float speed = 2;
    private float jumpHeight = 10;

    private void Start()
    {
        animateJump = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();

        
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Time.deltaTime * speed * Input.GetAxis("Horizontal"), 0, 0);

        if (Input.GetKey(KeyCode.Space))
        {
            audio.Play();
            transform.Translate(0, Time.deltaTime * jumpHeight, 0);
        }
    }


    private void OnMouseDown()
    {

        SendMessageUpwards("StopThomas");
    }
}
    