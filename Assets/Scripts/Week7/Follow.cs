using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform player; //reference to the player's transform
    public float smothSpeed = 0.125f; // Smoothing speed for camera movement
    public Vector3 ofset; //Offset for the camera position

    private void FixedUpdate()
    {
        //Calculate the target position with the offset
        Vector3 desiredPosition = player.position + ofset; 

        // Smoothly move the camera towards the target position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smothSpeed);

        // Set the camera's position to the smoothed position
        transform.position = smoothedPosition;
    }
}
