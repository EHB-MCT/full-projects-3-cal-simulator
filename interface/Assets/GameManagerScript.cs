using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManagerScript : MonoBehaviour
{
    public GameObject MenuNoTrainPage, MenuMs08, MenuEur320, MenuType12, MenuType07, MenuSerie15;

    private void Start()
    {
        if(StateNameController.trainName == "notrain")
        {
            StartMenuNoTrain();
        }else if(StateNameController.trainName == "ms08")
        {
            StartMenuMs08();
        }else if (StateNameController.trainName == "eur320")
        {
            StartMenuEur320();
        }else if(StateNameController.trainName == "type12")
        {
            StartMenuType12();
        }else if (StateNameController.trainName == "type07")
        {
            StartMenuType07();
        }else if(StateNameController.trainName == "serie15")
        {
            StartMenuSerie15();
        }else
        {
             StartMenuNoTrain();
        }
        
    }
    public void GoTOHomePage()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void StartMenuMs08()
    {
        MenuNoTrainPage.SetActive(false);
        MenuSerie15.SetActive(false);
        MenuType07.SetActive(false);
        MenuType12.SetActive(false);
        MenuEur320.SetActive(false);
        MenuMs08.SetActive(true);

     
    }

    public void StartMenuNoTrain()
    {
        MenuNoTrainPage.SetActive(true);
        MenuSerie15.SetActive(false);
        MenuType07.SetActive(false);
        MenuType12.SetActive(false);
        MenuEur320.SetActive(false);
        MenuMs08.SetActive(false);

    }

    public void StartMenuEur320()
    {
        MenuNoTrainPage.SetActive(false);
        MenuSerie15.SetActive(false);
        MenuType07.SetActive(false);
        MenuType12.SetActive(false);
        MenuEur320.SetActive(true);
        MenuMs08.SetActive(false);

    }

    public void StartMenuType12()
    {
        MenuNoTrainPage.SetActive(false);
        MenuSerie15.SetActive(false);
        MenuType07.SetActive(false);
        MenuType12.SetActive(true);
        MenuEur320.SetActive(false);
        MenuMs08.SetActive(false);

   
    }

    public void StartMenuType07()
    {
        MenuNoTrainPage.SetActive(false);
        MenuSerie15.SetActive(false);
        MenuType07.SetActive(true);
        MenuType12.SetActive(false);
        MenuEur320.SetActive(false);
        MenuMs08.SetActive(false);

    
    }

    public void StartMenuSerie15()
    {
        MenuNoTrainPage.SetActive(false);
        MenuSerie15.SetActive(true);
        MenuType07.SetActive(false);
        MenuType12.SetActive(false);
        MenuEur320.SetActive(false);
        MenuMs08.SetActive(false);

   
    }
}
