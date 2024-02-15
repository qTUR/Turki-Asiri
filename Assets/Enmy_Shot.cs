using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject spherePrefab;
    public Transform sphereSpawnPoint;
    public float sphereSpeed = 5f;
    public float fireRate = 1f;
    public GameObject alertObject;

    private float nextFireTime;
    private bool isHit;

    private void Start()
    {
        nextFireTime = Time.time;
    }

    private void Update()
    {
        if (Time.time >= nextFireTime)
        {
            FireSphere();
            nextFireTime = Time.time + 1f / fireRate;
        }
    }

    private void FireSphere()
    {
        GameObject sphere = Instantiate(spherePrefab, sphereSpawnPoint.position, Quaternion.identity);
        Rigidbody sphereRigidbody = sphere.GetComponent<Rigidbody>();
        sphereRigidbody.velocity = sphereSpawnPoint.forward * sphereSpeed;
        Destroy(sphere, 5f);
    }
}