//Code to get user input

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public string newGameScene;
    public string inputName;

    public void GetInput(string name)
    {
        inputName = name;
        PlayerPrefs.SetString("PlayerName", name);
    }

    public void NewGame()
    {
        SceneManager.LoadScene(newGameScene);
    }

}
