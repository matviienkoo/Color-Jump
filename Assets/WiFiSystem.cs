using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WiFiSystem : MonoBehaviour
{
    [Header("Ads Buttons")]
    public Button DailyClaim;
    public Button DailyFortune;

    [Header("Defualt Numbers")]
    public int ResumeInt;
    public int MilesRemove;
    public int Gold_Remove;
    public int CS_System;
    public int BonusInt;
    public int Mils_System;
    public int BonusInt_System;
    public int Safe_Bonus;
    public int MilsBonus;
    public int BonusSphere;
    public int BonusEnd;

    private void Start ()
    {
        CS_System = 0;
        ResumeInt = 0;
        MilesRemove = 0;
        Gold_Remove = 0;
        Mils_System = 0;
        BonusInt = 0;
        BonusInt_System = 0;
        Safe_Bonus = 0;
        MilsBonus = 0;
        BonusSphere = 0;
        BonusEnd = 0;
        PlayerPrefs.SetInt("CS_System",CS_System);
        PlayerPrefs.SetInt("ResumeInt",ResumeInt);
        PlayerPrefs.SetInt("MilesRemove",MilesRemove);
        PlayerPrefs.SetInt("Gold_Remove",Gold_Remove);
        PlayerPrefs.SetInt("BonusInt", BonusInt);
        PlayerPrefs.SetInt("Mils_System", Mils_System);
        PlayerPrefs.SetInt("BonusInt_System", BonusInt_System);
        PlayerPrefs.SetInt("Safe_Bonus", Safe_Bonus);
        PlayerPrefs.SetInt("MilsBonus", MilsBonus);
        PlayerPrefs.SetInt("BonusSphere", BonusSphere);
        PlayerPrefs.SetInt("BonusEnd", BonusEnd);

        if(Application.internetReachability == NetworkReachability.NotReachable)
        {
            DailyClaim.interactable = false;
            DailyFortune.interactable = false;
        }
        else      
        DailyClaim.interactable = true;
        DailyFortune.interactable = true;
    }
}
