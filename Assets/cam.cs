using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCube : MonoBehaviour
{
    public Transform cubeTransform;
    public Vector3 offset;

    private void Update()
    {
        transform.position = cubeTransform.position + offset;
    }
}
