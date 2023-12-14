using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;
using TMPro;

namespace Assets.SimpleAndroidNotifications
{
public class DailyRewardsManager : MonoBehaviour
{
        public int WorkTimer;
        public int Days;
        public TextMeshProUGUI Time;
        public RewardAds AdsManager;

        public int Gold;
        public int Gold_Analitics;
        public int Gems;
        public int GemsAnalitics;

        public float msToWait;
        public Button TestButton;
        private ulong lastTimeClicked;

        public GameObject Collect_Objetc;
        public GameObject Timer_Object;
        public GameObject Congratulation_Object;

        public GameObject Day_First_Check;
        public GameObject Day_Second_Check;
        public GameObject Day_Thirt_Check;
        public GameObject Day_Four_Check;
        public GameObject Day_Five_Check;
        public GameObject Day_Six_Check;
        public GameObject Day_Seven_Check;

        public int MoneyIntBonus;
        public int ads_work;
        public int NoAds;
     
        private void Start()
        {
            Days = PlayerPrefs.GetInt("Days");
            WorkTimer = PlayerPrefs.GetInt("WorkTimer");

            if(PlayerPrefs.HasKey("LastTimeClicked")){
            lastTimeClicked = ulong.Parse(PlayerPrefs.GetString("LastTimeClicked"));
            }else{
                lastTimeClicked = (ulong)DateTime.Now.Ticks;
                PlayerPrefs.SetString("LastTimeClicked", lastTimeClicked.ToString());
            }

            if (!Ready())
                TestButton.interactable = false;
        }
     
        private void Update()
        {  
            Gold_Analitics = PlayerPrefs.GetInt("Gold_Analitics"); 
            GemsAnalitics = PlayerPrefs.GetInt("GemsAnalitics"); 
            WorkTimer = PlayerPrefs.GetInt("WorkTimer");
            MoneyIntBonus = PlayerPrefs.GetInt("MoneyIntBonus");
            Days = PlayerPrefs.GetInt("Days");
            Gems = PlayerPrefs.GetInt("Gems");
            Gold = PlayerPrefs.GetInt("Gold");

            // reward bonus (ads works)
            if (MoneyIntBonus == 1)
            {
                MoneyBonus();
                MoneyIntBonus = 0;
                PlayerPrefs.SetInt("MoneyIntBonus",MoneyIntBonus);
            }

            // Collect, Timer System
            if (WorkTimer == 0)
            {
                Collect_Objetc.SetActive(true);
                Timer_Object.SetActive(false); 
                Congratulation_Object.SetActive(false); 
            }
            if (WorkTimer == 1)
            {
                Collect_Objetc.SetActive(false);
                Timer_Object.SetActive(true); 
                Congratulation_Object.SetActive(false); 
            }
            if (WorkTimer == 2)
            {
                Collect_Objetc.SetActive(false);
                Timer_Object.SetActive(false); 
                Congratulation_Object.SetActive(true); 
            }

            // Days System
            if (Days == 0){
            Day_First_Check.SetActive(false); 
            Day_Second_Check.SetActive(false); 
            Day_Thirt_Check.SetActive(false); 
            Day_Four_Check.SetActive(false); 
            Day_Five_Check.SetActive(false); 
            Day_Six_Check.SetActive(false); 
            Day_Seven_Check.SetActive(false); 
            }

            if (Days == 1){
            Day_First_Check.SetActive(true); 
            Day_Second_Check.SetActive(false); 
            Day_Thirt_Check.SetActive(false); 
            Day_Four_Check.SetActive(false); 
            Day_Five_Check.SetActive(false); 
            Day_Six_Check.SetActive(false); 
            Day_Seven_Check.SetActive(false); 
            }

            if (Days == 2){
            Day_First_Check.SetActive(true); 
            Day_Second_Check.SetActive(true); 
            Day_Thirt_Check.SetActive(false); 
            Day_Four_Check.SetActive(false); 
            Day_Five_Check.SetActive(false); 
            Day_Six_Check.SetActive(false); 
            Day_Seven_Check.SetActive(false); 
            }

            if (Days == 3){
            Day_First_Check.SetActive(true); 
            Day_Second_Check.SetActive(true); 
            Day_Thirt_Check.SetActive(true); 
            Day_Four_Check.SetActive(false); 
            Day_Five_Check.SetActive(false); 
            Day_Six_Check.SetActive(false); 
            Day_Seven_Check.SetActive(false); 
            }

            if (Days == 4){
            Day_First_Check.SetActive(true); 
            Day_Second_Check.SetActive(true); 
            Day_Thirt_Check.SetActive(true); 
            Day_Four_Check.SetActive(true); 
            Day_Five_Check.SetActive(false); 
            Day_Six_Check.SetActive(false); 
            Day_Seven_Check.SetActive(false); 
            }

            if (Days == 5){
            Day_First_Check.SetActive(true); 
            Day_Second_Check.SetActive(true); 
            Day_Thirt_Check.SetActive(true); 
            Day_Four_Check.SetActive(true); 
            Day_Five_Check.SetActive(true); 
            Day_Six_Check.SetActive(false); 
            Day_Seven_Check.SetActive(false); 
            }

            if (Days == 6){
            Day_First_Check.SetActive(true); 
            Day_Second_Check.SetActive(true); 
            Day_Thirt_Check.SetActive(true); 
            Day_Four_Check.SetActive(true); 
            Day_Five_Check.SetActive(true); 
            Day_Six_Check.SetActive(true); 
            Day_Seven_Check.SetActive(false); 
            }

            if (Days == 7){
            Day_First_Check.SetActive(true); 
            Day_Second_Check.SetActive(true); 
            Day_Thirt_Check.SetActive(true); 
            Day_Four_Check.SetActive(true); 
            Day_Five_Check.SetActive(true); 
            Day_Six_Check.SetActive(true); 
            Day_Seven_Check.SetActive(true);

            WorkTimer = 2;
            PlayerPrefs.SetInt("WorkTimer",WorkTimer);
            Congratulation_Object.SetActive(true);
            Timer_Object.SetActive(false);
            Collect_Objetc.SetActive(false);
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
                    AdsManager.Coins_Ads();
                }
                
                //Disable ads purchased
                if (NoAds == 1)
                {
                    Days += 1;
                    WorkTimer = 1;

                    if (Days == 1)
                    {
                        Gold += 50;
                        Gold_Analitics += 50;
                    }
                    if (Days == 2)
                    {
                        Gold += 75;
                        Gold_Analitics += 75;
                    }
                    if (Days == 3)
                    {
                        Gold += 100;
                        Gold_Analitics += 100;
                    }
                    if (Days == 4)
                    {
                        Gold += 125;
                        Gold_Analitics += 125;
                    }
                    if (Days == 5)
                    {
                        Gold += 150;
                        Gold_Analitics += 150;
                    }
                    if (Days == 6)
                    {
                        Gold += 200;
                        Gold_Analitics += 200;
                    }
                    if (Days == 7)
                    {
                        Gold += 300;
                        Gold_Analitics += 300;
                        Gems += 1;
                        GemsAnalitics += 1;
                    }

                    PlayerPrefs.SetInt("Days",Days);
                    PlayerPrefs.SetInt("WorkTimer",WorkTimer);
                    PlayerPrefs.SetInt("Gold",Gold);
                    PlayerPrefs.SetInt("Gems",Gems);
                    PlayerPrefs.SetInt("GemsAnalitics",GemsAnalitics);
                    PlayerPrefs.SetInt("Gold_Analitics",Gold_Analitics);
                }    

                lastTimeClicked = (ulong)DateTime.Now.Ticks;
                PlayerPrefs.SetString("LastTimeClicked", lastTimeClicked.ToString());
                TestButton.interactable = false;

                PlayerPrefs.DeleteKey("LastTimeCheck");
        }
        private bool Ready()
        {
            ulong diff = ((ulong)DateTime.Now.Ticks - lastTimeClicked);
            ulong m = diff / TimeSpan.TicksPerMillisecond;
     
            float secondsLeft = (float)(msToWait - m) / 1000.0f;
            
            // The timer ran out
            if (secondsLeft < 0)
            {
                WorkTimer = 0;
                PlayerPrefs.SetInt("WorkTimer",WorkTimer);
                
                return true;
            }
     
            return false;
        }

        private void MoneyBonus()
        {
            Days += 1;
            WorkTimer = 1;

            if (Days == 1)
            {
                Gold += 50;
                Gold_Analitics += 50;
            }
            if (Days == 2)
            {
                Gold += 75;
                Gold_Analitics += 75;
            }
            if (Days == 3)
            {
                Gold += 100;
                Gold_Analitics += 100;
            }
            if (Days == 4)
            {
                Gold += 125;
                Gold_Analitics += 125;
            }
            if (Days == 5)
            {
                Gold += 150;
                Gold_Analitics += 150;
            }
            if (Days == 6)
            {
                Gold += 200;
                Gold_Analitics += 200;
            }
            if (Days == 7)
            {
                Gold += 300;
                Gold_Analitics += 300;
                Gems += 1;
                GemsAnalitics += 1;
            }

            PlayerPrefs.SetInt("Days",Days);
            PlayerPrefs.SetInt("WorkTimer",WorkTimer);
            PlayerPrefs.SetInt("Gold",Gold);
            PlayerPrefs.SetInt("Gems",Gems);
            PlayerPrefs.SetInt("GemsAnalitics",GemsAnalitics);
            PlayerPrefs.SetInt("Gold_Analitics",Gold_Analitics);
        }
}
}