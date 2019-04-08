using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public string highscoreTableScene;
    public Text scoreText;
    public addToScoreTable newEntry;
    public ScoreManager scoreManager;
    public GameController gameController;
    public string playerName;
    public static float finalScore;


    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        gameController = FindObjectOfType<GameController>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey("p"))
        {
            Debug.Break();
        }
 
    }

    bool gameHasEnded = false;
    
    public void EndGame()
    {
        if (!gameHasEnded)
        {
            scoreManager.DistanceIncreasing = false;
            gameHasEnded = true;
            Restart();
        }
    }

    //Whehn player dies, the new entry is sent to score table
    public void Restart()
    {
         finalScore = scoreManager.Distance;
         playerName = PlayerPrefs.GetString("PlayerName");
         scoreManager.Distance = 0;
         scoreManager.DistanceIncreasing = true;
         newEntry.AddHighscoreEntry((int)finalScore, playerName);
         SceneManager.LoadScene(highscoreTableScene);
    }
}
