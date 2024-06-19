using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerMovement : MonoBehaviour
{
    public Transform top;
    public Transform bottom;
    public float lazerSpeed;
    public bool on;
    private bool toTop = true;
    

    // Start is called before the first frame update
    void Awake()
    {
        on = CommonData.lazer2Active;
    }

    // Update is called once per frame
    void Update()
    {

        if (on)
        {
            if (toTop)
            {
                transform.position = Vector3.MoveTowards(transform.position, top.position, lazerSpeed);
                if(transform.position == top.position) toTop = false;
            }

            else
            {
                transform.position = Vector3.MoveTowards(transform.position, bottom.position, lazerSpeed);
                if (transform.position == bottom.position) toTop = true;
            }

        }
        
    }
}
