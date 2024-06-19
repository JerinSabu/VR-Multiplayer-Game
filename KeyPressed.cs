using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPressed : MonoBehaviour
{
    private Vector3 target;
    private Vector3 original;
    private void Start()
    {
       
        do
        {
            original = transform.position;
            target = new Vector3(transform.position.x, transform.position.y - 18, transform.position.z);
            

        }while (false);
    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.tag == "Hands")
        {
            CommonData.keyPressed = true;
            CommonData.pressedKey = this.tag;
            Debug.Log(this.tag);
            transform.position = target;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Hands")
        {
            CommonData.keyPressed = false;
            transform.position = original;
        }
    }


}

