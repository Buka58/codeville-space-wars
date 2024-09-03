using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObstacle : MonoBehaviour
{
   [SerializeField] private GameObject enemy;

void Start()
{
    InvokeRepeating("SpawnEnemy", 3, 1);
}


private void SpawnEnemy()
{
    Instantiate(enemy);
}
}
