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
        // قم بتنفيذ رمز الاختبار الخاص بالركض هنا
        // يجب أن يُرجَع قيمة true عندما يتم تشغيل السيناريو المطلوب
        // وإلا، يجب أن يُرجَع قيمة false
        return false;
    }

    private bool IsMovingLeft()
    {
        // قم بتنفيذ رمز الاختبار الخاص بالحركة الجانبية لليسار هنا
        // يجب أن يُرجَع قيمة true عندما يتم تشغيل السيناريو المطلوب
        // وإلا، يجب أن يُرجَع قيمة false
        return false;
    }

    private bool IsMovingRight()
    {
        // قم بتنفيذ رمز الاختبار الخاص بالحركة الجانبية لليمين هنا
        // يجب أن يُرجَع قيمة true عندما يتم تشغيل السيناريو المطلوب
        // وإلا، يجب أن يُرجَع قيمة false
        return false;
    }

    private bool IsMovingBackward()
    {
        // قم بتنفيذ رمز الاختبار الخاص بالحركة الخلفية هنا
        // يجب أن يُرجَع قيمة true عندما يتم تشغيل السيناريو المطلوب
        // وإلا، يجب أن يُرجَع قيمة false
        return false;
    }

    private bool IsRolling()
    {
        // قم بتنفيذ رمز الاختبار الخاص بالقفزة هنا
        // يجب أن يُرجَع قيمة true عندما يتم تشغيل السيناريو المطلوب
        // وإلا، يجب أن يُرجَع قيمة false
        return false;
    }

    private bool IsShooting()
    {
        // قم بتنفيذ رمز الاختبار الخاص بإطلاق النار هنا
        // يجب أن يُرجَع قيمة true عندما يتم تشغيل السيناريو المطلوب
        // وإلا، يجب أن يُرجَع قيمة false
        return false;
    }
}