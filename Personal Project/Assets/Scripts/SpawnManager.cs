using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemies;

    private float zEnemySpawn = 12;
    private float xEnemySpawn = 22;

    private float enemySpawnTime = 2.0f;
    private float startDelay = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", startDelay, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(-xEnemySpawn, xEnemySpawn);
        float randomZ = Random.Range(-zEnemySpawn, zEnemySpawn);

        Vector3 spawnPos = new Vector3(randomX, 1, randomZ);

        Instantiate(enemies, spawnPos, enemies.gameObject.transform.rotation);
    }
}
