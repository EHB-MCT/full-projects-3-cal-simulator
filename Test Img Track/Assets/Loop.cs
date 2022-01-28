using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    // Start is called before the first frame update

    public float loopSpeed;

    public bool loop;
    void Start()
    {
        loop = true;
    }

    // Update is called once per frame
    void Update()
    {

      if (Input.touchCount > 0)
        {
          //set loop to false
          loop = false;
          loopSpeed = 0;
          //start the coroutine
          StartCoroutine(CouroutineSetTrue());
        }

      if(loop)
      {

        loopSpeed += 0.7f; 

        transform.rotation = Quaternion.Euler(0,loopSpeed,0);

        if(loopSpeed == 360f)
        {
          loopSpeed = 0f;
        }
        

      }

        
    }


    IEnumerator CouroutineSetTrue()
    {
        //Wait 3 seconds before resuming the loop
        yield return new WaitForSeconds(3);

       loop = true;
    }
}
