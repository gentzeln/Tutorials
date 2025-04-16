using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleController : MonoBehaviour
{
    public float moveSpeed = 10f; //SPeed of marble
    public float maxSpeed = 20f; // Max Speed of marble

    private Rigidbody2D rb;
    private Vector2 movement;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Assign Rigidbody component

    }
    private void Update()
    {
        movement.x = Input.GetAxis("Horizontal"); // Get player input from input manager
        movement.y = Input.GetAxis("Vertical"); // Get player input from input manager
    }
    void FixedUpdate()
    {
        // Apply Movement with force for smooth acceleration
        if (rb.velocity.magnitude < maxSpeed)
        {
            rb.AddForce(movement * moveSpeed);
        }
    }
}
