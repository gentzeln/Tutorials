using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleUpandDown : MonoBehaviour
{

    // This will control how fast the objects move up and down

    public float moveSpeed = 1f;

    // This will set how high the object goes up before coming down

    public float moveAmount = 1f;

    //This is the starting position of the object
    private Vector3 startPosition;


    void Start()
    {
        //Save the objects starting position
        startPosition = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        //Calculate the new Y position using a sine wave for smooth movement
        float newY = startPosition.y + Mathf.Sin(Time.time * moveSpeed) * moveAmount;

        // Set the object's position with the new Y value while keeping the X and Z the same!

        transform.position = new Vector3(startPosition.x, newY,startPosition.z );
    }
}
