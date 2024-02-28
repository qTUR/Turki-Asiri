using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxEnemyTrigger : MonoBehaviour
{
    public GameObject spawner;
    public int numEnemiesToSpawn = 5;
    public float spawnDelay = 3f;
    public float enemyLifetime = 5f;

    private bool playerInRange = false;
    private int spawnedEnemies = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            StartCoroutine(SpawnEnemies());
            Debug.Log("Player is attacking!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }

    private IEnumerator SpawnEnemies()
    {
        while (playerInRange && spawnedEnemies < numEnemiesToSpawn)
        {
            yield return new WaitForSeconds(spawnDelay);

            GameObject enemy = Instantiate(spawner, transform.position, transform.rotation);
            Destroy(enemy, enemyLifetime);

            spawnedEnemies++;
        }
    }
}