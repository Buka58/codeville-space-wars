using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunScript : MonoBehaviour
{
    public GameObject bulletPrefab; // the bullet prefab to instantiate
    public Transform firePoint;   //The point from where the bullet is fired
    public AudioSource[] soundFX;
    // Update is called once per frame
    void Update()
    {
      //Check if the spacebar is pressed 
       if(Input.GetKeyDown(KeyCode.Space))
       {
        Shoot();
        soundFX[0].Play();
       }   

    }

    void Shoot()
    {
    //instantiate the bullet  at the fire point's position  and rotation
    Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
