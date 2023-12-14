using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FortuneGemsTimer : MonoBehaviour
{   
    public int Days;
    public Text Time;
    public float msToWait;
    public Button TestButton;
    private ulong lastTimeClicked;
    public Button TimerButton;

    public CharacterShop BonusChararacterLeft;
    public ThemeShop BonusThemeLeft;

    public CharacterShop ChrtShop;
    public ThemeShop ThmShop;

    private void Start ()
    {
        if(PlayerPrefs.HasKey("lastTimeFortuneGems")){
        lastTimeClicked = ulong.Parse(PlayerPrefs.GetString("lastTimeFortuneGems"));
        }else{
        lastTimeClicked = (ulong)DateTime.Now.Ticks;
        PlayerPrefs.SetString("lastTimeFortuneGems", lastTimeClicked.ToString());
        }

        if (!Ready())
        TimerButton.interactable = false;
    }

    public void StartTimer()
    {
        lastTimeClicked = (ulong)DateTime.Now.Ticks;
        PlayerPrefs.SetString("lastTimeFortuneGems", lastTimeClicked.ToString());
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
            return true;
        }
     
        return false;
    }

    private void Update()
    {   
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
}
