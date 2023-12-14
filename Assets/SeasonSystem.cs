using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class SeasonSystem : MonoBehaviour
{
    [Header("Time")]
    public int MonthInt;

    [Header("Season bonus")]
    public ThemeShop ThemeScript;
    private int ThemeCount;

    [Header("Winter bonus")]
    public int WinterInt;
    private int purharesSnow;

    public GameObject WinterOwned_ShopPanel;
    public GameObject WinterOwned_ShopList;

    [Header("Spring bonus")]
    public int SpringInt;
    private int purharesFlowers;

    public GameObject SpringOwned_ShopPanel;
    public GameObject SpringOwned_ShopList;

    [Header("Summer bonus")]
    public int SummerInt;
    public int purharesIsland;

    public GameObject SummerOwned_ShopPanel;
    public GameObject SummerOwned_ShopList;

    [Header("Autumn bonus")]
    public int AutumnInt;
    private int purharesAutumn;

    public GameObject AutumnOwned_ShopPanel;
    public GameObject AutumnOwned_ShopList;

    private void Start ()
    {
        string Month = System.DateTime.Now.ToString("MM");
        int.TryParse(Month, out MonthInt);

        purharesSnow = PlayerPrefs.GetInt("purharesSnow");
        WinterInt = PlayerPrefs.GetInt("WinterInt");

        purharesFlowers = PlayerPrefs.GetInt("purharesFlowers");
        SpringInt = PlayerPrefs.GetInt("SpringInt");

        purharesAutumn = PlayerPrefs.GetInt("purharesAutumn");
        AutumnInt = PlayerPrefs.GetInt("AutumnInt");

        purharesIsland = PlayerPrefs.GetInt("purharesIsland");
        SummerInt = PlayerPrefs.GetInt("SummerInt");

        ThemeCount = PlayerPrefs.GetInt("ThemeCount");

        // Winter
        if (MonthInt == 12 || MonthInt == 1 || MonthInt == 2)
        {
            if (purharesSnow == 0)
            {
                RemoveTheme();

                purharesSnow = 1;
                WinterInt = 1;
                ThemeCount += 1;
                PlayerPrefs.SetInt("purharesSnow",purharesSnow);
                PlayerPrefs.SetInt("WinterInt",WinterInt);
                PlayerPrefs.SetInt("ThemeCount",ThemeCount);

                ThemeScript.Start();
                ThemeScript.SelectedSnow();
            }
        }

        // Spring
        if (MonthInt == 3 || MonthInt == 4 || MonthInt == 5)
        {
            if (purharesFlowers == 0)
            {
                RemoveTheme();

                purharesFlowers = 1;
                SpringInt = 1;
                ThemeCount += 1;
                PlayerPrefs.SetInt("ThemeCount",ThemeCount);
                PlayerPrefs.SetInt("SpringInt",SpringInt);
                PlayerPrefs.SetInt("purharesFlowers",purharesFlowers);

                ThemeScript.Start();
                ThemeScript.SelectedFlowers();
            }
        }

        // Summer
        if (MonthInt == 6 || MonthInt == 7 || MonthInt == 8)
        {
            if (purharesIsland == 0)
            {
                RemoveTheme();

                purharesIsland = 1;
                SummerInt = 1;
                ThemeCount += 1;
                PlayerPrefs.SetInt("ThemeCount",ThemeCount);
                PlayerPrefs.SetInt("SummerInt",SummerInt);
                PlayerPrefs.SetInt("purharesIsland",purharesIsland);

                ThemeScript.Start();
                ThemeScript.SelectedIsland();
            }
        }

        // Autumn
        if (MonthInt == 9 || MonthInt == 10 || MonthInt == 11)
        {
            if (purharesAutumn == 0)
            {
                RemoveTheme();

                purharesAutumn = 1;
                AutumnInt = 1;
                ThemeCount += 1;
                PlayerPrefs.SetInt("ThemeCount",ThemeCount);
                PlayerPrefs.SetInt("AutumnInt",AutumnInt);
                PlayerPrefs.SetInt("purharesAutumn",purharesAutumn);

                ThemeScript.Start();
                ThemeScript.SelectedAutumn();
            }
        }
    }

    private void RemoveTheme ()
    {
        // Remove Winter
        if (WinterInt == 1){
            purharesSnow = 0; 
            WinterInt = 0;
            PlayerPrefs.SetInt("purharesSnow",purharesSnow);
            PlayerPrefs.SetInt("WinterInt",WinterInt);

            ThemeCount -= 1;
            PlayerPrefs.SetInt("ThemeCount",ThemeCount);

            ThemeScript.Start();
            ThemeScript.SelectedGreenField();
            WinterOwned_ShopPanel.SetActive(true);
            WinterOwned_ShopList.SetActive(false);
        }

        // Remove Spring
        if (SpringInt == 1){
            purharesFlowers = 0; 
            SpringInt = 0;
            PlayerPrefs.SetInt("purharesFlowers",purharesFlowers);
            PlayerPrefs.SetInt("SpringInt",SpringInt);

            ThemeCount -= 1;
            PlayerPrefs.SetInt("ThemeCount",ThemeCount);

            ThemeScript.Start();
            ThemeScript.SelectedGreenField();
            SpringOwned_ShopPanel.SetActive(true);
            SpringOwned_ShopList.SetActive(false);
        }

        // Remove Summer
        if (SummerInt == 1){
            purharesIsland = 0; 
            SummerInt = 0;
            PlayerPrefs.SetInt("purharesIsland",purharesIsland);
            PlayerPrefs.SetInt("SummerInt",SummerInt);

            ThemeCount -= 1;
            PlayerPrefs.SetInt("ThemeCount",ThemeCount);

            ThemeScript.Start();
            ThemeScript.SelectedGreenField();
            SummerOwned_ShopPanel.SetActive(true);
            SummerOwned_ShopList.SetActive(false);
        }

        // Remove Autumn
        if (AutumnInt == 1){
            purharesAutumn = 0; 
            AutumnInt = 0;
            PlayerPrefs.SetInt("purharesAutumn",purharesAutumn);
            PlayerPrefs.SetInt("AutumnInt",AutumnInt);

            ThemeCount -= 1;
            PlayerPrefs.SetInt("ThemeCount",ThemeCount);

            ThemeScript.Start();
            ThemeScript.SelectedGreenField();
            AutumnOwned_ShopPanel.SetActive(true);
            AutumnOwned_ShopList.SetActive(false);
        }
    }
}
