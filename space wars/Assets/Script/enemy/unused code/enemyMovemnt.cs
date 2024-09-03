using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovemnt : MonoBehaviour
{
    public float min_Y, max_Y;
    public float min_X, max_X;
    public float moveSpeed = 10f;

    void Update()
    {
MoveEnemy();
CheckIfOffScreen();
    }

    void MoveEnemy()
    {
        //Example movement logic, you can customize it based on your game
        Vector3 temp = transform.position;
        temp.x -= moveSpeed * Time.deltaTime; //Move left

        transform.position = temp;
    }

    private void CheckIfOffScreen()
    {
        //Destroy the enemy if it leaves the screen view on the left
        if(transform.position.x < min_X)
        {
            Destroy(gameObject);
        }
    }
}
