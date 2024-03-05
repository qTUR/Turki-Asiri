using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxEnemyTrigger : MonoBehaviour
{
    public GameObject spawner;
    public int numEnemiesToSpawn = 5;
    public float spawnDelay = 3f;
    public float enemyLifetime = 5f;

    public AudioClip consoleSound;

    private bool playerInRange = false;
    private int spawnedEnemies = 0;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = consoleSound;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            StartCoroutine(SpawnEnemies());
            Debug.Log("Player is attacking!");

            audioSource.Play();
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