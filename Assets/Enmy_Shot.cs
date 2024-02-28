using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletSpeed = 10f;
    public float shootInterval = 2f;
    public float attackRange = 20f;

    private float nextShootTime;
    private GameObject player;

    private void Start()
    {
        nextShootTime = Time.time + shootInterval;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        if (player != null)
        {
            Vector3 directionToPlayer = player.transform.position - transform.position;
            float distanceToPlayer = directionToPlayer.magnitude;

            if (distanceToPlayer <= attackRange)
            {
                RotateTowardsPlayer(directionToPlayer);

                if (Time.time >= nextShootTime)
                {
                    ShootAtPlayer();
                    nextShootTime = Time.time + shootInterval;
                }
            }
        }
    }

    private void RotateTowardsPlayer(Vector3 direction)
    {
        Quaternion lookRotation = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, lookRotation, Time.deltaTime * 360f);
    }

    private void ShootAtPlayer()
    {
        Vector3 directionToPlayer = (player.transform.position - transform.position).normalized;
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody>().velocity = directionToPlayer * bulletSpeed;
        Destroy(bullet, 5f);
    }
}