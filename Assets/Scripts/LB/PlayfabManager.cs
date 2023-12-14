using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;

public class PlayfabManager : MonoBehaviour
{
    public static bool IsLogined = false;
    public static PlayfabManager Instance;
	private void Awake()
	{
        if(Application.internetReachability == NetworkReachability.NotReachable)
        {

        }

        else 
        
		if(Instance == null)
		{
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
		}
		else
		{
            DestroyImmediate(this.gameObject);
		}
	}

	#region LOGIN

    public void RegisterByEmail(string email, string password, string displayName, System.Action<bool, string, string> onResultCallback)
    {
        var request = new RegisterPlayFabUserRequest { Email = email, Password = password, DisplayName = displayName, Username = displayName };
        PlayFabClientAPI.RegisterPlayFabUser(request, 
            (registerResult) => {
                string id = registerResult.PlayFabId;
                onResultCallback?.Invoke(true, id, displayName);
            }, 
            (error) => {
                onResultCallback?.Invoke(false, null, null);
                Debug.Log(error.ErrorMessage);
            });
    }

    public void LoginByEmail(string email, string password, System.Action<bool, string, string> onResultCallback)
	{
        var request = new LoginWithEmailAddressRequest { Email = email, Password = password };
        request.InfoRequestParameters = new GetPlayerCombinedInfoRequestParams { GetPlayerProfile = true };

        PlayFabClientAPI.LoginWithEmailAddress(request,
            (loginResult) => {
                string displayName = null;
                string id = loginResult.PlayFabId;
                if(loginResult.InfoResultPayload.PlayerProfile != null)
				{
                    displayName = loginResult.InfoResultPayload.PlayerProfile.DisplayName;
                }
                onResultCallback?.Invoke(true, id, displayName);
            },
            (error) => {
                onResultCallback?.Invoke(false, null, null);
                Debug.Log(error.ErrorMessage);
            });
    }

	public void LoginByUsername(string userName, System.Action<bool> onResultCallback)
    {
        var request = new LoginWithCustomIDRequest { CustomId = userName, CreateAccount = true};
        request.InfoRequestParameters = new GetPlayerCombinedInfoRequestParams { GetPlayerProfile = true};
        PlayFabClientAPI.LoginWithCustomID(request,
            (loginResult)=> {
                string id = loginResult.PlayFabId;
                if (loginResult.InfoResultPayload.PlayerProfile == null || loginResult.InfoResultPayload.PlayerProfile.DisplayName != userName)
                {
                    SetDisplayName(userName, null);
                }
                onResultCallback?.Invoke(true);
            }, 
            (error)=> { 
                onResultCallback?.Invoke(false);
                Debug.Log(error.ErrorMessage);
            });
    }

    public void SetDisplayName(string displayName, System.Action<bool> onResultCallback)
    {
        var request = new UpdateUserTitleDisplayNameRequest { DisplayName = displayName };
        PlayFabClientAPI.UpdateUserTitleDisplayName(request, 
            (result)=> {
                onResultCallback?.Invoke(true);
            }, 
            (error)=> { 
                Debug.Log(error.ErrorMessage);
                onResultCallback?.Invoke(false);
            });
    }

    #endregion

    #region LB

    public void SendScore(int score)
	{
        Debug.Log("~~~LB SCORE: " + score);
        SendScoreToLeaderboard("MonthlyLeaderboard", score);
	}

    private void SendScoreToLeaderboard(string statisticName, int score, System.Action<bool> OnCallBack = null)
    {
        var request = new UpdatePlayerStatisticsRequest();
        request.Statistics = new List<StatisticUpdate> { new StatisticUpdate { StatisticName = statisticName, Value = score } };

        PlayFabClientAPI.UpdatePlayerStatistics(request,
        (result) => {
            OnCallBack?.Invoke(true);
        },
        (error) => {
            OnCallBack?.Invoke(false);
            Debug.Log(error.ErrorMessage);
        });
    }

    public void GetDailyLeaderBoardData(System.Action<List<LBEntry>> onResultCallback)
    {
        GetLeaderboardList("DailyLeaderboard", onResultCallback);
    }

    public void GetWeeklyLeaderBoardData(System.Action<List<LBEntry>> onResultCallback)
    {
        GetLeaderboardList("WeeklyLeaderboard", onResultCallback);
    }

    public void GetMonthlyLeaderBoardData(System.Action<List<LBEntry>> onResultCallback)
    {
        GetLeaderboardList("MonthlyLeaderboard", onResultCallback);
    }

    private void GetLeaderboardList(string statisticName, System.Action<List<LBEntry>> onResultCallback)
    {
        Debug.Log("~~~LB LIST: " + statisticName);
        var request = new GetLeaderboardRequest { StatisticName = statisticName, StartPosition = 0, MaxResultsCount = 10 };
        PlayFabClientAPI.GetLeaderboard(request, 
            (result) => {
                List<LBEntry> list = GetLBList(result.Leaderboard);
                onResultCallback?.Invoke(list);
            },
            (error) => {
                onResultCallback?.Invoke(null);
                Debug.Log(error.ErrorMessage);
            });
    }

    public void GetLeaderboardAroundPlayer(string statisticName, System.Action<List<LBEntry>> onResultCallback)
    {
        var request = new GetLeaderboardAroundPlayerRequest { StatisticName = statisticName, MaxResultsCount = 10 };
        PlayFabClientAPI.GetLeaderboardAroundPlayer(request,
            (result) => {
                List<LBEntry> list = GetLBList(result.Leaderboard);
                onResultCallback?.Invoke(list);
            },
            (error) => {
                onResultCallback?.Invoke(null);
                Debug.Log(error.ErrorMessage);
            });
    }

    private List<LBEntry> GetLBList(List<PlayerLeaderboardEntry> list)
	{
        List<LBEntry> result = new List<LBEntry>();
            
        if(list == null || list.Count == 0)
		{
            return result;
		}

        for(int i = 0; i < list.Count; i++)
		{
            LBEntry entry = new LBEntry();
            entry.Rank = list[i].Position;
            entry.PlayerName = list[i].DisplayName;
            entry.Value = list[i].StatValue;
            entry.PlayerId = list[i].PlayFabId;
            if(entry.Value == 0)
			{
                continue;
			}
            result.Add(entry);
		}

        return result;
	}

	#endregion
}

[System.Serializable]
public class LBEntry
{
    public int Rank;
    public string PlayerName;
    public int Value;
    public string PlayerId;
}