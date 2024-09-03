using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{
   public GameObject enemyPrefab; //the enemy prefab to spawn
    public float spawnInterval = 2f; //the time interval between spawn
    public float spawnXOffset =10f;
    public float moveSpeed = 5f; //speed at which enemies move left
    public float minY = -4f; //Minimum position for spawning
    public float maxY = 4f; // Maximum y position for spawning

    private float timeSinceLastSpawn = 0f;

    void Update()
    {
        //Track time and spawn enemies at regular intervals
        timeSinceLastSpawn += Time.deltaTime;

        if(timeSinceLastSpawn >= spawnInterval)
        {
            SpawnEnemy();
            timeSinceLastSpawn = 0f;
        }
    }
    
    void SpawnEnemy()
    {
        //Randomize the y position within specific range
        float spawnY = Random.Range(minY, maxY);

        //Set the position x to the right side, off-screen
        float spawnX = Camera.main.transform.position.x + spawnXOffset;

//Create the spawn position vector
Vector2 spawnPosition = new Vector2(spawnX, spawnY);

//Instantiate the enemy at the spawn position
GameObject enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

//Move the enemy left by applying velocity directly
Rigidbody2D enemyRb = enemy.GetComponent<Rigidbody2D>();
if(enemyRb != null)
{
    enemyRb.velocity = Vector2.left * moveSpeed;
}
    }
}
