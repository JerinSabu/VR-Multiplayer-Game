using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadLobby()
    {

        SceneManager.LoadScene(0);

    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
