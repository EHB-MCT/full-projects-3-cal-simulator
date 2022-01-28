using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{

    public GameObject[] groups;
    // Start is called before the first frame update
    void Start()
    {
        
        groups[0].SetActive(true);
        groups[1].SetActive(false);
        groups[2].SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToGroup2()
    {

      groups[0].SetActive(false);
      groups[2].SetActive(false);
      groups[1].SetActive(true);
      
      
    }

    public void ToGroup3()
    {
      groups[0].SetActive(false);
      groups[1].SetActive(false);
      groups[2].SetActive(true);
    }


    public void Scan()
    {
        groups[0].SetActive(false);
        groups[1].SetActive(false);
        groups[2].SetActive(false);
    }
}
