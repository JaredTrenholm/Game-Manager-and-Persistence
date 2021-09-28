using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustScript : MonoBehaviour
{
    private void OnGUI()
    {
        if (GUI.Button(new Rect(150, 10, 120, 30), "Health Up!"))
        {
            GameManager.gameManager.health += 10;
        }
        if (GUI.Button(new Rect(150, 45, 120, 30), "Health Down!"))
        {
            if (GameManager.gameManager.health - 10 < 0)
                return;
            GameManager.gameManager.health -= 10;
        }
        if (GUI.Button(new Rect(150, 80, 120, 30), "Experience Up!"))
        {
            GameManager.gameManager.experience += 10;
        }
        if (GUI.Button(new Rect(150, 115, 120, 30), "Experience Down!"))
        {
            if (GameManager.gameManager.experience - 10 < 0)
                return;
            GameManager.gameManager.experience -= 10;
        }
        if (GUI.Button(new Rect(150, 150, 120, 30), "Level Up!"))
        {
            GameManager.gameManager.level += 1;
        }
        if (GUI.Button(new Rect(150, 185, 120, 30), "Level Down!"))
        {
            if (GameManager.gameManager.level - 1 < 0)
                return;
            GameManager.gameManager.level -= 1;
        }
        if (GUI.Button(new Rect(150, 220, 120, 30), "Gold Up!"))
        {
            GameManager.gameManager.gold += 10;
        }
        if (GUI.Button(new Rect(150, 255, 120, 30), "Gold Down!"))
        {
            if (GameManager.gameManager.gold - 10 < 0)
                return;
            GameManager.gameManager.gold -= 10;
        }
        if (GUI.Button(new Rect(150, 290, 120, 30), "Score Up!"))
        {
            GameManager.gameManager.score += 10;
        }
        if (GUI.Button(new Rect(150, 325, 120, 30), "Score Down!"))
        {
            if (GameManager.gameManager.score - 10 < 0)
                return;
            GameManager.gameManager.score -= 10;
        }
        if (GUI.Button(new Rect(150, 360, 120, 30), "Shield Up!"))
        {
            GameManager.gameManager.shield += 10;
        }
        if (GUI.Button(new Rect(150, 395, 120, 30), "Shield Down!"))
        {
            if (GameManager.gameManager.shield - 10 < 0)
                return;
            GameManager.gameManager.shield -= 10;
        }
    }
}
