using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Transform leftDoor;
    public Transform rightDoor;
    public Transform lTarget;
    public Transform rTarget;
    public float speed;
    private Vector3 lOriginal;
    private Vector3 rOriginal;

    // Start is called before the first frame update
    void Start()
    {
        
        do
        {
            lOriginal = leftDoor.position;
            rOriginal = rightDoor.position;
            
        } while (false);
            
        
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {

            leftDoor.position = Vector3.MoveTowards(leftDoor.position, lTarget.position, speed);
            rightDoor.position = Vector3.MoveTowards(rightDoor.position, rTarget.position, speed);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            leftDoor.position = Vector3.MoveTowards(leftDoor.position, lOriginal, speed);
            rightDoor.position = Vector3.MoveTowards(rightDoor.position, rOriginal, speed);
        }
    }
}
