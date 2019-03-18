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
    private GameManager gameplayManager;

    //Talking to the gamemanager
    void Awake()
    {
        gameplayManager = GameObject.FindObjectOfType<GameManager>();
    }
    // Update is called once per frame
    void Update()
    {
        Distance_ = Vector3.Distance(player.transform.position, startingPosition.transform.position);
        int distanceRounded = (int)Distance_;
        distanceMoved.text = distanceRounded.ToString();
    }
}
