using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    private float smoothTime = 0.05F;
    private Vector3 velocity = Vector3.zero;
    private GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");   
    }

    void Update () {

        Vector3 targetPosition = player.transform.position + new Vector3(2,2,-5);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
