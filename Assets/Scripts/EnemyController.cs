using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;

    private float enemyTimer = 0.0f;
    private float enemySpawnInteval = 1.0f;
    private float enemySpawnDistance = 10.0f;

    private void Update()
    {
        enemyTimer -= Time.deltaTime;
        if (enemyTimer <= 0)
        {
            enemyTimer = enemySpawnInteval;

            float spawnAngle = Random.Range(0,360);

            GameObject enemyObject = GameObject.Instantiate<GameObject>(enemy);
            Debug.Log("Enemy Spawned");
            enemyObject.transform.position = new Vector3
                (
                    player.transform.position.x + Mathf.Cos(spawnAngle) * enemySpawnDistance,
                    player.transform.position.y,
                    player.transform.position.z + Mathf.Sin(spawnAngle) * enemySpawnDistance
                );
        }
    }
}