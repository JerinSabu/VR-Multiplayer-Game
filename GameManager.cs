using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject mainLaser;
    public GameObject secondartyLaser;
    public GameObject movingLaser;
    public GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleButton();
        if (CommonData.playerDied)
        {
            
            //game over
            gameOver.SetActive(true);
        }
        

        if (CommonData.keyPassUnlocked)
        {
            secondartyLaser.SetActive(false);
        }

        if (CommonData.diamondTouched)
        {

            //Player Won;
            CommonData.playerWon = true;
            gameOver.SetActive(true);
            
        }

        

    }


    public void HandleButton()
    {
        if (CommonData.buttonOne)
        {
            CommonData.openSmall = true;
            CommonData.lazer2Active = false;
            Debug.Log("laser false");
            movingLaser.SetActive(false);

        }
        else 
        {
            movingLaser.SetActive(true);
            CommonData.lazer2Active=true;
        }

        if (CommonData.buttonThree)
        {
            mainLaser.SetActive(false);
        }
        else if (!CommonData.buttonTwo) mainLaser.SetActive(true);


        if (CommonData.buttonTwo)
        {
            
            mainLaser.SetActive(false);
            CommonData.openFinalDoor = true;
            Debug.Log(CommonData.openFinalDoor);

            
        }
    }

    
    

}
