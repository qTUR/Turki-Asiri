using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("isRunning", true);
            animator.SetBool("isIdle", false);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("isRunning", false);
            animator.SetBool("isIdle", true);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetFloat("moveDirection", -1);
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetFloat("moveDirection", 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetFloat("moveDirection", 1);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetFloat("moveDirection", 0);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("isBackward", true);
            animator.SetBool("isIdle", false);
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("isBackward", false);
            animator.SetBool("isIdle", true);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger("roll");
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetTrigger("shoot");
        }
    }
}