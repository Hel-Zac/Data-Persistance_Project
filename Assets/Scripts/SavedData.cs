using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class SavedData
{
    public static string name;
    public static string nameBest;
    public static int bestScore = 0;

    public static void SaveAll()
    {
        SavedDataFile data = new();
        data.nameBest = nameBest;
        data.bestScore = bestScore;
        string json = JsonUtility.ToJson(data);
        System.IO.File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    public static void LoadAll()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (System.IO.File.Exists(path))
        {
            string json = System.IO.File.ReadAllText(path);
            SavedDataFile data = JsonUtility.FromJson<SavedDataFile>(json);

            nameBest = data.nameBest;
            bestScore = data.bestScore;
        }
        else
        {
            nameBest = "";
            bestScore = 0;
        }
    }
}

[Serializable]
public class SavedDataFile
{
    public string nameBest;
    public int bestScore;
}