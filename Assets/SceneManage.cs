using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    private void OnGUI()
    {
        if (GUI.Button(new Rect(140, 100, 120, 30), "Load Scene One"))
        {
            SceneManager.LoadScene(0);
        }
        if (GUI.Button(new Rect(140, 150, 120, 30), "Load Scene Two"))
        {
            SceneManager.LoadScene(1);
        }
        if (GUI.Button(new Rect(140, 200, 120, 30), "Load Scene Three"))
        {
            SceneManager.LoadScene(2);
        }
    }
}
