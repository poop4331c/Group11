using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayerControler : MonoBehaviour
{
    public float speed; //speed variable is now in unity that you can edit
    public Text winText;

    public float hori = 0;
    public float verdi = 0;

    private Rigidbody rb;
    private int count;
    
    public int successfulconnections = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
    }

    void FixedUpdate()
    {
        float moveHorizontal = hori;
        float moveVertical = verdi;

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
        }
    }

    public void OnConnectionEvent(bool boolkean)
    {
        if (boolkean)
        {
            successfulconnections++;
            Debug.Log(" connection player");
            Debug.Log(successfulconnections);
        }
        else
        {
            Debug.Log("no connection player");
            Debug.Log(successfulconnections);
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
            hori = 0;
            verdi = 0;
            return;
        }

        //if(Math.Abs(attention) < 8)
        //    return;

        hori = (float)attention / 100;
        verdi = (float)meditation / 100;

        Debug.Log(String.Format("Horizontal: {0} Vertical: {1}", hori, verdi));
    }
}
