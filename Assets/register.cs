using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class register : MonoBehaviour
{
    public InputField EmailInput, PasswordInput, UsernameInput;

    public void RegisterBtn()
    {
        var request = new RegisterPlayFabUserRequest { Email = EmailInput.text, Password = PasswordInput.text, Username = UsernameInput.text };
        PlayFabClientAPI.RegisterPlayFabUser(request, OnRegisterSuccess, OnRegisterFailure);
    }

    public void BackBtn()
    {
        SceneManager.LoadScene("login");
    }

    void OnRegisterSuccess(RegisterPlayFabUserResult result)
    {
        SceneManager.LoadScene("login");
        print("회원가입 성공");
    }

    void OnRegisterFailure(PlayFabError error) => print("회원가입 실패");
}
