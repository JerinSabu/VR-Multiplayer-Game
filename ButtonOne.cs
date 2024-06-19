using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOne : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == CommonData.buttonOneKey)
        {
            Debug.Log(CommonData.buttonOneKey);
            Debug.Log(other.tag);

            CommonData.buttonOne = true;
            Debug.Log(CommonData.buttonOne);
            CommonData.openSmall = true;
            Debug.Log(CommonData.buttonOne);
        }

        
    }

    private void OnTriggerExit(Collider other)
    {
        CommonData.buttonOne = false;
        CommonData.openSmall = false;
    }
}
