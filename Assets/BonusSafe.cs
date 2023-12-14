using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.SimpleAndroidNotifications
{
public class BonusSafe : MonoBehaviour
{
   public GameObject Safe_Sphere;
   public Animation Safe_Animation;
   public int Safe_Bonus;
   public int BonusEnd;

   public int IntSafeBonus;
   public int ResumeInt;
   public int Mils;
   public int MilsBonus;
   public int BonusSphere;
   public int TimerInt;
   float timer;

   [Header("Select safe bubble")]
   public GameObject CanvasBubbleBonus;
   public RewardAds AdsScript;
   public int IntStartBubble;

   private void Start ()
   {
        IntSafeBonus = PlayerPrefs.GetInt("IntSafeBonus");
        ResumeInt = PlayerPrefs.GetInt("ResumeInt");

        // Defualt start bonus
        IntStartBubble = 0;
        PlayerPrefs.SetInt("IntStartBubble", IntStartBubble);

        // If resume (No Activate)
        if (ResumeInt == 0)
        {
            Mils = 0;
            PlayerPrefs.SetInt("intPos", Mils);
        }

        // If resume (Activate)
        if (ResumeInt == 1)
        {
            CanvasBubbleBonus.SetActive(false); 

            IntStartBubble = 1;
            PlayerPrefs.SetInt("IntStartBubble", IntStartBubble);
        }

        // If you have fortune bonus
        if (IntSafeBonus == 1)
        {
            CanvasBubbleBonus.SetActive(false); 

            IntStartBubble = 1;
            PlayerPrefs.SetInt("IntStartBubble", IntStartBubble);
        }
    }

    public void Yes_Safe ()
    {
        AdsScript.Bubble_Ads();
    }

    public void No_Safe ()
    {
        CanvasBubbleBonus.SetActive(false);

        IntStartBubble = 1;
        PlayerPrefs.SetInt("IntStartBubble", IntStartBubble);
    }

    public void ActivateBonus ()
    {
        Safe_Animation.Play("SafeSphereSpawn");
        Safe_Sphere.SetActive(true);

        Safe_Bonus = 1;
        PlayerPrefs.SetInt("Safe_Bonus", Safe_Bonus);
    }

    public void DeletBonusSafeInf()
    {
        BonusSphere = 0;
        Safe_Bonus = 0;
        BonusEnd = 0;
        BonusSphere = 0;
        MilsBonus = 0;

        PlayerPrefs.SetInt("MilsBonus", MilsBonus);
        PlayerPrefs.SetInt("BonusSphere", BonusSphere);
        PlayerPrefs.SetInt("Safe_Bonus", Safe_Bonus);
        PlayerPrefs.SetInt("BonusEnd", BonusEnd);
        PlayerPrefs.SetInt("BonusSphere", BonusSphere);
    }

    private void Update ()
    {
        IntSafeBonus = PlayerPrefs.GetInt("IntSafeBonus");
        Safe_Bonus = PlayerPrefs.GetInt("Safe_Bonus");
        MilsBonus = PlayerPrefs.GetInt("MilsBonus");
        BonusSphere = PlayerPrefs.GetInt("BonusSphere");
        BonusEnd = PlayerPrefs.GetInt("BonusEnd");
        Mils = PlayerPrefs.GetInt("intPos");

        // Fortune Bonus
        if (IntSafeBonus == 1)
        {
            Safe_Animation.Play("SafeSphereSpawn");
            Safe_Sphere.SetActive(true);

            Safe_Bonus = 1;
            IntSafeBonus = 0;
            PlayerPrefs.SetInt("Safe_Bonus", Safe_Bonus);
            PlayerPrefs.SetInt("IntSafeBonus", IntSafeBonus);
        }

        // Miles Bonus
        if (BonusSphere == 0){
        if (Mils >= 100)
        {   
            Safe_Animation.Play("SafeSphereSpawn");
            Safe_Sphere.SetActive(true);

            BonusSphere = 1;
            MilsBonus = Mils + 100;
            Safe_Bonus = 1;
            PlayerPrefs.SetInt("MilsBonus", MilsBonus);
            PlayerPrefs.SetInt("BonusSphere", BonusSphere);
            PlayerPrefs.SetInt("Safe_Bonus", Safe_Bonus);
        }
        }

        if (BonusSphere == 1){
        if (Mils >= MilsBonus)
        {
            Safe_Animation.Play("SafeSphereSpawn");
            Safe_Animation.Play();
            Safe_Sphere.SetActive(true);

            BonusSphere = 2;
            MilsBonus = Mils + 100;
            Safe_Bonus = 1;
            PlayerPrefs.SetInt("MilsBonus", MilsBonus);
            PlayerPrefs.SetInt("BonusSphere", BonusSphere);
            PlayerPrefs.SetInt("Safe_Bonus", Safe_Bonus);
        }
        }

        if (BonusSphere == 2){
        if (Mils >= MilsBonus)
        {
            Safe_Animation.Play("SafeSphereSpawn");
            Safe_Animation.Play();
            Safe_Sphere.SetActive(true);

            BonusSphere = 1;
            MilsBonus = Mils + 100;
            Safe_Bonus = 1;
            PlayerPrefs.SetInt("MilsBonus", MilsBonus);
            PlayerPrefs.SetInt("BonusSphere", BonusSphere);
            PlayerPrefs.SetInt("Safe_Bonus", Safe_Bonus);
        }
        }


        // End Bonus
        if (BonusEnd == 1)
        {
            Safe_Animation.Play("SafeSphere");
            
            TimerInt = 1;
            BonusEnd = 0;
            PlayerPrefs.SetInt("BonusEnd", BonusEnd);
        }

        if (TimerInt == 1)
        {
            timer += Time.deltaTime;
            if (timer >= 1)
            {   
                Safe_Bonus = 0;
                TimerInt = 0;
                timer = 0;
                PlayerPrefs.SetInt("Safe_Bonus", Safe_Bonus);
                Safe_Sphere.SetActive(false);
            }
        }
   }
}
}