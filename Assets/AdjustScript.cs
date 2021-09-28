using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustScript : MonoBehaviour
{
    private void OnGUI()
    {
        if (GUI.Button(new Rect(10, 100, 120, 30), "Health Up!"))
        {
            GameManager.gameManager.health += 10;
        }
        if (GUI.Button(new Rect(10, 150, 120, 30), "Health Down!"))
        {
            if (GameManager.gameManager.health - 10 < 0)
                return;
            GameManager.gameManager.health -= 10;
        }
        if (GUI.Button(new Rect(10, 200, 120, 30), "Experience Up!"))
        {
            GameManager.gameManager.experience += 10;
        }
        if (GUI.Button(new Rect(10, 250, 120, 30), "Experience Down!"))
        {
            if (GameManager.gameManager.experience - 10 < 0)
                return;
            GameManager.gameManager.experience -= 10;
        }
        if (GUI.Button(new Rect(10, 300, 120, 30), "Save"))
        {
            GameManager.gameManager.Save();
        }
        if (GUI.Button(new Rect(10, 350, 120, 30), "Load"))
        {
            GameManager.gameManager.Load();
        }
    }
}
