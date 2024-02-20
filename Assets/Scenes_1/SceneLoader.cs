using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
   
   private void Start()
    {
        //StartCoroutine(LoadSceneCoroutine());
        
    }


    public void LOadScen() 
    {
        StartCoroutine(LoadSceneCoroutine());
    }
    private IEnumerator LoadSceneCoroutine()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("Level_1");
        while (!operation.isDone)
        {
            Debug.Log($"Progress:{operation.progress}");
            yield return null;
        }
    }
    


}
