 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{

    public GameObject loadScreen, load;
    
    public void StartGame(string trainName)
    {
          StateNameController.trainName = trainName;
          SceneManager.LoadScene("GameScene");
    }

    
}
