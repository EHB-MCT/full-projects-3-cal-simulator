using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

    public GameObject MenuCamera, GameFrontCamera, GameSideCamera, GameThirdPersonCamera; 
    // Start is called before the first frame update
    void Start()
    {
        MenuCamera.SetActive(true);
        GameFrontCamera.SetActive(false);
        GameSideCamera.SetActive(false);
        GameThirdPersonCamera.SetActive(false);
        
       
    }

    public void StartGameFrontCamera()
    {
        MenuCamera.SetActive(false);
        GameFrontCamera.SetActive(true);
        GameSideCamera.SetActive(false);
        GameThirdPersonCamera.SetActive(false);
    }

    public void StartGameSideCamera()
    {
        MenuCamera.SetActive(false);
        GameFrontCamera.SetActive(false);
        GameSideCamera.SetActive(true);
        GameThirdPersonCamera.SetActive(false);
    }

    public void StartGameThirdPersonCamera()
    {
        MenuCamera.SetActive(false);
        GameFrontCamera.SetActive(false);
        GameSideCamera.SetActive(false);
        GameThirdPersonCamera.SetActive(true);
    }

    public void StartMenuCamera()
    {
        MenuCamera.SetActive(true);
        GameFrontCamera.SetActive(false);
        GameSideCamera.SetActive(false);
        GameThirdPersonCamera.SetActive(false);
    }

   


}
