using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CubeAnimation : MonoBehaviour
{
    public float rotationSpeed = 1f;
    public float rotationRadius = 1f;
    public float animationDelay = 5f;

    private Vector3 targetPosition;
    private Vector3 initialPosition;

    private void Start()
    {
        initialPosition = transform.position;
        targetPosition = initialPosition + new Vector3(2f, 2f, 0f);
        StartCoroutine(StartAnimation());
    }

    private IEnumerator StartAnimation()
    {
        yield return new WaitForSeconds(animationDelay);

        while (true)
        {
            transform.DOMove(targetPosition, 1f).SetEase(Ease.Linear);
            yield return new WaitForSeconds(1f);

            float time = 0f;
            while (time < Mathf.PI * 2f)
            {
                time += Time.deltaTime * rotationSpeed;

                float offsetX = Mathf.Cos(time) * rotationRadius;
                float offsetZ = Mathf.Sin(time) * rotationRadius;
                Vector3 newPosition = initialPosition + new Vector3(offsetX, 0f, offsetZ);

                transform.DOMove(newPosition, 0.1f);
                yield return null;
            }

            yield return new WaitForSeconds(1f);
        }
    }
}