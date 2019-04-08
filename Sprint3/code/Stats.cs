using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    private int totalScore;
    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "Total PowerUps")
        {
            GetComponent<TextMesh>().text = "Total Powerups: " + EnvironmentGM.crystalPowerUpTotal;
        }
        if (gameObject.name == "Total Points")
        {
        //    GetComponent<TextMesh>().text = "Points: " + EnviormentGM.crystalPowerUpTotal;
         //   GetComponent<TextMesh>().text = "Distance: " + GameManager.finalScore;
            GetComponent<TextMesh>().text = "Total Score: " + (int)GameManager.finalScore;
        }
    }
}
