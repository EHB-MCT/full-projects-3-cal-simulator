using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;

public class SpawnTrain : MonoBehaviour
{
    public GameObject ms08, eur320, type12, type07, serie15;
    
    private GameObject train;
    // Start is called before the first frame update

    public GameObject info, nav, arCamera, backBtn;

    private string nameOfTrain;
    void Start()
    {
        arCamera.SetActive(false);
        backBtn.SetActive(false);
    }

       
        
     public void SpawnMs08()
     {
          backBtn.SetActive(true);
          info.SetActive(false);
          nav.SetActive(false);
          arCamera.SetActive(true);
          Destroy(train);
          train = Instantiate(ms08, transform.position, transform.rotation);
          
          nameOfTrain = train.gameObject.name;
     } 
                
       public void SpawnEur320()
       {
            backBtn.SetActive(true);
          info.SetActive(false);
          nav.SetActive(false);
          arCamera.SetActive(true);
          Destroy(train);
          train = Instantiate(eur320, transform.position, transform.rotation);

          nameOfTrain = train.gameObject.name;
       }
                
       public void SpawnType12()
       {
            backBtn.SetActive(true);
          info.SetActive(false);
          nav.SetActive(false);
          arCamera.SetActive(true);
          Destroy(train);
          train = Instantiate(type12, transform.position, transform.rotation);

          nameOfTrain = train.gameObject.name;
       }
               
        public void SpawnType07()
       {
            backBtn.SetActive(true);
          info.SetActive(false);
          nav.SetActive(false);
          arCamera.SetActive(true);
          Destroy(train);
          train = Instantiate(type07, transform.position, transform.rotation);
          nameOfTrain = train.gameObject.name;

       }
                
        public void SpawnSerie15()
       {
            backBtn.SetActive(true);
          info.SetActive(false);
          nav.SetActive(false);
          arCamera.SetActive(true);
          Destroy(train);
          train = Instantiate(serie15, transform.position, transform.rotation);

          nameOfTrain = train.gameObject.name;
       }


       public void Back()
       {
          Destroy(train);
          backBtn.SetActive(false);
          info.SetActive(true);
          nav.SetActive(true);
          arCamera.SetActive(false);
       }
                
            

        
      
    

 

    
}
