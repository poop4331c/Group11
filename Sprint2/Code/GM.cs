using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{
    public static float verticalVelocity = 0;
    public static int totalPoints = 0;
    public static float totalTime = 0;
    public static float zVelocityAdjustment = 1;
    public static bool isGameOver = false;

    public float wait = 0;
    public float zPosition = 65;

    public Transform buildingBlockNoPit;
    public Transform buildingBlockMidPit;
    public Transform coinObj;
    public Transform powerUPObj;

    public int randNumber;
    public int randomPUPlacement;
    public int randomCoinPlacement;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(buildingBlockNoPit, new Vector3(0, 2.25f, 49), buildingBlockNoPit.rotation);
        Instantiate(buildingBlockNoPit, new Vector3(0, 2.25f, 53), buildingBlockNoPit.rotation);
        Instantiate(buildingBlockMidPit, new Vector3(0, 2.25f, 57), buildingBlockMidPit.rotation);
        Instantiate(buildingBlockMidPit, new Vector3(0, 2.25f, 61), buildingBlockMidPit.rotation); 
    }


    // Update is called once per frame
    void Update()
    {
        if (zPosition < 1200)
        {
            randNumber = Random.Range(0, 10);
            randomPUPlacement = Random.Range(-1, 2);
            randomCoinPlacement = Random.Range(-1, 2);
            
            if (randNumber == 3)
            {
                Instantiate(coinObj, new Vector3(randomCoinPlacement, 3.17f, zPosition), coinObj.rotation);
            }

            if (randNumber == 4 && (randomPUPlacement == randomCoinPlacement))
            {

                Instantiate(powerUPObj, new Vector3(randomPUPlacement, 3.17f, zPosition), powerUPObj.rotation);

            }

            if (randNumber == 3)
            {
                Instantiate(buildingBlockNoPit, new Vector3(0, 2.25f, zPosition), buildingBlockNoPit.rotation);
                zPosition += 4;
            }


            if (randNumber == 8)
            {
                Instantiate(buildingBlockMidPit, new Vector3(0, 2.25f, zPosition), buildingBlockMidPit.rotation);
                zPosition += 4;
            }
          
        }

        totalTime  += Time.deltaTime;

        if (isGameOver)
        {
            wait += Time.deltaTime;
        }

        if (wait > 1)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
