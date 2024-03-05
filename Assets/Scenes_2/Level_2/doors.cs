using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DoorController : MonoBehaviour
{
    private NavMeshObstacle obstacle;
    private bool doorOpen = false;

    private void Start()
    {
        obstacle = GetComponent<NavMeshObstacle>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            if (doorOpen)
            {
                CloseDoor();
            }
            else
            {
                OpenDoor();
            }
        }
    }

    private void OpenDoor()
    {
        obstacle.enabled = false;
        doorOpen = true;
    }

    private void CloseDoor()
    {
        obstacle.enabled = true;
        doorOpen = false;
    }
}