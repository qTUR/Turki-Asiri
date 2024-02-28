using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement_1 : MonoBehaviour
{
    public float speed;
    public GameObject player;
    private bool isAttacking = false;

    private void Start()
    {
        SetPlayer(player);
    }

    public void Update()
    {
        if (player != null && isAttacking)
        {
            Vector3 direction = player.transform.position - transform.position;
            transform.rotation = Quaternion.LookRotation(direction);

            transform.position += transform.forward * speed * Time.deltaTime;
        }
    }

    public void SetPlayer(GameObject newPlayer)
    {
        player = newPlayer;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isAttacking = true;
            Attack();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isAttacking = false;
        }
    }

    void Attack()
    {
        Debug.Log("Enemy is attacking!");
    }
}