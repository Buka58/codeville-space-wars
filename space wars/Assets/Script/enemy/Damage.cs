using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int health = 1;   //enemy's health, set for 3 example
public GameObject explosionPrefab;
void OnTriggerEnter2D(Collider2D other)
{
    //check if the object that collided with the enemy is a player bullet
    if(other.CompareTag("playerBullet"))
    {
        TakeDamage(1); //Reduce health by 1 for each bullet hit

        //destroy the bullet after it hits the enemy
        Destroy(other.gameObject);
    }
}

void TakeDamage(int damage)
{
    health -= damage; //subtract the damage from the enemy's health

    //check if health is zero or below
    if(health <= 0)
    {
Die(); //call the Die function if health is zero
    }
}
  
  private void OnCollisionEnter2D(Collision2D collision)
  {
    //check if the player collided with an enemy
    if(collision.gameObject.CompareTag("Player"))
    {
        Die();  //player dies instantly on contact with enemy;
    }
  }

  void Die()
  {

    Explode();
    //you can add death effects, score increases, etc., here
    Destroy(gameObject); //destroy the enemy game object
  }

  void Explode()
  {
    // Instantiate the explosion effect at the enemy's position and rotation
    GameObject explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
    Destroy(explosion, 1f);
  }
}
