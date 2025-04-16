using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{

    public float speed;
    private int points = 1; //points for popping ballons



    // Start is called before the first frame update
    void Start()
    {
        //random speed for each ballon that can be adjusted for difficulty
        speed = Random.Range(1f, 6f); 

    }

    // Update is called once per frame
    void Update()
    {
        //move the ballons upwards
        transform.Translate(Vector3.up *speed * Time.deltaTime);

       // Destroy Ballons if it goes off screen 

        if (transform.position.y > Camera.main.orthographicSize + 1)
        {

            Destroy(gameObject);
        }
    }

    void OnMouseDown()
    {
        // Add points to score ( will be handled in GameManager Script)
        GameManager.instance.AddScore(points);

        //Destroy ballons if popped
        Destroy(gameObject);
    }
}
