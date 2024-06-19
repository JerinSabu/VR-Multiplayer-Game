using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallDoor : MonoBehaviour
{
    public Transform target;
    Vector3 original;
    // Start is called before the first frame update
    void Start()
    {
        do
        {
            original = transform.position;
            
        }while(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (CommonData.openSmall)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, 0.25f);
        }
        else transform.position = Vector3.MoveTowards(transform.position, original, 0.5f);

    }
}
