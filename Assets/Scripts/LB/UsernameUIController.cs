using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine;
using PlayFab.DataModels;
using PlayFab.ProfilesModels;
using System.Collections.Generic;
using PlayFab.Json;

public class UsernameUIController : MonoBehaviour
{
    [SerializeField] TMP_InputField INF_Username;
    [SerializeField] Button BTN_Submit;
    [SerializeField] Animation AnimationError;
    [SerializeField] Animation AnimationNameTaken;
    public MenuNavigation NavigationScript;
    public string username;

    public List<string> m_ItemList = new List<string>();

    // Start is called before the first frame update
    private void Start()
    {
        if(Application.internetReachability == NetworkReachability.NotReachable){
        this.gameObject.SetActive(false);
        }
        else
        INF_Username.text = PlayerPrefs.GetString("USERNAME", "");    
    }

    public void Click_Submit()
    {
        BTN_Submit.enabled = false;
        username = INF_Username.text;

        if (username.Length > 2)
        PlayfabManager.Instance.LoginByUsername(username, (isSuccess) => 
        {
            if (isSuccess)
            {
                CheckOriginalNickname();
            }
            else
            {
                BTN_Submit.enabled = true;
                AnimationError.Play();
            }
        });

        if (username.Length <= 2)
        {
            BTN_Submit.enabled = true;
            AnimationError.Play();
        }
    }

    private void CheckOriginalNickname ()
    {
        PlayfabManager.Instance.GetMonthlyLeaderBoardData((data) =>
        {
        for(int i = 0; i < data.Count; i++)
        {
            string PlayersNickname = data[i].PlayerName;
            m_ItemList.Add(PlayersNickname);

            // Reject name if taken
            if (data[i].PlayerName == INF_Username.text)
            {
                BTN_Submit.enabled = true;
                PlayfabManager.IsLogined = false;
                AnimationNameTaken.Play();

                break;
            }

            // Accept name
            if (data.Count == i+1)
            {
                BTN_Submit.enabled = false;
                PlayfabManager.IsLogined = true;
                PlayerPrefs.SetString("USERNAME", username);

                NavigationScript.LeaderTextSystem();
                this.gameObject.SetActive(false);
            }
        }
        });
    }
}
