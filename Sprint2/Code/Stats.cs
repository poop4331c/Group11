using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "TotalPts")
        {
            GetComponent<TextMesh>().text = "Total Points: " + GM.totalPoints;
        }

        if (gameObject.name == "TotalTime")
        {
            GetComponent<TextMesh>().text = "Total Time: " + GM.totalTime;
        }

    }
}
