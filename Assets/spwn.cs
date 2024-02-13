using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject sphere;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            InvokeRepeating("Shot", 0.0f, 0.5f);
        }
        if (Input.GetKeyUp(KeyCode.H))
        {
            CancelInvoke();
        }
                }
        void Shot()
        {
            GameObject g = Instantiate(sphere);
            Destroy(g, 3f);
        }

    }

