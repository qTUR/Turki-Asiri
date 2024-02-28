using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    public float speed;
    private GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        if (player != null)
        {
            Vector3 directionToPlayer = player.transform.position - transform.position;
            transform.rotation = Quaternion.LookRotation(directionToPlayer);

            float distanceToPlayer = directionToPlayer.magnitude;

            if (distanceToPlayer <= 7f)
            {
                Attack();
            }
            else
            {
                MoveTowardsPlayer();
            }
        }
    }

    private void MoveTowardsPlayer()
    {
        Vector3 directionToPlayer = player.transform.position - transform.position;
        transform.position += directionToPlayer.normalized * speed * Time.deltaTime;
    }

    private void Attack()
    {
        Debug.Log("Attacking Player!");


    }

    private void DisableExplosionComponents(GameObject targetObject)
    {
        ExplosionComponent explosionComponent = targetObject.GetComponentInChildren<ExplosionComponent>();

        if (explosionComponent != null)
        {
            explosionComponent.enabled = false;
        }
    }
}