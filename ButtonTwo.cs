using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTwo : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == CommonData.buttonTwoKey)
        {

            CommonData.buttonTwo = true;
            Debug.Log(CommonData.buttonTwo);

        }


    }

    private void OnTriggerExit(Collider other)
    {
        CommonData.buttonTwo = false;
    }
}
