using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{
    public GameObject player;
    public GameObject startingPosition;
    public float Distance_;
    public Text distanceMoved;
 
    void Update()
    {
        Distance_ = Vector3.Distance(player.transform.position, startingPosition.transform.position);
        distanceMoved.text = calculateDistance(Distance_).ToString();
    }

    public static int calculateDistance(float distance)
    {
        int distanceRounded = (int)distance;
        return distanceRounded;
    }
}
