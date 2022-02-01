using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageSliderScript : MonoBehaviour
{

    public GameObject[] trainsInfo;

    public int counter;

    public Animator slideAnim;

 

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;

    }

    void Update()
    {
        if(counter == 5)
        {
            counter = 0;
        }

        if(counter < 0)
        {
            counter = 4;
        }
        trainsInfo[counter].SetActive(true);
    }

    public void RightClick()
    {
        slideAnim.SetTrigger("playAnim");
        trainsInfo[counter].SetActive(false);
        counter +=1; 
    }

    public void LeftClick()
    {
        trainsInfo[counter].SetActive(false);
        counter -=1;
    }
}
