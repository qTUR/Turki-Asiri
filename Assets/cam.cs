using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float rotationSpeed = 5f;
    public Vector3 offset;
    public PlayerActions a_PlayerActions;
    public Rigidbody Rigidbody;
    [SerializeField]
    private Transform playerTransform;
    private Vector2 mouseInput;

    private float mouseX, mouseY;

    private bool isCursorVisible = true;

    public float horizontalSensitivity = 5f;
    private float rotationY = 0f;

    public float minZoomDistance = 2f;
    public float maxZoomDistance = 10f;
    public float zoomSpeed = 0.25f;

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

    public void Awake()
    {
        a_PlayerActions = new PlayerActions();
        a_PlayerActions.Gameplay.ZoomCamera.performed += context => Zoom(context.ReadValue<float>());

        if (playerTransform == null)
        {
            Debug.LogError("playerTransform is NULL for camera!");
        }
    }

    public void Zoom(float zoomInput)
    {
        float zoomDistance = Mathf.Lerp(minZoomDistance, maxZoomDistance, zoomInput);
        offset = offset.normalized * zoomDistance;
        Debug.Log("Zoom Input: " + zoomInput);

    }

    public void FixedUpdate()
    {
        float rotationYDelta = horizontalSensitivity * mouseInput.x * Time.deltaTime;
        mouseInput = Vector2.zero;
        rotationY += rotationYDelta;
        Vector3 playerRotation = new Vector3(0f, rotationY, 0f);
        playerTransform.rotation = Quaternion.Euler(playerRotation);
    }

    public void OnEnable()
    {
        a_PlayerActions.Gameplay.Enable();
    }

    public void OnDisable()
    {
        a_PlayerActions.Gameplay.Disable();
    }
}