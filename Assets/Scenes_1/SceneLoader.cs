using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadLevel1()
    {
        StartCoroutine(LoadSceneCoroutine("Level_1"));
    }

    public void LoadLevel2()
    {
        StartCoroutine(LoadSceneCoroutine("Level_2"));
    }
    public void LoadLevel3()
    {
        StartCoroutine(LoadSceneCoroutine("Level_3"));
    }
    public void LoadLevelHorro()
    {
        StartCoroutine(LoadSceneCoroutine("Horror"));
    }

    private IEnumerator LoadSceneCoroutine(string sceneName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);
        while (!operation.isDone)
        {
            Debug.Log($"Progress: {operation.progress}");
            yield return null;
        }
    }
}