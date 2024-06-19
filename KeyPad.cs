using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPad : MonoBehaviour
{
    public int[] keypadPass;
    int i = 0;
    private bool addValue = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void Update()
    {
        if (CommonData.keyPressed)
        {
            if (addValue)
            {
                keypadPass[i] = check();
                i++;
                addValue = false;
            }
        }
        else addValue = true;

        if (i == 2 && keypadPass != CommonData.password)
        {
            keypadPass[0] = 0;
            keypadPass[1] = 0;
            keypadPass[2] = 0;
            i = 0;
        }

        if (keypadPass == CommonData.password)  CommonData.keyPassUnlocked = true;


    }

    public int check()
    {
        if (CommonData.pressedKey == "KeyPad1") return 1;
        if (CommonData.pressedKey == "KeyPad2") return 2;
        else return 3;
    }
}
