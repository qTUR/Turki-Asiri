using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject sphere;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            InvokeRepeating("Shot", 0.0f, 0.5f);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            CancelInvoke();
        }
    }

    void Shot()
    {
        GameObject g = Instantiate(sphere, transform.position + Vector3 .forward, Quaternion.identity);
        
    }
}
