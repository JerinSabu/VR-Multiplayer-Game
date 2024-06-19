using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamonTouched : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        CommonData.diamondTouched = true;
        
        
    }
}
