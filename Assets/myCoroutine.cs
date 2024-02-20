using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float minY = 2f;
    public float maxY = 8f;

    private bool isMovingUp = true;

    private void Start()
    {
        StartCoroutine(MoveCoroutine());
    }

    private IEnumerator MoveCoroutine()
    {
        while (true)
        {
            if (isMovingUp)
            {
                MoveUp();
            }
            else
            {
                MoveDown();
            }

            yield return null; 
        }
    }

    private void MoveUp()
    {
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

        if (transform.position.y >= maxY)
        {
            isMovingUp = false;
        }
    }

    private void MoveDown()
    {
        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);

        if (transform.position.y <= minY)
        {
            isMovingUp = true;
        }
    }
}