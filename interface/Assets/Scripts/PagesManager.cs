using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PagesManager : MonoBehaviour
{

    public GameObject login, signUp, homePage, 
    settings, scanPage ,info, navBar, ArCamera;
    ////scorePage

    // Start is called before the first frame update
    void Start()
    {
        login.SetActive(true);
        signUp.SetActive(false);
        homePage.SetActive(false);
        //scorePage.SetActive(false);
        settings.SetActive(false);
        
        scanPage.SetActive(false);
        info.SetActive(false);
        navBar.SetActive(false);
    }

    public void goToHomePage()
    {
        
        login.SetActive(false);
        signUp.SetActive(false);
        homePage.SetActive(true);
        //scorePage.SetActive(false);
        settings.SetActive(false);
        
        scanPage.SetActive(false);
        info.SetActive(false);
        navBar.SetActive(true);
        
    }

    public void goToLogin()
    {
        login.SetActive(true);
        signUp.SetActive(false);
        homePage.SetActive(false);
        //scorePage.SetActive(false);
        settings.SetActive(false);
        
        scanPage.SetActive(false);
        info.SetActive(false);
        navBar.SetActive(false);
    }

    public void goToSignUp()
    {
        login.SetActive(false);
        signUp.SetActive(true);
        homePage.SetActive(false);
        //scorePage.SetActive(false);
        settings.SetActive(false);
        
        scanPage.SetActive(false);
        info.SetActive(false);
        navBar.SetActive(false);
    }

   /* public void goTo//scorePage()
    {
        login.SetActive(false);
        signUp.SetActive(false);
        homePage.SetActive(false);
        //scorePage.SetActive(true);
        settings.SetActive(false);
        
        scanPage.SetActive(false);
        info.SetActive(false);
        navBar.SetActive(true);
    }*/

    public void goToSettingsPage()
    {
        login.SetActive(false);
        signUp.SetActive(false);
        homePage.SetActive(false);
        //scorePage.SetActive(false);
        settings.SetActive(true);
        
        scanPage.SetActive(false);
        info.SetActive(false);
        navBar.SetActive(true);
    }

  

    public void goToscanPagePage()
    {
        login.SetActive(false);
        signUp.SetActive(false);
        homePage.SetActive(false);
        //scorePage.SetActive(false);
        settings.SetActive(false);
        scanPage.SetActive(true);
        ArCamera.SetActive(true);
        info.SetActive(false);
        navBar.SetActive(true);
    }

    public void goToInfoPage()
    {
        login.SetActive(false);
        signUp.SetActive(false);
        homePage.SetActive(false);
        //scorePage.SetActive(false);
        settings.SetActive(false);
        
        scanPage.SetActive(false);
        info.SetActive(true);
        navBar.SetActive(true);
    }

    
}
