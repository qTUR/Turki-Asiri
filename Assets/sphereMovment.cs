using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereMovment : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position+= new Vector3(0,0,speed);
    }
}
