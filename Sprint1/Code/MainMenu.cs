//Updated code for the Main Menu

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string newGameScene;
    public GameObject HowToPanel;
    public GameObject HighScorePanel;
 
    public void NewGame()
    {
        SceneManager.LoadScene(newGameScene);
    }

    //Opens a pop up box that displays the high score
    public void HighScore()
    {
        if(HighScorePanel != null)
        {
            bool isActive = HighScorePanel.activeSelf;

            HighScorePanel.SetActive(!isActive);
        }

    }

    //Opens a pop up box that displays the instructions
    public void OpenHowToPanel()
    {
        if ( HowToPanel != null)
        {
            bool isActive = HowToPanel.activeSelf;

            HowToPanel.SetActive(!isActive);
       
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
