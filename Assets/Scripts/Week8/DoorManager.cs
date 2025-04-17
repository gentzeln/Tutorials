using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    [System.Serializable]
    public class KeyDoorPair
    {
        public GameObject keyObject; // The specific key object
        public Animator doorAnimator; //Reference to the door animator
        public string doorAnimationTrigger = "CollectedTrigger"; //Set to the trigger name
    }

    public List<KeyDoorPair> keyDoorPairs = new List<KeyDoorPair>();
    
    //Store collected keys
    private List<GameObject> collectedKeys = new List<GameObject>();

    //Method to collect a key
    public void CollectedKey(GameObject key)
    {
        //Add the collected key to the list
        collectedKeys.Add(key);

    }
    //Trigger the door animation if the player has collected the key
    public void TriggerDoorAnimationForKey(GameObject collectedKey)
    {
        foreach (KeyDoorPair pair in keyDoorPairs)
        {
            if (pair.keyObject == collectedKey)
            {
                //If the player has the correct key, trigger the door animation
                pair.doorAnimator.SetTrigger(pair.doorAnimationTrigger);
                return;
            }
        }
        // if no matching door found for the key
        Debug.LogWarning("No door found for the collected key");
    }
}