using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonThree : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == CommonData.buttonTwoKey)
        {

            CommonData.buttonThree = true;

        }


    }

    private void OnTriggerExit(Collider other)
    {
        //CommonData.buttonThree = false;
    }
}
