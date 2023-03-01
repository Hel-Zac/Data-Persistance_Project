using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void EnterName()
    { }
    public void GoToGame()
    {
        SceneManager.LoadScene("main");
    }
}
