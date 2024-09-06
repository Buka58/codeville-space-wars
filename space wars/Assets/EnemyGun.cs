using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour
{
      public GameObject bulletPrefab; //The bullet prefab to instantiate
    public Transform firepoint; //The point from where the bullet is fired
    public float shootingInterval = 2f; //The time between shots
    
    private float shootingTimer;

    void Update()
    {
        //Increment the timer
        shootingTimer += Time.deltaTime;

        //Shoot when the timer reaches the interval
        if(shootingTimer >= shootingInterval)
        {
            Shoot();
            shootingTimer = 0f;
        }
    }

    void Shoot()
    {
        //Instantiate the bullet at the fire point's positrion and rotation
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
    }
}
