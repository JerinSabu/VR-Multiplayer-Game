using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI gameOver;


    // Update is called once per frame
    void Update()
    {
        do
        {
            if (CommonData.playerWon) gameOver.text = "You Won";
            else gameOver.text = "You Lost";
            //ResetGame();

        } while (false);

    }

    public void ResetGame()
    {
        CommonData.playerDied = false;
        CommonData.lazer2Active = true;
        CommonData.buttonOne = false;
        CommonData.buttonTwo = false;
        CommonData.buttonThree = false;
        CommonData.openFinalDoor = false;
        CommonData.diamondTouched = false;
        CommonData.openSmall = false;
        CommonData.playerWon = false;
        CommonData.keyPressed = false;
        CommonData.keyPassUnlocked = false;


    }

}
