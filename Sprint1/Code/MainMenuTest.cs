//Code for main menu with test cases

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string newGameScene;
    public GameObject HowToPanel;
    public GameObject HighScorePanel;
    public bool isLoaded;

    public void NewGame()
    {
        SceneManager.LoadScene(newGameScene);
     }

    //Opens a pop up box that displays the high score
    public void HighScore()
    {
        //Highscore Panel test
        if (HighScorePanel == null)
            Debug.Log("Failed to open Highscore Panel");
        else
            Debug.Log("Highscore panel successful");

        if(HighScorePanel != null)
        {
            bool isActiveHighScore = HighScorePanel.activeSelf;

            HighScorePanel.SetActive(!isActiveHighScore);
        }

    }

    //Opens a pop up box that displays the instructions
    public void OpenHowToPanel()
    {
        //How To Panel test
        if (HowToPanel == null)
            Debug.Log("Failed to open How To Panel");
        else
            Debug.Log("HowTo panel successful");

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
