﻿using System.Collections;
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
        // تشغيل الركض
        if (IsRunning())
        {
            animator.SetBool("isRunning", true);
            animator.SetBool("isIdle", false);
        }
        else
        {
            animator.SetBool("isRunning", false);
            animator.SetBool("isIdle", true);
        }

        // تشغيل الحركة الجانبية
        if (IsMovingLeft())
        {
            animator.SetFloat("moveDirection", -1);
        }
        else if (IsMovingRight())
        {
            animator.SetFloat("moveDirection", 1);
        }
        else
        {
            animator.SetFloat("moveDirection", 0);
        }

        // الحركة الخلفية
        if (IsMovingBackward())
        {
            animator.SetBool("isBackward", true);
            animator.SetBool("isIdle", false);
        }
        else
        {
            animator.SetBool("isBackward", false);
            animator.SetBool("isIdle", true);
        }

        // القفزة
        if (IsRolling())
        {
            animator.SetTrigger("roll");
        }

        // إطلاق النار
        if (IsShooting())
        {
            animator.SetTrigger("shoot");
        }
    }

    private bool IsRunning()
    {
        
        return false;
    }

    private bool IsMovingLeft()
    {
        return false;
    }

    private bool IsMovingRight()
    {
       
        return false;
    }

    private bool IsMovingBackward()
    {
        
        return false;
    }

    private bool IsRolling()
    {
        
        return false;
    }

    private bool IsShooting()
    {        return false;
    }
}