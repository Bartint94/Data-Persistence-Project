using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;


public class MenuMang : MonoBehaviour
{
    public static MenuMang Instance;
    public string pname;
    public string bestPlayer;
    public int bestScore = -1;
    private void Awake()
    {
        if(Instance!=null)
        {
            Destroy(gameObject);
            return;
        }
        
        Instance = this;
        DontDestroyOnLoad(Instance);
       
    }
    [System.Serializable]
    public class SaveData
    {
        public int bestScore;
        public string bestPlayer;

    }
    public void Save()
    {
        SaveData data = new SaveData();
        data.bestScore = bestScore;
        data.bestPlayer = bestPlayer;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    public void Load()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            bestScore = data.bestScore;
            bestPlayer = data.bestPlayer;
        }
    }

}
   