using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.IO;

namespace Assets.SimpleAndroidNotifications
{
public class CanvasGameManager : MonoBehaviour
{
    public static CanvasGameManager instance;
    public TextMeshProUGUI Text_Gold_GameOver;
    int Gold_GameOver;

    public int intPos;
    public int MilesAnalitics;
    public int MilesRemove;
    public int Gold_Remove;
    public int IntStats;
    public int int_dead;
    public int ResumeInt;
    public int CS_System;

    public int NoAds;
    public Image Resume_Clasic;
    public Sprite Resume_NoAds;

    // shop objects
    public GameObject CoinShop;
    public GameObject GemsShop;

    // text bonus 
    public BonusText BTscript;
    public BonusSafe BSscript;

    private void Awake()
    {
        instance = this;
    }
    private void Start ()
    {
        NoAds = PlayerPrefs.GetInt("NoAds");
        if (NoAds == 1)
        {
            Resume_Clasic.sprite = Resume_NoAds;
        }

        Gold_GameOver = 0;
        PlayerPrefs.SetInt("Gold_GameOver",Gold_GameOver);
    }

    public void Restart ()
    {
        BTscript.DeletMilsInf();
        BSscript.DeletBonusSafeInf();
        Gold_Remove = 0;
        ResumeInt = 0;
        MilesRemove = 0;
        CS_System = 0;
        PlayerPrefs.SetInt("CS_System",CS_System);
        PlayerPrefs.SetInt("Gold_Remove",Gold_Remove);
        PlayerPrefs.SetInt("ResumeInt",ResumeInt);
        PlayerPrefs.SetInt("MilesRemove",MilesRemove);

        SceneManager.LoadScene ("CSGGame");
    }

    public void Share ()
    {
        StartCoroutine ("TakeScreenShotAndShare");
    }

    IEnumerator TakeScreenShotAndShare ()
    {
        yield return new WaitForEndOfFrame ();

        Texture2D tx = new Texture2D (Screen.width, Screen.height, TextureFormat.RGB24, false);
        tx.ReadPixels (new Rect (0, 0, Screen.width, Screen.height), 0, 0);
        tx.Apply ();

        string path = Path.Combine (Application.temporaryCachePath, "sharedImage.png");//image name
        File.WriteAllBytes (path, tx.EncodeToPNG ());

        Destroy (tx); //to avoid memory leaks

        new NativeShare ()
        .SetSubject ("Color Jump")
        .SetText ("https://play.google.com/store/apps/details?id=com.MdGame.ColorJump")
        .Share ();
    }

    public void Exit ()
    {
        SceneManager.LoadScene ("CSGStartMenu");
    }

    private void Update ()
    {
        MilesAnalitics = PlayerPrefs.GetInt("MilesAnalitics");
        int_dead = PlayerPrefs.GetInt("int_dead");
        intPos = PlayerPrefs.GetInt("intPos");
        Gold_GameOver = PlayerPrefs.GetInt("Gold_GameOver");
        Gold_Remove = PlayerPrefs.GetInt("Gold_Remove");
        Text_Gold_GameOver.text = Gold_GameOver.ToString();

        if (IntStats == 0){
        if (int_dead == 1)
        {
            IntStats = 1;
            MilesRemove = intPos;
            MilesAnalitics += intPos;
            PlayerPrefs.SetInt("MilesRemove", MilesRemove);
            PlayerPrefs.SetInt("MilesAnalitics", MilesAnalitics);
        }
        }
    }
}
}