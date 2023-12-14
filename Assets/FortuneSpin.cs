using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using Random=UnityEngine.Random;
using TMPro;

namespace Assets.SimpleAndroidNotifications{
public class FortuneSpin : MonoBehaviour
{   
    public Animation SpinAnimation;
    public float Randomspin, RandomspinProcantage;

    public Button AdsButton;
    public Button GemsButton;
    public Button FreeButton;
    public Button ClosedButton;

    [Header("Gold, Gems")]
    public int Gold;
    public int Gold_Analitics;
    public int Gems;
    public int GemsAnalitics;

    [Header("Safe Sphere")]
    public int IntSafeBonus;

    [Header("Character and Theme")]
    public CharacterShop ChrtShop;
    public ThemeShop ThmShop;

    [Header("Timer System (Ads, Premium)")]
    public TextMeshProUGUI TimerText;
    public float msToWait;
    public Button TimerButton;
    private ulong lastTimeClicked;
    public GameObject TimeAdsUI;

    [Header("Timer System (Free)")]
    public TextMeshProUGUI TimerTextFree;
    public float msToWaitFree;
    public Button TimerButtonFree;
    private ulong lastTimeClickedFree;
    public GameObject TimeFreeUI;
    public int IntFree;

    [Header("Gift System")]
    public GameObject MainBonusPanel;
    public Image MainBonusImage;

    public Sprite GemsFew;
    public Sprite GemsMany;
    public Sprite GoldHundret;
    public Sprite GoldFiveHundred;
    public Sprite GoldFifteenHundred;
    public Sprite RandomTheme;
    public Sprite RandomCharacter;
    public Sprite SafeBuble;

    [Header("Music")]
    public GameObject BackgroundSoundObject;
    public GameObject FortuneSoundObject;

    public AudioSource NoGemsGoldSound;
    public AudioSource WinSound;
    public AudioSource FortuneGemsSound;
    private int IntMusic;

    [Header("Ads")]
    public RewardAds Fortune_Ads;
    public int AdsTimerInt;

    private void Start ()
    {
        // If the ads has been watched, but the timer has not yet ended, then turn on the timer panel
        AdsTimerInt = PlayerPrefs.GetInt("AdsTimerInt");
        IntFree = PlayerPrefs.GetInt("IntFree");
        int NoAds = PlayerPrefs.GetInt("NoAds");

        if (AdsTimerInt == 1){
        TimeAdsUI.SetActive(true);
        }

        // Timer system (Ads, Premium)
        if(PlayerPrefs.HasKey("LastTimeFortune")){
        lastTimeClicked = ulong.Parse(PlayerPrefs.GetString("LastTimeFortune"));
        }else{
        lastTimeClicked = (ulong)DateTime.Now.Ticks;
        PlayerPrefs.SetString("LastTimeFortune", lastTimeClicked.ToString());
        }
        if (!Ready_AdsPremium())
        TimerButton.interactable = false;


        if (NoAds == 0 && IntFree == 0){
        TimeFreeUI.SetActive(true);
        }

        // Timer system (Free)
        if (NoAds == 0){
        if(PlayerPrefs.HasKey("LastTimeFortuneFree")){
        lastTimeClickedFree = ulong.Parse(PlayerPrefs.GetString("LastTimeFortuneFree"));
        }
        if (!Ready_Free())
        TimerButtonFree.interactable = false;
        }
    }

    private bool Ready_AdsPremium()
    {
        ulong diff = ((ulong)DateTime.Now.Ticks - lastTimeClicked);
        ulong m = diff / TimeSpan.TicksPerMillisecond;
     
        float secondsLeft = (float)(msToWait - m) / 1000.0f;
            
        // The timer ran out
        if (secondsLeft < 0)
        {
            TimeAdsUI.SetActive(false);

            AdsTimerInt = 0;
            PlayerPrefs.SetInt("AdsTimerInt",AdsTimerInt);
            return true;
        }
        return false;
    }

    private bool Ready_Free()
    {
        ulong difff = ((ulong)DateTime.Now.Ticks - lastTimeClickedFree);
        ulong mm = difff / TimeSpan.TicksPerMillisecond;
        float secondsLeftFree = (float)(msToWait - mm) / 1000.0f;
            
        // The timer ran out
        if (secondsLeftFree < 0)
        {
            TimeFreeUI.SetActive(true);

            IntFree = 0;
            PlayerPrefs.SetInt("IntFree",IntFree);
            return true;
        }
        return false;
    }

    // -- (Ads Button Fortune)
    public void FreeFortune()
    {
        lastTimeClickedFree = (ulong)DateTime.Now.Ticks;
        PlayerPrefs.SetString("LastTimeFortuneFree", lastTimeClickedFree.ToString());

        IntFree = 1;
        PlayerPrefs.SetInt("IntFree",IntFree);

        AdsBonus();
    }

    public void AdsFortune()
    {
        int NoAds = PlayerPrefs.GetInt("NoAds");

        // Ads
        if (NoAds == 0)
        {
            AdsTimerInt = 1;
            PlayerPrefs.SetInt("AdsTimerInt",AdsTimerInt);

            Fortune_Ads.Fortune_Ads();
        }

        // Purhares
        if (NoAds == 1)
        {
            AdsTimerInt = 1;
            PlayerPrefs.SetInt("AdsTimerInt",AdsTimerInt);

            AdsBonus();
        }
    }

    public void AdsBonus()
    {
        Randomspin = Random.Range(1, 9);
        RandomspinProcantage = Random.Range(0, 101);

        if (Randomspin == 1){
        if (RandomspinProcantage <= 90){
            SpinAnimation.Play("Spin Animation 1");
        }
        else 
        AdsBonus();
        }

        if (Randomspin == 2){
        if (RandomspinProcantage <= 40){
            SpinAnimation.Play("Spin Animation 2");
        }
        else 
        AdsBonus();
        }

        if (Randomspin == 3){
        if (RandomspinProcantage <= 90){
            SpinAnimation.Play("Spin Animation 3");
        }
        else 
        AdsBonus();
        }

        if (Randomspin == 4){
        if (RandomspinProcantage <= 0){
            SpinAnimation.Play("Spin Animation 4");
        }
        else 
        AdsBonus();
        }

        if (Randomspin == 5){
        if (RandomspinProcantage <= 50){
            SpinAnimation.Play("Spin Animation 5"); 
        }
        else 
        AdsBonus();
        }

        if (Randomspin == 6){
        if (RandomspinProcantage <= 25){
            SpinAnimation.Play("Spin Animation 6");
        }
        else 
        AdsBonus();
        }

        if (Randomspin == 7){
        if (RandomspinProcantage <= 40){
            SpinAnimation.Play("Spin Animation 7");
        }
        else 
        AdsBonus();
        }

        if (Randomspin == 8){
        if (RandomspinProcantage <= 0){
            SpinAnimation.Play("Spin Animation 8");
        }
        else 
        AdsBonus();
        }

        AdsButton.interactable = false;
        GemsButton.interactable = false;
        FreeButton.interactable = false;
        ClosedButton.interactable = false;

        if (IntMusic == 0)
        {
            BackgroundSoundObject.SetActive(false);
            FortuneSoundObject.SetActive(true);
        }
        if (IntFree == 1)
        {
            TimeFreeUI.SetActive(false);
        }

        StartCoroutine(GiftCoroutine());
    }

    // -- (Gems Button Fortune)
    public void GemsFortune()
    {
        Gems = PlayerPrefs.GetInt("Gems");

        if (Gems >= 5)
        {
            Gems -= 5;
            PlayerPrefs.SetInt("Gems",Gems);

            GemsBonus();
        }
        else 
        NoGemsGoldSound.Play();
    }

    private void GemsBonus ()
    {
        Randomspin = Random.Range(2, 3);
        RandomspinProcantage = Random.Range(0, 101);

        if (Randomspin == 1){
        if (RandomspinProcantage <= 90){
            SpinAnimation.Play("Spin Animation 1");
        }
        else 
        GemsBonus();
        }

        if (Randomspin == 2){
        if (RandomspinProcantage <= 50){
            SpinAnimation.Play("Spin Animation 2");
        }
        else 
        GemsBonus();
        }

        if (Randomspin == 3){
        if (RandomspinProcantage <= 90){
            SpinAnimation.Play("Spin Animation 3");
        }
        else 
        GemsBonus();
        }

        if (Randomspin == 4){
        if (RandomspinProcantage <= 20){
            SpinAnimation.Play("Spin Animation 4");
        }
        else 
        GemsBonus();
        }

        if (Randomspin == 5){
        if (RandomspinProcantage <= 60){
            SpinAnimation.Play("Spin Animation 5"); 
        }
        else 
        GemsBonus();
        }

        if (Randomspin == 6){
        if (RandomspinProcantage <= 50){
            SpinAnimation.Play("Spin Animation 6");
        }
        else 
        GemsBonus();
        }

        if (Randomspin == 7){
        if (RandomspinProcantage <= 50){
            SpinAnimation.Play("Spin Animation 7");
        }
        else 
        GemsBonus();
        }

        if (Randomspin == 8){
        if (RandomspinProcantage <= 10){
            SpinAnimation.Play("Spin Animation 8");
        }
        else 
        GemsBonus();
        }

        AdsButton.interactable = false;
        GemsButton.interactable = false;
        FreeButton.interactable = false;
        ClosedButton.interactable = false;

        if (IntMusic == 0)
        {
            BackgroundSoundObject.SetActive(false);
            FortuneSoundObject.SetActive(true);
        }

        StartCoroutine(GiftCoroutine());
    }

    // -- (Gift System)
    IEnumerator GiftCoroutine()
    {
        yield return new WaitForSeconds(2f);
        if (IntMusic == 0)
        {
            BackgroundSoundObject.SetActive(true);
            FortuneSoundObject.SetActive(false);
        }

        GiftSystem();
    }

    private void GiftSystem ()
    {
        if (Randomspin == 1){
            Gold += 100;
            Gold_Analitics += 100;
            PlayerPrefs.SetInt("Gold",Gold);
            PlayerPrefs.SetInt("Gold_Analitics",Gold_Analitics);

            MainBonusImage.sprite = GoldHundret;
        }
        if (Randomspin == 2){
            ThmShop.InventoryTimer();
            ThmShop.ThemeWinSpin();

            MainBonusImage.sprite= RandomTheme;
        }
        if (Randomspin == 3){
            IntSafeBonus = 1;
            PlayerPrefs.SetInt("IntSafeBonus",IntSafeBonus);

            MainBonusImage.sprite = SafeBuble;
        }
        if (Randomspin == 4){
            Gems += 10;
            GemsAnalitics += 10;
            PlayerPrefs.SetInt("Gems",Gems);
            PlayerPrefs.SetInt("GemsAnalitics",GemsAnalitics);

            MainBonusImage.sprite = GemsFew;
        }
        if (Randomspin == 5){
            Gold += 500;
            Gold_Analitics += 500;
            PlayerPrefs.SetInt("Gold",Gold);
            PlayerPrefs.SetInt("Gold_Analitics",Gold_Analitics);

            MainBonusImage.sprite = GoldFiveHundred;
        }
        if (Randomspin == 6){
            Gold += 1500;
            Gold_Analitics += 1500;
            PlayerPrefs.SetInt("Gold",Gold);
            PlayerPrefs.SetInt("Gold_Analitics",Gold_Analitics);

            MainBonusImage.sprite = GoldFifteenHundred;
        }
        if (Randomspin == 7){
            ChrtShop.InventoryTimer();
            ChrtShop.CharacterWinSpin();

            MainBonusImage.sprite = RandomCharacter;

        }
        if (Randomspin == 8){
            Gems += 25;
            GemsAnalitics += 25;
            PlayerPrefs.SetInt("Gems",Gems);
            PlayerPrefs.SetInt("GemsAnalitics",GemsAnalitics);

            MainBonusImage.sprite = GemsMany;
        }

        Randomspin = 0;
        AdsButton.interactable = true;
        GemsButton.interactable = true;
        FreeButton.interactable = true;
        ClosedButton.interactable = true;
        MainBonusPanel.SetActive(true);

        // Prise Sound
        if (IntMusic == 0)
        {
            WinSound.Play();
        }

        // Start Timer
        if (AdsTimerInt >= 1)
        {
            lastTimeClicked = (ulong)DateTime.Now.Ticks;
            PlayerPrefs.SetString("LastTimeFortune", lastTimeClicked.ToString());
            TimerButton.interactable = false;
            TimeAdsUI.SetActive(true);
        }
    }

    private void Update ()
    {
        AdsTimerInt = PlayerPrefs.GetInt("AdsTimerInt");
        IntMusic = PlayerPrefs.GetInt("IntMusic");

        // Timer 8 hour (Ads, Premium)
        if (!TimerButton.IsInteractable())
        {
            if (Ready_AdsPremium())
            {
                TimerText.text = "Ready!";
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
            TimerText.text = r;
        }

        // Timer 24 hour (Free)
        if (!TimerButtonFree.IsInteractable())
        {
            if (Ready_Free())
            {
                return;
            }
            ulong difff = ((ulong)DateTime.Now.Ticks - lastTimeClickedFree);
            ulong mm = difff / TimeSpan.TicksPerMillisecond;
            float secondsLeftFree = (float)(msToWaitFree - mm) / 1000.0f;

            string rR = "";
            //HOURS
            rR += ((int)secondsLeftFree / 3600).ToString() + ":";
            secondsLeftFree -= ((int)secondsLeftFree / 3600) * 3600;
            //MINUTES
            rR += ((int)secondsLeftFree / 60).ToString("00") + ":";
            //SECONDS
            rR += (secondsLeftFree % 60).ToString("00");
            TimerTextFree.text = rR;
        }
    }
}
}
