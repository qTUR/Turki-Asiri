using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float rotationSpeed = 5f;
    public Vector3 offset;

    private float mouseX, mouseY;

    private bool isCursorVisible = true;

    private void Update()
    {
        mouseX += Input.GetAxis("Mouse X") * rotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * rotationSpeed;
        mouseY = Mathf.Clamp(mouseY, -90f, 90f);

        if (Input.GetKeyDown(KeyCode.P))
        {
            isCursorVisible = !isCursorVisible;
            Cursor.visible = isCursorVisible;

            if (isCursorVisible)
            {
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
    }
    private void LateUpdate()
    {
        Quaternion rotation = Quaternion.Euler(mouseY, mouseX, 0f);
        transform.position = target.position + rotation * offset;
        transform.LookAt(target);
    }
}