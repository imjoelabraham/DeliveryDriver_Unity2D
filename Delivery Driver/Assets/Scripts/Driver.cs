using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    //speed at which the car turns in either direction
    [SerializeField]
    float steerSpeed = -0.1f;

    //speed at which the car moves forward.
    [SerializeField]
    float moveSpeed = 0.1f;

    [SerializeField] float increaseSpeed = 40;
    [SerializeField] float slowSpeed = 20;

    void Start()
    {
    
    }

    
    void Update()
    {
        //asigning the car to turn a certain units in a frame when giving the horizontal input keys.
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        //asigning the car to move a certain units in a frame when giving the vertical input keys.
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        //asking the car to rotate in the z axis using the steer amount value.
        transform.Rotate(0,0, steerAmount);
        //asking the car to move in the y axis using the move amount value.
        transform.Translate(0, moveAmount,0);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //to increase or slow speed when the driver
        //goes on the green signal(circle) or speed bump.
        if (collision.tag == "speed")
        {
            moveSpeed = increaseSpeed;
        }
        if (collision.tag == "speedBump")
        {
            moveSpeed = slowSpeed;
        }
    }
}
