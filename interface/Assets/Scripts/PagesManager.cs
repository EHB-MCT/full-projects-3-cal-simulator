using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PagesManager : MonoBehaviour
{

    public GameObject login, signUp, homePage, scorePage, 
    settings, editProfile, editPassword ,info, navBar;


    // Start is called before the first frame update
    void Start()
    {
        login.SetActive(true);
        signUp.SetActive(false);
        homePage.SetActive(false);
        scorePage.SetActive(false);
        settings.SetActive(false);
        editProfile.SetActive(false);
        editPassword.SetActive(false);
        info.SetActive(false);
        navBar.SetActive(false);
    }

    public void goToHomePage()
    {
        
        login.SetActive(false);
        signUp.SetActive(false);
        homePage.SetActive(true);
        scorePage.SetActive(false);
        settings.SetActive(false);
        editProfile.SetActive(false);
        editPassword.SetActive(false);
        info.SetActive(false);
        navBar.SetActive(false);
        
    }

    public void goToLogin()
    {
        login.SetActive(true);
        signUp.SetActive(false);
        homePage.SetActive(false);
        scorePage.SetActive(false);
        settings.SetActive(false);
        editProfile.SetActive(false);
        editPassword.SetActive(false);
        info.SetActive(false);
        navBar.SetActive(false);
    }

    public void goToSignUp()
    {
        login.SetActive(false);
        signUp.SetActive(true);
        homePage.SetActive(false);
        scorePage.SetActive(false);
        settings.SetActive(false);
        editProfile.SetActive(false);
        editPassword.SetActive(false);
        info.SetActive(false);
        navBar.SetActive(false);
    }

    public void goToScorePage()
    {
        login.SetActive(false);
        signUp.SetActive(false);
        homePage.SetActive(false);
        scorePage.SetActive(true);
        settings.SetActive(false);
        editProfile.SetActive(false);
        editPassword.SetActive(false);
        info.SetActive(false);
        navBar.SetActive(true);
    }

    public void goToSettingsPage()
    {
        login.SetActive(false);
        signUp.SetActive(false);
        homePage.SetActive(false);
        scorePage.SetActive(false);
        settings.SetActive(true);
        editProfile.SetActive(false);
        editPassword.SetActive(false);
        info.SetActive(false);
        navBar.SetActive(true);
    }

    public void goToEditProfilePage()
    {
        login.SetActive(false);
        signUp.SetActive(false);
        homePage.SetActive(false);
        scorePage.SetActive(false);
        settings.SetActive(false);
        editProfile.SetActive(true);
        editPassword.SetActive(false);
        info.SetActive(false);
        navBar.SetActive(true);
    }

    public void goToEditPasswordPage()
    {
        login.SetActive(false);
        signUp.SetActive(false);
        homePage.SetActive(false);
        scorePage.SetActive(false);
        settings.SetActive(false);
        editProfile.SetActive(false);
        editPassword.SetActive(true);
        info.SetActive(false);
        navBar.SetActive(true);
    }

    public void goToInfoPage()
    {
        login.SetActive(false);
        signUp.SetActive(false);
        homePage.SetActive(false);
        scorePage.SetActive(false);
        settings.SetActive(false);
        editProfile.SetActive(false);
        editPassword.SetActive(false);
        info.SetActive(true);
        navBar.SetActive(true);
    }

    
}
