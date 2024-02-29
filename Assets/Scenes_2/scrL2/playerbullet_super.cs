using UnityEngine;

public class PlayerBulletSuper : MonoBehaviour
{
    private bool buttonPressed = false;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            buttonPressed = true;
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            buttonPressed = false;
        }

        if (buttonPressed)
        {
           
            Debug.Log("Bang!");
        }
    }
}