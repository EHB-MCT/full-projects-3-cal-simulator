using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

    public GameObject  GameFrontCamera, GameCockpitCamera, GameThirdPersonCamera; 

    private int counter;
    // Start is called before the first frame update
    void Start()
    {

        FindCameras();

        counter = 0;
        GameFrontCamera.SetActive(false);
        GameCockpitCamera.SetActive(false);
        GameThirdPersonCamera.SetActive(true);
        
       
    }

    void Update()
    {
        if(counter == 0)
        {
            StartGameThirdPersonCamera();
        }else if(counter == 1)
        {
            StartGameFrontCamera();
        }else if(counter == 2)
        {
            StartGameCockpitCamera();
        }
    }

    public void ChangeCounter()
    {
      counter += 1;

      if(counter > 2)
      {
          counter =0;
      }

    }

    public void FindCameras()
    {
        GameFrontCamera = GameObject.Find("FrontCamera");
        GameCockpitCamera = GameObject.Find("CockPitCamera");
        GameThirdPersonCamera = GameObject.Find("ThirdCam");
        
            
    }

    public void StartGameFrontCamera()
    {
        
        GameFrontCamera.SetActive(true);
        GameCockpitCamera.SetActive(false);
        GameThirdPersonCamera.SetActive(false);
    }

    public void StartGameCockpitCamera()
    {
        
        GameFrontCamera.SetActive(false);
        GameCockpitCamera.SetActive(true);
        GameThirdPersonCamera.SetActive(false);
    }

    public void StartGameThirdPersonCamera()
    {
      
        GameFrontCamera.SetActive(false);
        GameCockpitCamera.SetActive(false);
        GameThirdPersonCamera.SetActive(true);
    }

    public void StartMenuCamera()
    {
       
        GameFrontCamera.SetActive(false);
        GameCockpitCamera.SetActive(false);
        GameThirdPersonCamera.SetActive(true);
    }

   


}
