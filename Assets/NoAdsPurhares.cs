using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NoAdsPurhares : MonoBehaviour
{
   public Image Bonus_Clasic;
   public Sprite Bonus_NoAds;

   public Image Daily_Clasic;
   public Sprite Daily_NoAds;

   public Image Fortune_Clasic;
   public Sprite Fortune_NoAds;

   [Header("Home")]
   public GameObject Purhase_Clasic_Home;
   public GameObject Purhase_Sale_Home;
   public GameObject Purhase_Owned_Home;

   [Header("Main Menu")]
   public GameObject Purhase_Clasic_MainMenu;
   public GameObject Purhase_Sale_MainMenu;
   public GameObject Purhase_Owned_MainMenu;

   public int NoAds;

    private void Start ()
    {
        NoAds = PlayerPrefs.GetInt("NoAds");
        if (NoAds == 1)
        {
            Bonus_Clasic.sprite = Bonus_NoAds;
            Daily_Clasic.sprite = Daily_NoAds;
            Fortune_Clasic.sprite = Fortune_NoAds;
            
            Purhase_Clasic_Home.SetActive(false);
            Purhase_Sale_Home.SetActive(false);
            Purhase_Owned_Home.SetActive(true);

            Purhase_Clasic_MainMenu.SetActive(false);
            Purhase_Sale_MainMenu.SetActive(false);
            Purhase_Owned_MainMenu.SetActive(true);
        }
    }

    public void BuyAds ()
    {
        NoAds = 1;
        PlayerPrefs.SetInt("NoAds",NoAds);

        Start();
    }
}
