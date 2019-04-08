using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class PlayerMovement : MonoBehaviour
{
    public GameManager gameManager;
    // keybindings for left, right, forward and backward movement
    public KeyCode moveLeft;
    public KeyCode moveRight;
    public KeyCode moveForward;
    public KeyCode moveBackward;

    public Rigidbody rB;

    public float zForce = 500f;
    public float xForce = 500f;
    public float yForce = 500f;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // controls players forward motion
        //GetComponent<Rigidbody>().velocity = new Vector3(horizanalMovement, 0, 2);

        // if the key is pressed move left 
        // if key is pressed move right
        if (Input.GetKey(moveLeft))
        {
            rB.AddForce(-(xForce) * Time.deltaTime, 0, 0);
            //StartCoroutine(stopSliding());
        }
        if (Input.GetKey(moveRight))
        {
            rB.AddForce(xForce * Time.deltaTime, 0, 0);
            //StartCoroutine(stopSliding());
        }

        rB.AddForce(0, 0, zForce * Time.deltaTime);
        
    }

    // How the player will react to different collisions
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Lethal")
        {
            // kill player
            // Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Power up")
        {

            Destroy(collision.gameObject);
            EnviormentGM.crystalPowerUpTotal += 5;

        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Lethal")
        {
            gameManager.EndGame();
        }
    }

    public void OnMessageArrived(string message)
    {
        int comma1, comma2, connection, attention, meditation;
        string sub1, sub2, sub3, smallmessage;

        comma1 = message.IndexOf(',');
        smallmessage = message.Substring(comma1 + 1);
        comma2 = smallmessage.IndexOf(',');

        sub1 = message.Substring(0, comma1);
        sub2 = smallmessage.Substring(0, comma2);
        sub3 = smallmessage.Substring(comma2 + 1);

        Debug.Log(String.Format("Connection: {0} Attention: {1} Meditation: {2}", sub1, sub2, sub3));

        connection = Int32.Parse(sub1);
        attention = Int32.Parse(sub2);
        meditation = Int32.Parse(sub3);

        //adjustments
        attention -= 45;
        meditation -= 45;

        if (connection <= 25)
        {
            zForce = 0;
            return;
        }

        zForce = attention;

        //zForce = (float)attention / 100;

        Debug.Log(String.Format("Horizontal: {0}", zForce));
    }

}
