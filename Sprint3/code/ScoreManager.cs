//Code to keep track of score (distance + powerups) and highscore in game

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text score;
    public Text highscore;
    public GameObject player;
    public GameObject startingPosition;
    public float Distance;
    public float highscoreCount;
    public bool DistanceIncreasing;

    /*public void Awake()
    {
        if (!PlayerPrefs.HasKey("HighScore"))
        {
            highscoreCount = 0;
            PlayerPrefs.SetFloat("HighScore", highscoreCount);
        }
    } */

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("HighScore")) {
            highscoreCount = PlayerPrefs.GetFloat("HighScore");
        }
    }

    void Update()
    {

        //Checking if player is still alive
        if (DistanceIncreasing)
        {
            Distance = Vector3.Distance(player.transform.position, startingPosition.transform.position) + EnviormentGM.crystalPowerUpTotal;
        }

        score.text = calculateDistance(Distance).ToString();


        if (Distance > highscoreCount)
        {
            highscoreCount = Distance;
            PlayerPrefs.SetFloat("HighScore", highscoreCount);
        }

        highscore.text = "" + (int)highscoreCount;


    }

    public static int calculateDistance(float distance)
    {
        int distanceRounded = (int)distance;
        return distanceRounded;
    }

}
