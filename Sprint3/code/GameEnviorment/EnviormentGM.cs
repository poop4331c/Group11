using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviormentGM : MonoBehaviour
{
    public static int crystalPowerUpTotal = 0;
    public static float timeTotal = 0.0f;

    public int makePathWhile = 7;
    public Transform noPit1;
    public Transform noPit2;
    public Transform noPit3;
    public Transform pitObst1;
    public Transform pitObst2;
    public Transform pitObst3;
    public Transform pinkCrystalPowerUp;
    public Transform greenCrysalPowerup;
    public Transform ghoast1;
    public Transform ghoast2;
    public Transform ghoast3;

    public int randomNum;
    public int randomPowerUp;
    public int randomGhoastGuy;

    // Start is called before the first frame update
    void Start()
    {
    
        
    }

    // Update is called once per frame
    void Update()
    {

        if (makePathWhile <300)
        {

            randomNum = Random.Range(0, 6);
            randomPowerUp = Random.Range(-1, 2);
            randomGhoastGuy = Random.Range(-1, 2);

            // place 1/3 no pit prefab
            if (randomNum == 0)
            {
                Instantiate(noPit1, new Vector3(0, 0, makePathWhile), noPit1.rotation);
                makePathWhile += 6;
            }

            // place 2/3 no pit prefab
            if (randomNum == 1)
            {
                Instantiate(noPit2, new Vector3(0, 0, makePathWhile), noPit2.rotation);
                makePathWhile += 6;
            }

            // place 3/3 no pit prefab
            if (randomNum == 2)
            {
                Instantiate(noPit3, new Vector3(0, 0, makePathWhile), noPit3.rotation);
                makePathWhile += 4;

            }

            // place 1/3 pit prefab
            if (randomNum == 3)
            {
                Instantiate(pitObst1, new Vector3(0, 0, makePathWhile), pitObst1.rotation);
                makePathWhile += 6;
            }

            // place 2/3 pit prefab
            if (randomNum == 4)
            {
                Instantiate(pitObst2, new Vector3(0, 0, makePathWhile), pitObst2.rotation);
                makePathWhile += 6;
            }

            // place 3/3 pit prefab
            if (randomNum == 5)
            {
                Instantiate(pitObst3, new Vector3(0, 0, makePathWhile), pitObst3.rotation);
                makePathWhile += 3;
            }


             // place a green power up crystal
             if (randomNum == 1)
             {
                 Instantiate(greenCrysalPowerup, new Vector3(randomPowerUp, 1, makePathWhile), greenCrysalPowerup.rotation);
                
             }

             // place a pink powerup crystal
             if (randomNum == 0)
             {
                 Instantiate(pinkCrystalPowerUp, new Vector3(randomPowerUp, 1, makePathWhile), pinkCrystalPowerUp.rotation);

             }
            
             // place 1/2 ghosts
             if (randomNum < 4  && (randomPowerUp  != randomGhoastGuy))
            {
                Instantiate(ghoast2, new Vector3(randomGhoastGuy, 1, makePathWhile), ghoast2.rotation);
            }
             
             // place the other ghost
            if (randomNum < 2  && (randomPowerUp != randomGhoastGuy))
            {
                Instantiate(ghoast1, new Vector3(randomGhoastGuy, 1, makePathWhile), ghoast1.rotation);
            }
        }
        
    }
}
