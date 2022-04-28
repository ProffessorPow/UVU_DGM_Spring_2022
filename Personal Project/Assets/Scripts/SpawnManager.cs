using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemies;
    public GameObject powerUp;
    public GameObject player;

    private float zEnemySpawn = 12;
    private float xEnemySpawn = 22;

    private float enemySpawnTime = 20.0f;
    private float startDelay = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", startDelay, enemySpawnTime);
        Invoke("SpawnPlayer", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(-xEnemySpawn, xEnemySpawn);
        float randomZ = Random.Range(-zEnemySpawn, zEnemySpawn);

        Vector3 spawnPos = new Vector3(randomX, 1.6f, randomZ);

        Instantiate(enemies, spawnPos, enemies.gameObject.transform.rotation);
    }

    void SpawnPowerUp()
    {
        float randomX = Random.Range(-xEnemySpawn, xEnemySpawn);
        float randomZ = Random.Range(-zEnemySpawn, zEnemySpawn);

        Vector3 spawnPos = new Vector3(randomX, 1.6f, randomZ);

        Instantiate(enemies, spawnPos, enemies.gameObject.transform.rotation);
    }

    void SpawnPlayer()
    {
        Vector3 spawnPos = new Vector3(0, 0.1f, 0);

        Instantiate(player, spawnPos, player.gameObject.transform.rotation);
    }
}
