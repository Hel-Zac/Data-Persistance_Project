using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StartMenu : MonoBehaviour
{
    [SerializeField] TMP_InputField playerName;

    public void GoToGame()
    {
        if (playerName.text != "")
        {
            SavedData.name = playerName.text;
            SceneManager.LoadScene("main");
        }
    }
}
