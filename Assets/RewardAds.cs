using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using System;
using UnityEngine.SceneManagement;

namespace Assets.SimpleAndroidNotifications
{
public class RewardAds : MonoBehaviour
{
    #if UNITY_ANDROID
      private string _adUnitId = "ca-app-pub-2893603532897895/4332361866";
    #elif UNITY_IPHONE
      private string _adUnitId = "";
    #else
      private string _adUnitId = "unused";
    #endif

    private RewardedAd rewardedAd;

    [Header("Coins Bonus")]
    public int MoneyIntBonus;
    
    [Header("Daily Bonus")]
    public int MoneyIntRewBonus;

    [Header("Fortune Bonus")]
    public FortuneSpin FortuneSpinScript;
    public int ads_int;

    [Header("Resume Bonus")]
    public int int_resume;
    public int MilesAnalitics;
    public int ResumeInt;
    public int intPos;

    [Header("Bubble Bonus")]
    public GameObject CanvasBubbleBonus;
    public BonusSafe BubbleScript;
    public int IntStartBubble;

    private void Start ()
    {
        LoadRewardedAd();

        // Dufualt resume
        int_resume = 0;
        PlayerPrefs.SetInt("int_resume",int_resume);
    }

    public void LoadRewardedAd()
    {
      // Clean up the old ad before loading a new one.
      if (rewardedAd != null)
      {
            rewardedAd.Destroy();
            rewardedAd = null;
      }

      Debug.Log("Loading the rewarded ad.");

      // create our request used to load the ad.
      var adRequest = new AdRequest.Builder().Build();

      // send the request to load the ad.
      RewardedAd.Load(_adUnitId, adRequest,
          (RewardedAd ad, LoadAdError error) =>
          {
              // if error is not null, the load request failed.
              if (error != null || ad == null)
              {
                  Debug.LogError("Rewarded ad failed to load an ad " +
                                 "with error : " + error);
                  return;
              }

              Debug.Log("Rewarded ad loaded with response : "
                        + ad.GetResponseInfo());

              rewardedAd = ad;
          });
    }

    public void Coins_Ads()
    {
    if (rewardedAd != null && rewardedAd.CanShowAd())
    {
        rewardedAd.Show((Reward reward_coins) =>
        { 
            MoneyIntBonus = 1;
            PlayerPrefs.SetInt("MoneyIntBonus",MoneyIntBonus);

            // Notification 
            NotificationManager.SendWithAppIcon(TimeSpan.FromSeconds(86400), "It's time to pick up the reward!", "Hurry up before he disappears", new Color(0, 0.6f, 1), NotificationIcon.Message);

            LoadRewardedAd();
        });
    }
    }

    public void Daily_Ads()
    {
    if (rewardedAd != null && rewardedAd.CanShowAd())
    {
        rewardedAd.Show((Reward reward_daily) =>
        {
            MoneyIntRewBonus = 1;
            PlayerPrefs.SetInt("MoneyIntRewBonus",MoneyIntRewBonus); 

            // Notification
            NotificationManager.SendWithAppIcon(TimeSpan.FromSeconds(86400), "It's time to pick up the bonus!", "Earn more coins", new Color(0, 0.6f, 1), NotificationIcon.Message);

            LoadRewardedAd();
        });
    }
    }

    public void Fortune_Ads()
    {
    if (rewardedAd != null && rewardedAd.CanShowAd())
    {
        rewardedAd.Show((Reward reward_fortune) =>
        { 
            FortuneSpinScript.AdsBonus();

            // Notification
            NotificationManager.SendWithAppIcon(TimeSpan.FromSeconds(28800), "You have the opportunity to try your luck again! ", " Play wheel of fortune!", new Color(0, 0.6f, 1), NotificationIcon.Message);

            LoadRewardedAd();
        });
    }
    }

    public void Resume_Ads()
    {
    if (rewardedAd != null && rewardedAd.CanShowAd())
    {
        rewardedAd.Show((Reward reward_resume) =>
        { 
            int_resume = 2;
            PlayerPrefs.SetInt("int_resume",int_resume);

            LoadRewardedAd();  
        });
    }
    }

    public void Bubble_Ads()
    {
    if (rewardedAd != null && rewardedAd.CanShowAd())
    {
        rewardedAd.Show((Reward reward_return) =>
        { 
            BubbleScript.ActivateBonus();
            CanvasBubbleBonus.SetActive(false);
            IntStartBubble = 1;
            PlayerPrefs.SetInt("IntStartBubble", IntStartBubble);

            LoadRewardedAd();
        });
    }
    }

    private void Update ()
    {  
        int_resume = PlayerPrefs.GetInt("int_resume");

        if (int_resume == 1)
        {
            Resume_Ads();
        }

        if (int_resume == 2)
        {
            MilesAnalitics = PlayerPrefs.GetInt("MilesAnalitics");
            intPos = PlayerPrefs.GetInt("intPos");
            
            MilesAnalitics -= intPos;
            ResumeInt = 1;
            int_resume = 0;
            PlayerPrefs.SetInt("ResumeInt",ResumeInt);
            PlayerPrefs.SetInt("int_resume",int_resume);
            PlayerPrefs.SetInt("MilesAnalitics",MilesAnalitics);
            SceneManager.LoadScene ("CSGGame");
        }
    }
}
}