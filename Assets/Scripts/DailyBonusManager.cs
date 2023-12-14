using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;
using TMPro;

namespace Assets.SimpleAndroidNotifications
{
public class DailyBonusManager : MonoBehaviour
{
        public int CoinCollect_int;
        public TextMeshProUGUI Time;
        public RewardAds AdsManager;

        public float msToWait;
        public Button TestButton;
        private ulong lastTimeClicked;

        public int Gold;
        public int Gold_Analitics;

        public GameObject Collect_Object;
        public GameObject Timer_Object;

        public int NoAds;
        public int MoneyIntRewBonus;
     
        private void Start()
        {
            if(PlayerPrefs.HasKey("LastTimeBonus")){
            lastTimeClicked = ulong.Parse(PlayerPrefs.GetString("LastTimeBonus"));
            }else{
                lastTimeClicked = (ulong)DateTime.Now.Ticks;
                PlayerPrefs.SetString("LastTimeClicked", lastTimeClicked.ToString());
            }

            if (!Ready())
                TestButton.interactable = false;
        }
     
        private void Update()
        {   
            Gold = PlayerPrefs.GetInt("Gold");
            Gold_Analitics = PlayerPrefs.GetInt("Gold_Analitics");
            MoneyIntRewBonus = PlayerPrefs.GetInt("MoneyIntRewBonus");
            CoinCollect_int = PlayerPrefs.GetInt("CoinCollect_int");

            if (MoneyIntRewBonus == 1)
            {
                MoneyBonusSystem();
                MoneyIntRewBonus = 0;
                PlayerPrefs.SetInt("MoneyIntRewBonus",MoneyIntRewBonus);
            }

            if (CoinCollect_int == 0)
            {
                Collect_Object.SetActive(true); 
                Timer_Object.SetActive(false); 
            }

            if (CoinCollect_int == 1)
            {
                Collect_Object.SetActive(false); 
                Timer_Object.SetActive(true); 
            }

            if (!TestButton.IsInteractable())
            {
                if (Ready())
                {
                    Time.text = "Ready!";
                    return;
                }
                ulong diff = ((ulong)DateTime.Now.Ticks - lastTimeClicked);
                ulong m = diff / TimeSpan.TicksPerMillisecond;
                float secondsLeft = (float)(msToWait - m) / 1000.0f;
     
                string r = "";
                //HOURS
                r += ((int)secondsLeft / 3600).ToString() + ":";
                secondsLeft -= ((int)secondsLeft / 3600) * 3600;
                //MINUTES
                r += ((int)secondsLeft / 60).ToString("00") + ":";
                //SECONDS
                r += (secondsLeft % 60).ToString("00");
                Time.text = r;
            }
        }
     
        public void Click()
        {     
                NoAds = PlayerPrefs.GetInt("NoAds");  

                //Disable ads not purchased
                if (NoAds == 0)
                {
                    AdsManager.Daily_Ads();
                }

                //Disable ads purchased
                if (NoAds == 1)
                {
                    Gold += 300;
                    Gold_Analitics += 300;
                    CoinCollect_int = 1;
                    PlayerPrefs.SetInt("Gold",Gold);
                    PlayerPrefs.SetInt("Gold_Analitics",Gold_Analitics);
                    PlayerPrefs.SetInt("CoinCollect_int",CoinCollect_int);
                }

                lastTimeClicked = (ulong)DateTime.Now.Ticks;
                PlayerPrefs.SetString("LastTimeBonus", lastTimeClicked.ToString());
                TestButton.interactable = false;
        }

        private bool Ready()
        {
            ulong diff = ((ulong)DateTime.Now.Ticks - lastTimeClicked);
            ulong m = diff / TimeSpan.TicksPerMillisecond;
     
            float secondsLeft = (float)(msToWait - m) / 1000.0f;
            
            // The timer ran out
            if (secondsLeft < 0)
            {
                CoinCollect_int = 0;
                PlayerPrefs.SetInt("CoinCollect_int",CoinCollect_int);

                return true;
            }
     
            return false;
        }

        private void MoneyBonusSystem()
        {
            Gold += 300;
            Gold_Analitics += 300;
            CoinCollect_int = 1;
            PlayerPrefs.SetInt("Gold",Gold);
            PlayerPrefs.SetInt("Gold_Analitics",Gold_Analitics);
            PlayerPrefs.SetInt("CoinCollect_int",CoinCollect_int);
        }
}
}