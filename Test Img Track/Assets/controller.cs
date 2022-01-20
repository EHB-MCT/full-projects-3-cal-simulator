using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }


    public void Squat(){

       anim.SetTrigger("squat");

    }

    public void PushUp(){

       anim.SetTrigger("push");

    }

    public void Idle(){

       anim.SetTrigger("idle");

    }


  


   
}
