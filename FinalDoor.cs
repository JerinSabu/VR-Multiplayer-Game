using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDoor : MonoBehaviour
{
    public Transform leftDoor;
    public Transform rightDoor;
    public Transform lTarget;
    public Transform rTarget;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CommonData.openFinalDoor)
        {
            leftDoor.position = Vector3.MoveTowards(leftDoor.position, lTarget.position, 0.25f);
            rightDoor.position = Vector3.MoveTowards(rightDoor.position, rTarget.position, 0.25f);
        }
    }
}
