using System;
using System.IO;
using UnityEngine;

public class NameManager : MonoBehaviour {
    public static NameManager Instance;
    
    public string username;
    public Highscore highscore;
    
    private void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }

        highscore = new Highscore() {
            name = "",
            value = 0
        };

        LoadHighscore();
    }

    public void SaveHighscore(int points) {
        highscore = new Highscore() {
            name = username,
            value = points
        };
        string json = JsonUtility.ToJson(highscore);

        File.WriteAllText(Application.persistentDataPath + "savegame.save", json);
    }

    public void LoadHighscore() {
        string saveFilePath = Application.persistentDataPath + "savegame.save";

        if (File.Exists(saveFilePath)) {
            string data = File.ReadAllText(saveFilePath);
            Highscore hs = JsonUtility.FromJson<Highscore>(data);
            highscore = hs;
        }   
    }
}

[Serializable]
public class Highscore {
    public string name;
    public int value;
}
