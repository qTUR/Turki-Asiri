using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float speed = 5f;
    public PlayerActions a_PlayerActions;
    public Rigidbody Rigidbody;
    public Vector2 movement;
    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed * Time.deltaTime;

        transform.Translate(movement);

        if (Input.GetKeyDown(KeyCode.Space))
        {

            Vector3 jumpForce = new Vector3(0f, 5f, 0f);
            GetComponent<Rigidbody>().AddForce(jumpForce, ForceMode.Impulse);

        }     
     

    }
    public void OnEnable()
    {
        a_PlayerActions.Gameplay.Enable();
    }
    public void OnDisable()
    {


        a_PlayerActions.Gameplay.Disable();

    }
    public void FixedUp()
        {
        movement = a_PlayerActions.Gameplay.Gameplay.ReadValue<Vector2>();
        Rigidbody.velocity = new Vector3(movement.x * speed, Rigidbody.velocity.y, movement.y * speed);

        }
    public void Awake()
    {
        a_PlayerActions = new PlayerActions();
        Rigidbody = GetComponent<Rigidbody>();
        if (Rigidbody== null)
        {
            Debug.LogError("rigidBody is NULL for player");
        }


    }


}


