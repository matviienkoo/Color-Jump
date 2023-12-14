using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class HolidaySales : MonoBehaviour
{
[Header("Holiday Panel")]
public GameObject GameObject_Sale;
public GameObject GameObject_Shop;
public int HolidaySalesInt;

[Header("Holiday Sales, Timer")]
public Image Image_Sales;
public Image Image_Shop;
public Image Image_Closed;
public TextMeshProUGUI TextTimer;
public float WaitMsTimer;
private ulong LastTimeTimer;

[Header("Christmas")]
public Sprite Sprite_Christmas_Panel;
public Sprite Sprite_Christmas_Shop;
public Sprite Sprite_Christmas_Closed;
public int ChristmasInt;

[Header("Easter")]
public Sprite Sprite_Easter_Panel;
public Sprite Sprite_Easter_Shop;
public Sprite Sprite_Easter_Closed;
public int EasterInt;

[Header("Halloween")]
public Sprite Sprite_Halloween_Panel;
public Sprite Sprite_Halloween_Shop;
public Sprite Sprite_Halloween_Closed;
public int HalloweenInt;

[Header("Valentine")]
public Sprite Sprite_Valentine_Panel;
public Sprite Sprite_Valentine_Shop;
public Sprite Sprite_Valentine_Closed;
public int ValentineInt;

[Header("Sale Design (Remove Ads - Shop)")]
public Image Image_RemoveAds_SHOP;
public Sprite Sprite_RemoveAds_SHOP;
public GameObject GameObject_RemoveAds_SHOP;
public GameObject GameObject_ButtonRemoveAds_Clasic_SHOP;
public GameObject GameObject_ButtonRemoveAds_Sale_SHOP;

[Header("Sale Design (Remove Ads - MainMenu)")]
public Image Image_RemoveAds_MAINMENU;
public Sprite Sprite_RemoveAds_MAINMENU;
public GameObject GameObject_RemoveAds_MAINMENU;
public GameObject GameObject_ButtonRemoveAds_Clasic_MAINMENU;
public GameObject GameObject_ButtonRemoveAds_Sale_MAINMENU;

[Header("Sale Design (Promote) - Button")]
public Image Image_PromoteOneMonth_Button;
public Sprite Sprite_PromoteOneMonth_Button;
public Image Image_PromoteSixMonth_Button;
public Sprite Sprite_PromoteSixMonth_Button;
public Image Image_PromoteOneYear_Button;
public Sprite Sprite_PromoteOneYear_Button;

[Header("Sale Design (Promote) - Panel")]
public Image Image_PromoteOneMonth_Panel;
public Sprite Sprite_PromoteOneMonth_Panel;
public Image Image_PromoteSixMonth_Panel;
public Sprite Sprite_PromoteSixMonth_Panel;
public Image Image_PromoteOneYear_Panel;
public Sprite Sprite_PromoteOneYear_Panel;

[Header("Scripts")]
public PurharesShop PurhaseScript;
public ThemeShop ThemeScript;
public CharacterShop CharacterScript;
private int NoAds;

private void Start ()
{
    PlayerPrefs.SetString("date time", System.DateTime.Now.ToString("MM/dd"));
    ChristmasInt = PlayerPrefs.GetInt("ChristmasInt");
    EasterInt = PlayerPrefs.GetInt("EasterInt");
    HalloweenInt = PlayerPrefs.GetInt("HalloweenInt");
    ValentineInt = PlayerPrefs.GetInt("ValentineInt");
    HolidaySalesInt = PlayerPrefs.GetInt("HolidaySalesInt");
    NoAds = PlayerPrefs.GetInt("NoAds");
        
    // -- Timer --
    if(PlayerPrefs.HasKey("TimerHolidaySales")){
    LastTimeTimer = ulong.Parse(PlayerPrefs.GetString("TimerHolidaySales"));
    }else{
    LastTimeTimer = (ulong)DateTime.Now.Ticks;
    PlayerPrefs.SetString("TimerHolidaySales", LastTimeTimer.ToString());
    }

    // -- Christmas --
    if (PlayerPrefs.GetString("date time") == "12.23"){
    ChristmasDate();
    ChangeDesing();

    PurhaseScript.ChangeDesing();
    ThemeScript.SystemShop();
    CharacterScript.SystemShop();
    }
    if (ChristmasInt == 1){
    GameObject_Sale.SetActive(true);
    Image_Sales.GetComponent<Image>().sprite = Sprite_Christmas_Panel;
    Image_Shop.GetComponent<Image>().sprite = Sprite_Christmas_Shop;
    Image_Closed.GetComponent<Image>().sprite = Sprite_Christmas_Closed;
    }

    // -- Easter --
    if (PlayerPrefs.GetString("date time") == "03.20"){
    EasterDate();
    ChangeDesing();

    PurhaseScript.ChangeDesing();
    ThemeScript.SystemShop();
    CharacterScript.SystemShop();
    }
    if (EasterInt == 1){
    GameObject_Sale.SetActive(true);
    Image_Sales.GetComponent<Image>().sprite = Sprite_Easter_Panel;
    Image_Shop.GetComponent<Image>().sprite = Sprite_Easter_Shop;
    Image_Closed.GetComponent<Image>().sprite = Sprite_Easter_Closed;
    }

    // -- Halloween --
    if (PlayerPrefs.GetString("date time") == "10.30"){
    HalloweenDate();
    ChangeDesing();

    PurhaseScript.ChangeDesing();
    ThemeScript.SystemShop();
    CharacterScript.SystemShop();
    }
    if (HalloweenInt == 1){
    GameObject_Sale.SetActive(true);
    Image_Sales.GetComponent<Image>().sprite = Sprite_Halloween_Panel;
    Image_Shop.GetComponent<Image>().sprite = Sprite_Halloween_Shop;
    Image_Closed.GetComponent<Image>().sprite = Sprite_Halloween_Closed;
    }

    // -- Valentine --
    if (PlayerPrefs.GetString("date time") == "02.13"){
    ValentineDate();
    ChangeDesing();

    PurhaseScript.ChangeDesing();
    ThemeScript.SystemShop();
    CharacterScript.SystemShop();
    }
    if (ValentineInt == 1){
    GameObject_Sale.SetActive(true);
    Image_Sales.GetComponent<Image>().sprite = Sprite_Valentine_Panel;
    Image_Shop.GetComponent<Image>().sprite = Sprite_Valentine_Shop;
    Image_Closed.GetComponent<Image>().sprite = Sprite_Valentine_Closed;
    }
}

public void ShopNow ()
{
    GameObject_Sale.SetActive(false);
    GameObject_Shop.SetActive(true);
}

public void ChangeDesing ()
{
    if (HolidaySalesInt == 1)
    {
        // --- Remove Adversting 
        Image_RemoveAds_SHOP.GetComponent<Image>().sprite = Sprite_RemoveAds_SHOP;
        GameObject_RemoveAds_SHOP.SetActive(true);
        
        GameObject_ButtonRemoveAds_Clasic_SHOP.SetActive(false);
        GameObject_ButtonRemoveAds_Sale_SHOP.SetActive(true);

        Image_RemoveAds_MAINMENU.GetComponent<Image>().sprite = Sprite_RemoveAds_MAINMENU;
        GameObject_RemoveAds_MAINMENU.SetActive(true);

        GameObject_ButtonRemoveAds_Clasic_MAINMENU.SetActive(false);
        GameObject_ButtonRemoveAds_Sale_MAINMENU.SetActive(true);

        // --- Promote
        Image_PromoteOneMonth_Button.GetComponent<Image>().sprite = Sprite_PromoteOneMonth_Button;
        Image_PromoteSixMonth_Button.GetComponent<Image>().sprite = Sprite_PromoteSixMonth_Button;
        Image_PromoteOneYear_Button.GetComponent<Image>().sprite = Sprite_PromoteOneYear_Button;

        Image_PromoteOneMonth_Panel.GetComponent<Image>().sprite = Sprite_PromoteOneMonth_Panel;
        Image_PromoteSixMonth_Panel.GetComponent<Image>().sprite = Sprite_PromoteSixMonth_Panel;
        Image_PromoteOneYear_Panel.GetComponent<Image>().sprite = Sprite_PromoteOneYear_Panel;
    }
}

private void ChristmasDate ()
{
    if (ChristmasInt == 0){
    LastTimeTimer = (ulong)DateTime.Now.Ticks;
    PlayerPrefs.SetString("TimerHolidaySales", LastTimeTimer.ToString());

    ChristmasInt = 1;
    PlayerPrefs.SetInt("ChristmasInt",ChristmasInt);

    HolidaySalesInt = 1;
    PlayerPrefs.SetInt("HolidaySalesInt",HolidaySalesInt);
    }
}

private void EasterDate ()
{
    if (EasterInt == 0){
    LastTimeTimer = (ulong)DateTime.Now.Ticks;
    PlayerPrefs.SetString("TimerHolidaySales", LastTimeTimer.ToString());

    EasterInt = 1;
    PlayerPrefs.SetInt("EasterInt",EasterInt);

    HolidaySalesInt = 1;
    PlayerPrefs.SetInt("HolidaySalesInt",HolidaySalesInt);
    }
}

private void HalloweenDate ()
{
    if (HalloweenInt == 0){
    LastTimeTimer = (ulong)DateTime.Now.Ticks;
    PlayerPrefs.SetString("TimerHolidaySales", LastTimeTimer.ToString());

    HalloweenInt = 1;
    PlayerPrefs.SetInt("HalloweenInt",HalloweenInt);

    HolidaySalesInt = 1;
    PlayerPrefs.SetInt("HolidaySalesInt",HolidaySalesInt);
    }
}

private void ValentineDate ()
{
    if (ValentineInt == 0){
    LastTimeTimer = (ulong)DateTime.Now.Ticks;
    PlayerPrefs.SetString("TimerHolidaySales", LastTimeTimer.ToString());

    ValentineInt = 1;
    PlayerPrefs.SetInt("ValentineInt",ValentineInt);

    HolidaySalesInt = 1;
    PlayerPrefs.SetInt("HolidaySalesInt",HolidaySalesInt);
    }
}

private void Update ()
{
    if (ChristmasInt == 1 || EasterInt == 1 || HalloweenInt == 1 || ValentineInt == 1){
    ulong Biff_Timer = ((ulong)DateTime.Now.Ticks - LastTimeTimer);
    ulong M_Timer = Biff_Timer / TimeSpan.TicksPerMillisecond;
    float SecondsTimer = (float)(WaitMsTimer - M_Timer) / 1000.0f;

    string StringText = "";
    // HOURS
    StringText += ((int)SecondsTimer / 3600).ToString() + ":";
    SecondsTimer -= ((int)SecondsTimer / 3600) * 3600;
    //MINUTES
    StringText += ((int)SecondsTimer / 60).ToString("00") + ":";
    //SECONDS
    StringText += (SecondsTimer % 60).ToString("00");
    TextTimer.text = StringText;

    if (SecondsTimer < 0)
    {
        ChristmasInt = 0;
        EasterInt = 0;
        HalloweenInt = 0;
        ValentineInt = 0;
        HolidaySalesInt = 0;

        PlayerPrefs.SetInt("HolidaySalesInt",HolidaySalesInt);
        PlayerPrefs.SetInt("ChristmasInt",ChristmasInt);
        PlayerPrefs.SetInt("EasterInt",EasterInt);
        PlayerPrefs.SetInt("HalloweenInt",HalloweenInt);
        PlayerPrefs.SetInt("ValentineInt",ValentineInt);
    }
    }
}
}
