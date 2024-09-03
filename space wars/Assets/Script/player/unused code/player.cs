using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
public float moveSpeed = 5f; //Adjust the movement speed in Inspector

    // Update is called once per frame
    void Update()
    {
       //Get input from the arrow keys or WASD keys
       float moveX = Input.GetAxis("Horizontal"); //left/right movement
       float moveY = Input.GetAxis("Vertical"); //Up/down movement

       //Create a Vector3 based on input
       Vector3 movement = new Vector3(moveX, moveY, 0f) * moveSpeed * Time.deltaTime;

       //Move the player
       transform.Translate(movement);
}
}
