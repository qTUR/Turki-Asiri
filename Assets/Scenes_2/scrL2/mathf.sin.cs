using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    public float rotationSpeed = 1f;
    public float rotationRadius = 1f;

    private Vector3 initialPosition;

    private void Start()
    {
        initialPosition = transform.position;
    }

    private void Update()
    {
        float time = Time.time * rotationSpeed;
        float offsetX = Mathf.Cos(time) * rotationRadius;
        float offsetZ = Mathf.Sin(time) * rotationRadius;

        transform.position = initialPosition + new Vector3(offsetX, 0f, offsetZ);

      
        Vector3 arrowStart = transform.position;
        Vector3 arrowEnd = arrowStart + transform.forward * 2f;
        Debug.DrawLine(arrowStart, arrowEnd, Color.red);
        Debug.DrawLine(arrowEnd, arrowEnd + (Quaternion.Euler(0f, 135f, 0f) * transform.forward * 0.5f), Color.red); 
        Debug.DrawLine(arrowEnd, arrowEnd + (Quaternion.Euler(0f, -135f, 0f) * transform.forward * 0.5f), Color.red);
    }
}