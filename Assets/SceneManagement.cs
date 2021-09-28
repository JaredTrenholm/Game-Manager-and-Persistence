using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void LoadScene(int value)
    {
        if (value + 1 > SceneManager.sceneCountInBuildSettings)
            value = SceneManager.sceneCountInBuildSettings;
        SceneManager.LoadScene(value);
    }    
}
