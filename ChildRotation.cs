using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildRotation : MonoBehaviour
{
    
    public Vector3 offset;

    void Update()
    {
        Quaternion parentRotation = transform.parent.rotation;

        transform.rotation = Quaternion.Euler(0f, parentRotation.eulerAngles.y, 0f);
    }


}
