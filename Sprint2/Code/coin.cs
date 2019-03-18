using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
 
       transform.Rotate(0, 0, 3);
     
    }

    // outlines what happens with diffent collisions
    void OnCollisionEnter(Collision other)
    {
        // if we have it a game object with the lethal tag game over
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            
        }
    }
}
