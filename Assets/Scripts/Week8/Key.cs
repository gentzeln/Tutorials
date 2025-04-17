using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public DoorManager doorManager;

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Check if player collides with the key
        if (other.CompareTag("Player"))
        {
            //add this key to the doormanager collected key
            doorManager.CollectedKey(gameObject);

            
            //Tell the DoorManager to trigger the door animation
            doorManager.TriggerDoorAnimationForKey(gameObject);

            // Destroy the object after it is collected
            Destroy(gameObject);
        }
    }
}
