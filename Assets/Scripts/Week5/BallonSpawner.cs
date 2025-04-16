using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonSpawner : MonoBehaviour
{
    public GameObject balloonPrefab; // Reference Balloon prefab that will be made
    public float spawnRate = 1f; // How often ballons are spawned (lower number means hard game)

    public float nextSpawnTime; 


    
    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            // Spawn thge ballon and set the time for the next spawn
            SpawnBalloon();
            nextSpawnTime = Time.time + spawnRate;
        }
    }

        void SpawnBalloon()
        {
            // Spawb position at horizontal point at the bottom of the screen
            Vector3 spawnPosition = new Vector4(Random.Range(-8f, 8f), -5f, 0f);

            //instantiate a new Balloon Prefab
            Instantiate(balloonPrefab, spawnPosition, Quaternion.identity);

        }
}
