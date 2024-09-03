using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    [SerializeField] private int currentHealth;
    // public GameObject explosionPrefab;
    // public Transform explosionpoint;


    void Start()
    {
        //Initialize player health
        currentHealth = maxHealth;
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if(currentHealth <= 0)
        {
            Die();
            // GameOver();
        } 
    }

    void Die()
    {
        //Add logic for player health, e.g, play animation, show game over screen
        Debug.Log("Player Died");
        Destroy(gameObject); //destroy the player gameObject
        //  Explode();
    }

//     void Explode()
//     {
// GameObject explosion = Instantiate(explosionPrefab, explosionpoint.position, explosionpoint.rotation);
//     Destroy(explosion, 1f);
//     }

private void OnTriggerEnter2D(Collider2D collision)
{
    //check if the collision bullet is an enemy bullet
    enemyBullet bullet = collision.GetComponent<enemyBullet>();
    if(bullet != null && bullet.isEnemy)
    {
        TakeDamage(1);  //assume each bullet does 1 damage

        Destroy(bullet.gameObject);  //Destroy the bullet
    }

}

// void GameOver()
// {
// Time.timeScale = 0;
// }



private void  OnCollisionEnter2D(Collision2D collision)
{
    //check if the player collided with an enemy
    if(collision.gameObject.CompareTag("Enemy"))
    {
        Die(); //player dies instantly on attack with the enemy
        // GameOver();
        
    }
}


}
