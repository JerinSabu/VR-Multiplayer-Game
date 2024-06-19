using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPad : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        CommonData.keyPassUnlocked = true;
    }
}
