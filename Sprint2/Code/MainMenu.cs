//Code for the main menu

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string newGameScene;
    public string highscoreTableScene;
    public GameObject HowToPanel;
    public bool isLoaded;

    public void NewGame()
    {
        SceneManager.LoadScene(newGameScene);
     }

    //Opens a pop up box that displays the high score
    public void HighScore()
    {
        SceneManager.LoadScene(highscoreTableScene);
    }

    //Opens a pop up box that displays the instructions
    public void OpenHowToPanel()
    {
       

        if ( HowToPanel != null)
        {
            bool isActiveHowTo = HowToPanel.activeSelf;

            HowToPanel.SetActive(!isActiveHowTo);
       
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}