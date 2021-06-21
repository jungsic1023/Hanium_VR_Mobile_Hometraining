using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.SceneManagement;
using UnityEngine.VR;

public class PlayfabManager : MonoBehaviour
{
    public InputField EmailInput, PasswordInput, UsernameInput;



    public void LoginBtn()
    {
        var request = new LoginWithEmailAddressRequest { Email = EmailInput.text, Password = PasswordInput.text };
        PlayFabClientAPI.LoginWithEmailAddress(request, OnLoginSuccess, OnLoginFailure);
    }


    public void RegisterBtn()
    {
        var request = new RegisterPlayFabUserRequest { Email = EmailInput.text, Password = PasswordInput.text, Username = UsernameInput.text };
        PlayFabClientAPI.RegisterPlayFabUser(request, OnRegisterSuccess, OnRegisterFailure);
    }


   
    void OnLoginSuccess(LoginResult result)
    {
        print("로그인 성공");
      
        SceneManager.LoadScene("menu");

    }

    void OnLoginFailure(PlayFabError error)
    {
        print("로그인 실패");
    }

    void OnRegisterSuccess(RegisterPlayFabUserResult result)
    {
        print("회원가입 성공");
    }

    void OnRegisterFailure(PlayFabError error)
    {
        print("회원가입 실패");
    }

    IEnumerator VRSetting(string sdkName, bool flag)

    {

        XRSettings.LoadDeviceByName(sdkName);

        yield return null;

        XRSettings.enabled = flag;

    }



}