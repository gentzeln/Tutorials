using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Refernce to the Player
    public float smoothSpeed = 0.125f; // Speed at which the camera follows players
    public Vector3 offset; // Offset to maintain distance from marble
        
    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;  //Calculate desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); //Smooth the transition
        transform.position = smoothedPosition; // Update Camera position
    }

}
