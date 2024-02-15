using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float speed = 5f;

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

}
