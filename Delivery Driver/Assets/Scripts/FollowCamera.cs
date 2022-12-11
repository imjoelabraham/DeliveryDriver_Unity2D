using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    //introducing the game object
    [SerializeField] GameObject followCar;

    
    void LateUpdate()
    {
        //asking the camera position to have the position of the driver object
        //with -10 distance in the z axis to view the driver.
        transform.position = followCar.transform.position + new Vector3(0, 0,-10);

    }
}
