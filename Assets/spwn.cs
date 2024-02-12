using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwn : MonoBehaviour
{
    public GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.H)) {
        
            GameObject g=    Instantiate(sphere);
            Destroy(g,3);

        }
    }
}
