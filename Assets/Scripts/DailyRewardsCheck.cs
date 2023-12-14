using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;

public class DailyRewardsCheck : MonoBehaviour
{       
        public int WorkTimer;
        public int Days;
        public Text Time;
        public float msToWait;
        public Button TestButton;
        private ulong lastTimeClicked;
     
        private void Start()
        {
            if(PlayerPrefs.HasKey("LastTimeCheck")){
            lastTimeClicked = ulong.Parse(PlayerPrefs.GetString("LastTimeCheck"));
            }else{
                lastTimeClicked = (ulong)DateTime.Now.Ticks;
                PlayerPrefs.SetString("LastTimeCheck", lastTimeClicked.ToString());
            }
     
            if (!Ready())
                TestButton.interactable = false;
        }
     
        private void Update()
        {   
            WorkTimer = PlayerPrefs.GetInt("WorkTimer");
            Days = PlayerPrefs.GetInt("Days");
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
                lastTimeClicked = (ulong)DateTime.Now.Ticks;
                PlayerPrefs.SetString("LastTimeCheck", lastTimeClicked.ToString());
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
                Days = 0;
                PlayerPrefs.SetInt("Days",Days);

                WorkTimer = 0;
                PlayerPrefs.SetInt("WorkTimer",WorkTimer);

                return true;
            }
     
            return false;
        }
}
