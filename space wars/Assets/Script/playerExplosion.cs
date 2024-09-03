using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerExplosion : MonoBehaviour
{
    public GameObject explosionPrefab;
    public Transform explosionpoint;

    void Update()
    {
         if(GameObject.FindGameObjectWithTag("Player") == null)
     {
        Explode();
     }   
    }

        void Explode()
    {
GameObject explosion = Instantiate(explosionPrefab, explosionpoint.position, explosionpoint.rotation);
    Destroy(explosion, 1f);
    }

}
