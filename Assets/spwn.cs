using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject sphere;

    public object Up { get; private set; }

    // Update is called once per frame
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
        GameObject g = Instantiate(sphere, transform.position + Vector3 Up.forward, Quaternion.identity);
        Destroy(g, 5f);

        
        Physics.IgnoreCollision(g.GetComponent<Collider>(), GetComponent<Collider>());
    }

    private GameObject Instantiate(GameObject sphere, object value, object forward, Quaternion identity)
    {
        throw new NotImplementedException();
    }
}
