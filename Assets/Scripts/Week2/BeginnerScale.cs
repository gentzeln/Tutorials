using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginnerScale : MonoBehaviour
{

    // This variable controls how fast the object scales
    public float scaleSpeed = 1f;


    //This variable set the max and min sizes for the object
    public float maxScale = 1.5f;
    public float minScale = 0.5f;


    // The starting size of the object

    private Vector3 originalScale;

    // This boolean checks if we are currently makiung the object bigger or smaller

    private bool scalingUp = true;

    void Start()
    // Start is called before first frame update

    {

        //Save the starting scale for object

        originalScale = transform.localScale;
    }
    private void Update()
    {
        // if we are scaling up

        if (scalingUp)
        {
            // increase the size of the object 
            transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime;

            //if the object has reached the maximum size , stop scaling up and start scaling down
            if (transform.localScale.x >= originalScale.x * maxScale)
            {
                scalingUp = false;
            }
        }
        else
        {
            //decrease the size of the object
            transform.localScale -= Vector3.one * scaleSpeed * Time.deltaTime;


            // if the object has reached minimum, stop scaling down and start scaling up. 
            if (transform.localScale.x <= originalScale.x * minScale)
            {  scalingUp = true; }
        }
    }
}
