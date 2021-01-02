
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void LoadNextScene()
    {

        //We want the current build index of the scene and this is the way to get it!
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        if (currentSceneIndex > SceneManager.sceneCount)
            SceneManager.LoadScene(0);
        else
            SceneManager.LoadScene(currentSceneIndex + 1);
   }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }

}