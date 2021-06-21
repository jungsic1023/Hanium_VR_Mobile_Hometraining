using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class llo : MonoBehaviour
{
 
    
  
  
    public InputField EmailInput, PasswordInput;

    void Start()
    {
        GetComponent<StopVR>();
      
    }
    public void LoginBtn()
    {
        var request = new LoginWithEmailAddressRequest { Email = EmailInput.text, Password = PasswordInput.text };
        PlayFabClientAPI.LoginWithEmailAddress(request, OnLoginSuccess, OnLoginFailure);
    }


    public void RegisterBtn()
    {
        SceneManager.LoadScene("register");
       
     
      
    }


    //void OnLoginSuccess(LoginResult result) => SceneManager.LoadScene("menu");
    void OnLoginSuccess(LoginResult result)
    {
        SceneManager.LoadScene("menu");
        print("로그인 성공");
      
    }

    void OnLoginFailure(PlayFabError error) => print("로그인 실패");
    

}
