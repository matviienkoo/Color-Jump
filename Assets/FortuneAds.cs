using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;

namespace Assets.SimpleAndroidNotifications
{
public class FortuneAds : MonoBehaviour
{
    #if UNITY_ANDROID
      private string _adUnitId = "ca-app-pub-2893603532897895/9525764906";
    #elif UNITY_IPHONE
      private string _adUnitId = "";
    #else
      private string _adUnitId = "unused";
    #endif

    private RewardedAd rewardedAd;

    public FortuneSpin FortuneSpinScript;
    private int Fortune_Ads_Int;

    private void Start ()
    {
        LoadRewardedAd();
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

    public void ShowRewardedAd()
    {
    if (rewardedAd != null && rewardedAd.CanShowAd())
    {
        rewardedAd.Show((Reward reward) =>
        { 
            Fortune_Ads_Int = 1;
            PlayerPrefs.SetInt("Fortune_Ads_Int",Fortune_Ads_Int);

            FortuneSpinScript.AdsFortune();
        });
    }
    }
}
}