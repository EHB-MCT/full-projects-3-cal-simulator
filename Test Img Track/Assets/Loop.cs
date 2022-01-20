using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    // Start is called before the first frame update

    public float loopSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        loopSpeed += 0.7f; 

        transform.rotation = Quaternion.Euler(0,loopSpeed,0);

        if(loopSpeed == 360f)
        {
          loopSpeed = 0f;
        }
        
    }
}
