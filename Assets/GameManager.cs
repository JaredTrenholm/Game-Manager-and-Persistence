using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public static Scene currentScene;
    public static int gameManagerCount = 0;
    public float health;
    public float experience;

    private void Awake()
    {
        currentScene = SceneManager.GetActiveScene();
        if (gameManager == null)
        {
            DontDestroyOnLoad(this.gameObject);
            gameManager = this;
            gameManagerCount += 1;
        } else if (gameManager != this.gameObject){
            Destroy(this.gameObject);
        }
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 30), "Health: " + health);
        GUI.Label(new Rect(10, 40, 100, 30), "Experience: " + experience);
        GUI.Label(new Rect(10, 70, 100, 30), "Game Manager Count: " + gameManagerCount);
    }

    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");
        
        PlayerData data = new PlayerData();
        data.health = health;
        data.experience = experience;
        data.scene = currentScene.buildIndex;

        bf.Serialize(file, data);
        file.Close();
    }
    public void Load()
    {
        if(File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);

            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            health = data.health;
            experience = data.experience;
            SceneManager.LoadScene(data.scene);
        }
    }
    public bool CanLoad()
    {
        if (File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            return true;
        }
        return false;
    }
    public void Quit()
    {
        Application.Quit();
    }
}


[Serializable]
class PlayerData {
    public float health;
    public float experience;
    public int scene;
}
