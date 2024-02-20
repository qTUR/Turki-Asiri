using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject spherePrefab;
    public Transform sphereSpawnPoint;
    public float sphereSpeed = 5f;
    public float fireRate = 2f;
    public GameObject alertObject;

    Coroutine c;
    private bool isHit;

    private void Start()
    {
        
        c =StartCoroutine(FireSphereCoroutine());

    }


    private void Update()
    {/*
        if (Input.GetKeyDown(KeyCode.D))
        {
            StopCoroutine(c);
            //c= null;
        }
        if (Input.GetKeyUp(KeyCode.D)) 
        {
            StartCoroutine(c);
            return;
        }*/
    }

    private void StartCoroutine(Coroutine c)
    {
        
    }

    private IEnumerator FireSphereCoroutine()
    {
        while (true)
        {
            GameObject sphere = Instantiate(spherePrefab, sphereSpawnPoint.position, Quaternion.identity);
            Rigidbody sphereRigidbody = sphere.GetComponent<Rigidbody>();
         sphereRigidbody.velocity = sphereSpawnPoint.forward * sphereSpeed;
         Destroy(sphere, 5f); 
            yield return new WaitForSeconds(1f/ fireRate);
        }
        

       
    }
}