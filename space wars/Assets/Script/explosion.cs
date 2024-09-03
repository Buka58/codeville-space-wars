using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{
    public float lifetime = 1.0f;  //set this to the length of your explosion animation

    void ExplosionDone()
    {
        Destroy(gameObject, lifetime);
    }
}
