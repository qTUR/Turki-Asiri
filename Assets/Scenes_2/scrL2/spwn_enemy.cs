using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 3f;
    public float enemyLifetime = 5f;
    public float rotationDuration = 2f;
    public Ease rotationEase = Ease.Linear;

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);

            GameObject enemy = Instantiate(enemyPrefab, transform.position, transform.rotation);
            Destroy(enemy, enemyLifetime);

            RotateEnemyOnce(enemy.transform);
        }
    }

    private void RotateEnemyOnce(Transform enemyTransform)
    {
        enemyTransform.DORotate(new Vector3(0f, 360f, 0f), rotationDuration, RotateMode.FastBeyond360)
            .SetEase(rotationEase);
    }
}