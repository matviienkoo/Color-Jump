using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ThemeShop : MonoBehaviour
{
    public List<GameObject> OwnedObjects;
    private int InventoryTimerInt;

    [Header("Gold Gems")]
    [SerializeField] int Gold;
    [SerializeField] int Gems;
    [SerializeField] int ThemeInt;

    [SerializeField] int ThemeCount;
    [SerializeField] TextMeshProUGUI ThemeCountText;

    [Header("Flowers")]
    [SerializeField] GameObject OwnedField_Button;

    [SerializeField] int priceFlowers;
    [SerializeField] int purharesFlowers;
    [SerializeField] GameObject UnlockedFlowers_Shop;
    [SerializeField] GameObject UnlockedFlowers_Theme;
    [SerializeField] GameObject OwnedFlowers_Button;

    [SerializeField] GameObject UnlockedFlowers_Shop_Clasic;
    [SerializeField] Sprite UnlockedFlowers_Shop_Sales;

    [Header("Pyramids")]
    [SerializeField] int pricePyramids;
    [SerializeField] int purharesPyramids;
    [SerializeField] GameObject UnlockedPyramids_Shop;
    [SerializeField] GameObject UnlockedPyramids_Theme;
    [SerializeField] GameObject OwnedPyramids_Button;

    [SerializeField] GameObject UnlockedPyramids_Shop_Clasic;
    [SerializeField] Sprite UnlockedPyramids_Shop_Sales;

    [Header("Desert")]
    [SerializeField] int priceDesert;
    [SerializeField] int purharesDesert;
    [SerializeField] GameObject UnlockedDesert_Shop;
    [SerializeField] GameObject UnlockedDesert_Theme;
    [SerializeField] GameObject OwnedDesert_Button;

    [SerializeField] GameObject UnlockedDesert_Shop_Clasic;
    [SerializeField] Sprite UnlockedDesert_Shop_Sales;

    [Header("Snow")]
    [SerializeField] int priceSnow;
    [SerializeField] int purharesSnow;
    [SerializeField] GameObject UnlockedSnow_Shop;
    [SerializeField] GameObject UnlockedSnow_Theme;
    [SerializeField] GameObject OwnedSnow_Button;

    [SerializeField] GameObject UnlockedSnow_Shop_Clasic;
    [SerializeField] Sprite UnlockedSnow_Shop_Sales;

    [Header("Island")]
    [SerializeField] int priceIsland;
    [SerializeField] int purharesIsland;
    [SerializeField] GameObject UnlockedIsland_Shop;
    [SerializeField] GameObject UnlockedIsland_Theme;
    [SerializeField] GameObject OwnedIsland_Button;

    [SerializeField] GameObject UnlockedIsland_Shop_Clasic;
    [SerializeField] Sprite UnlockedIsland_Shop_Sales;

    [Header("Volcano")]
    [SerializeField] int priceVolcano;
    [SerializeField] int purharesVolcano;
    [SerializeField] GameObject UnlockedVolcano_Shop;
    [SerializeField] GameObject UnlockedVolcano_Theme;
    [SerializeField] GameObject OwnedVolcano_Button;

    [SerializeField] GameObject UnlockedVolcano_Shop_Clasic;
    [SerializeField] Sprite UnlockedVolcano_Shop_Sales;

    [Header("Night Sky")]
    [SerializeField] int priceNightSky;
    [SerializeField] int purharesNightSky;
    [SerializeField] GameObject UnlockedNightSky_Shop;
    [SerializeField] GameObject UnlockedNightSky_Theme;
    [SerializeField] GameObject OwnedNightSky_Button;

    [SerializeField] GameObject UnlockedNightSky_Shop_Clasic;
    [SerializeField] Sprite UnlockedNightSky_Shop_Sales;

    [Header("Autumn")]
    [SerializeField] int priceAutumn;
    [SerializeField] int purharesAutumn;
    [SerializeField] GameObject UnlockedAutumn_Shop;
    [SerializeField] GameObject UnlockedAutumn_Theme;
    [SerializeField] GameObject OwnedAutumn_Button;

    [SerializeField] GameObject UnlockedAutumn_Shop_Clasic;
    [SerializeField] Sprite UnlockedAutumn_Shop_Sales;

    [Header("Dinosaurus")]
    [SerializeField] int priceDinosaurus;
    [SerializeField] int purharesDinosaurus;
    [SerializeField] GameObject UnlockedeDinosaurus_Shop;
    [SerializeField] GameObject UnlockedeDinosaurus_Theme;
    [SerializeField] GameObject OwnedeDinosaurus_Button;

    [SerializeField] GameObject UnlockedeDinosaurus_Shop_Clasic;
    [SerializeField] Sprite UnlockedeDinosaurus_Shop_Sales;

    [Header("Aquarium")]
    [SerializeField] int priceAquarium;
    [SerializeField] int purharesAquarium;
    [SerializeField] GameObject UnlockedAquarium_Shop;
    [SerializeField] GameObject UnlockedAquarium_Theme;
    [SerializeField] GameObject OwnedAquarium_Button;

    [SerializeField] GameObject UnlockedAquarium_Shop_Clasic;
    [SerializeField] Sprite UnlockedAquarium_Shop_Sales;

    [Header("Space")]
    [SerializeField] int priceSpace;
    [SerializeField] int purharesSpace;
    [SerializeField] GameObject UnlockedSpace_Shop;
    [SerializeField] GameObject UnlockedSpace_Theme;
    [SerializeField] GameObject OwnedSpace_Button;

    [SerializeField] GameObject UnlockedSpace_Shop_Clasic;
    [SerializeField] Sprite UnlockedSpace_Shop_Sales;

    [Header("Rain")]
    [SerializeField] int priceRain;
    [SerializeField] int purharesRain;
    [SerializeField] GameObject UnlockedRain_Shop;
    [SerializeField] GameObject UnlockedRain_Theme;
    [SerializeField] GameObject OwnedRain_Button;
    [SerializeField] GameObject SelectedRain_Button;

    [SerializeField] GameObject UnlockedRain_Shop_Clasic;
    [SerializeField] Sprite UnlockedRain_Shop_Sales;

    [Header("Sales")]
    public int HolidaySalesInt;

    [Header("Script")]
    public InventoryScript InvScript;

    [Header("AudioCharacter")]
    public AudioSource UnLock_Audio;
    public AudioSource Eror_Audio;

    public void Start()
    {
        ThemeInt = PlayerPrefs.GetInt("ThemeInt");
        ThemeCount = PlayerPrefs.GetInt("ThemeCount");
        HolidaySalesInt = PlayerPrefs.GetInt("HolidaySalesInt");

        purharesFlowers = PlayerPrefs.GetInt("purharesFlowers");
        purharesPyramids = PlayerPrefs.GetInt("purharesPyramids");
        purharesDesert = PlayerPrefs.GetInt("purharesDesert");
        purharesSnow = PlayerPrefs.GetInt("purharesSnow");
        purharesIsland = PlayerPrefs.GetInt("purharesIsland");
        purharesVolcano = PlayerPrefs.GetInt("purharesVolcano");
        purharesNightSky = PlayerPrefs.GetInt("purharesNightSky");
        purharesAutumn = PlayerPrefs.GetInt("purharesAutumn");
        purharesDinosaurus = PlayerPrefs.GetInt("purharesDinosaurus");
        purharesAquarium = PlayerPrefs.GetInt("purharesAquarium");
        purharesSpace = PlayerPrefs.GetInt("purharesSpace");
        purharesRain = PlayerPrefs.GetInt("purharesRain");

        if (ThemeCount == 0)
        {
            ThemeCount = 1;
            PlayerPrefs.SetInt("ThemeCount", ThemeCount); 
        }
        SystemShop();
    }

    // Select Object
    public void SelectedGreenField()
    {
        OwnedField_Button.SetActive(true);
        ThemeInt = 0;
        PlayerPrefs.SetInt("ThemeInt",ThemeInt);

        SystemShop();
    }

    public void SelectedFlowers()
    {
        OwnedFlowers_Button.SetActive(true);
        ThemeInt = 1;
        PlayerPrefs.SetInt("ThemeInt",ThemeInt);

        SystemShop();
    }

    public void SelectedPyramids()
    {
        OwnedPyramids_Button.SetActive(true);
        ThemeInt = 2;
        PlayerPrefs.SetInt("ThemeInt",ThemeInt);

        SystemShop();
    }

    public void SelectedDesert()
    {
        OwnedDesert_Button.SetActive(true);
        ThemeInt = 3;
        PlayerPrefs.SetInt("ThemeInt",ThemeInt);

        SystemShop();
    }

    public void SelectedSnow()
    {
        OwnedSnow_Button.SetActive(true);
        ThemeInt = 4;
        PlayerPrefs.SetInt("ThemeInt",ThemeInt);

        SystemShop();
    }

    public void SelectedIsland()
    {
        OwnedIsland_Button.SetActive(true);
        ThemeInt = 5;
        PlayerPrefs.SetInt("ThemeInt",ThemeInt);

        SystemShop();
    }

    public void SelectedVolcano()
    {
        OwnedVolcano_Button.SetActive(true);
        ThemeInt = 6;
        PlayerPrefs.SetInt("ThemeInt",ThemeInt);

        SystemShop();
    }

    public void SelectedNightSky()
    {
        OwnedNightSky_Button.SetActive(true);
        ThemeInt = 7;
        PlayerPrefs.SetInt("ThemeInt",ThemeInt);

        SystemShop();
    }

    public void SelectedAutumn()
    {
        OwnedAutumn_Button.SetActive(true);
        ThemeInt = 8;
        PlayerPrefs.SetInt("ThemeInt",ThemeInt);

        SystemShop();
    }

    public void SelectedeDinosaurus()
    {
        OwnedeDinosaurus_Button.SetActive(true);
        ThemeInt = 9;
        PlayerPrefs.SetInt("ThemeInt",ThemeInt);

        SystemShop();
    }

    public void SelectedAquarium()
    {
        OwnedAquarium_Button.SetActive(true);
        ThemeInt = 10;
        PlayerPrefs.SetInt("ThemeInt",ThemeInt);

        SystemShop();
    }

    public void SelectedSpace()
    {
        OwnedSpace_Button.SetActive(true);
        ThemeInt = 11;
        PlayerPrefs.SetInt("ThemeInt",ThemeInt);

        SystemShop();
    }

    public void SelectedRain()
    {
        OwnedRain_Button.SetActive(true);
        ThemeInt = 12;
        PlayerPrefs.SetInt("ThemeInt",ThemeInt);

        SystemShop();
    }

    // Buy Object
    public void PurchaseFlowers()
    {
        if (Gems >= priceFlowers)
        {
            Gems -= priceFlowers;
            purharesFlowers = 1;
            ThemeCount += 1;
            UnlockedFlowers_Shop.SetActive(true);
            UnlockedFlowers_Theme.SetActive(false);

            PlayerPrefs.SetInt("Gems",Gems);
            PlayerPrefs.SetInt("ThemeCount",ThemeCount);
            PlayerPrefs.SetInt("purharesFlowers",purharesFlowers);

            UnLock_Audio.Play();
        }
        else
        Eror_Audio.Play();
    }
    public void PurchasePyramids()
    {
        if (Gems >= pricePyramids)
        {
            Gems -= pricePyramids;
            purharesPyramids = 1;
            ThemeCount += 1;
            UnlockedPyramids_Shop.SetActive(true);
            UnlockedPyramids_Theme.SetActive(false);

            PlayerPrefs.SetInt("Gems",Gems);
            PlayerPrefs.SetInt("ThemeCount",ThemeCount);
            PlayerPrefs.SetInt("purharesPyramids",purharesPyramids);

            UnLock_Audio.Play();
        }
        else
        Eror_Audio.Play();
    }

    public void PurchaseDesert()
    {
        if (Gold >= priceDesert)
        {
            Gold -= priceDesert;
            purharesDesert = 1;
            ThemeCount += 1;
            UnlockedDesert_Shop.SetActive(true);
            UnlockedDesert_Theme.SetActive(false);

            PlayerPrefs.SetInt("Gold",Gold);
            PlayerPrefs.SetInt("ThemeCount",ThemeCount);
            PlayerPrefs.SetInt("purharesDesert",purharesDesert);

            UnLock_Audio.Play();
        }
        else
        Eror_Audio.Play();
    }

    public void PurchaseSnow()
    {
        if (Gems >= priceSnow)
        {
            Gems -= priceSnow;
            purharesSnow = 1;
            ThemeCount += 1;
            UnlockedSnow_Shop.SetActive(true);
            UnlockedSnow_Theme.SetActive(false);

            PlayerPrefs.SetInt("Gems",Gems);
            PlayerPrefs.SetInt("ThemeCount",ThemeCount);
            PlayerPrefs.SetInt("purharesSnow",purharesSnow);

            UnLock_Audio.Play();
        }
        else
        Eror_Audio.Play();
    }

    public void PurchaseIsland()
    {
        if (Gems >= priceIsland)
        {
            Gems -= priceIsland;
            purharesIsland = 1;
            ThemeCount += 1;
            UnlockedIsland_Shop.SetActive(true);
            UnlockedIsland_Theme.SetActive(false);

            PlayerPrefs.SetInt("Gems",Gems);
            PlayerPrefs.SetInt("ThemeCount",ThemeCount);
            PlayerPrefs.SetInt("purharesIsland",purharesIsland);

            UnLock_Audio.Play();
        }
        else
        Eror_Audio.Play();
    }

    public void PurchaseVolcano()
    {
        if (Gems >= priceVolcano)
        {
            Gems -= priceVolcano;
            purharesVolcano = 1;
            ThemeCount += 1;
            UnlockedVolcano_Shop.SetActive(true);
            UnlockedVolcano_Theme.SetActive(false);

            PlayerPrefs.SetInt("Gems",Gems);
            PlayerPrefs.SetInt("ThemeCount",ThemeCount);
            PlayerPrefs.SetInt("purharesVolcano",purharesVolcano);

            UnLock_Audio.Play();
        }
        else
        Eror_Audio.Play();
    }

    public void PurchaseNightSky()
    {
        if (Gold >= priceNightSky)
        {
            Gold -= priceNightSky;
            purharesNightSky = 1;
            ThemeCount += 1;
            UnlockedNightSky_Shop.SetActive(true);
            UnlockedNightSky_Theme.SetActive(false);

            PlayerPrefs.SetInt("Gold",Gold);
            PlayerPrefs.SetInt("ThemeCount",ThemeCount);
            PlayerPrefs.SetInt("purharesNightSky",purharesNightSky);

            UnLock_Audio.Play();
        }
        else
        Eror_Audio.Play();
    }

    public void PurchaseAutumn()
    {
        if (Gems >= priceAutumn)
        {
            Gems -= priceAutumn;
            purharesAutumn = 1;
            ThemeCount += 1;
            UnlockedAutumn_Shop.SetActive(true);
            UnlockedAutumn_Theme.SetActive(false);

            PlayerPrefs.SetInt("Gems",Gems);
            PlayerPrefs.SetInt("ThemeCount",ThemeCount);
            PlayerPrefs.SetInt("purharesAutumn",purharesAutumn);

            UnLock_Audio.Play();
        }
        else
        Eror_Audio.Play();
    }

    public void PurchaseDinosaurus()
    {
        if (Gold >= priceDinosaurus)
        {
            Gold -= priceDinosaurus;
            purharesDinosaurus = 1;
            ThemeCount += 1;
            UnlockedeDinosaurus_Shop.SetActive(true);
            UnlockedeDinosaurus_Theme.SetActive(false);

            PlayerPrefs.SetInt("Gold",Gold);
            PlayerPrefs.SetInt("ThemeCount",ThemeCount);
            PlayerPrefs.SetInt("purharesDinosaurus",purharesDinosaurus);

            UnLock_Audio.Play();
        }
        else
        Eror_Audio.Play();
    }

    public void PurchaseAquarium()
    {
        if (Gems >= priceAquarium)
        {
            Gems -= priceAquarium;
            purharesAquarium = 1;
            ThemeCount += 1;
            UnlockedAquarium_Shop.SetActive(true);
            UnlockedAquarium_Theme.SetActive(false);

            PlayerPrefs.SetInt("Gems",Gems);
            PlayerPrefs.SetInt("ThemeCount",ThemeCount);
            PlayerPrefs.SetInt("purharesAquarium",purharesAquarium);

            UnLock_Audio.Play();
        }
        else
        Eror_Audio.Play();
    }

    public void PurchaseSpace()
    {
        if (Gems >= priceSpace)
        {
            Gems -= priceSpace;
            purharesSpace = 1;
            ThemeCount += 1;
            UnlockedSpace_Shop.SetActive(true);
            UnlockedSpace_Theme.SetActive(false);

            PlayerPrefs.SetInt("Gems",Gems);
            PlayerPrefs.SetInt("ThemeCount",ThemeCount);
            PlayerPrefs.SetInt("purharesSpace",purharesSpace);

            UnLock_Audio.Play();
        }
        else
        Eror_Audio.Play();
    }

    public void PurchaseRain()
    {
        if (Gold >= priceRain)
        {
            Gold -= priceRain;
            purharesRain = 1;
            ThemeCount += 1;
            UnlockedRain_Shop.SetActive(true);
            UnlockedRain_Theme.SetActive(false);

            PlayerPrefs.SetInt("Gold",Gold);
            PlayerPrefs.SetInt("ThemeCount",ThemeCount);
            PlayerPrefs.SetInt("purharesRain",purharesRain);

            UnLock_Audio.Play();
        }
        else
        Eror_Audio.Play();
    }

    public void SystemShop ()
    {
        HolidaySalesInt = PlayerPrefs.GetInt("HolidaySalesInt");

        if (purharesFlowers == 1){
            UnlockedFlowers_Shop.SetActive(true);
            UnlockedFlowers_Theme.SetActive(false);
        }
        else
        if (HolidaySalesInt == 1){
            UnlockedFlowers_Shop_Clasic.GetComponent<Image>().sprite = UnlockedFlowers_Shop_Sales;
            priceFlowers = 12;
        }

        if (purharesPyramids == 1){
            UnlockedPyramids_Shop.SetActive(true);
            UnlockedPyramids_Theme.SetActive(false);
        }
        else 
        if (HolidaySalesInt == 1){
            UnlockedPyramids_Shop_Clasic.GetComponent<Image>().sprite = UnlockedPyramids_Shop_Sales;
            pricePyramids = 49;
        }

        if (purharesDesert == 1){
            UnlockedDesert_Shop.SetActive(true);
            UnlockedDesert_Theme.SetActive(false);
        }
        else 
        if (HolidaySalesInt == 1){
            UnlockedDesert_Shop_Clasic.GetComponent<Image>().sprite = UnlockedDesert_Shop_Sales;
            priceDesert = 100000;
        }

        if (purharesSnow == 1){
            UnlockedSnow_Shop.SetActive(true);
            UnlockedSnow_Theme.SetActive(false);
        }
        else
        if (HolidaySalesInt == 1){
            UnlockedSnow_Shop_Clasic.GetComponent<Image>().sprite = UnlockedSnow_Shop_Sales;
            priceSnow = 75;
        }

        if (purharesIsland == 1){
            UnlockedIsland_Shop.SetActive(true);
            UnlockedIsland_Theme.SetActive(false);
        }
        else
        if (HolidaySalesInt == 1){
            UnlockedIsland_Shop_Clasic.GetComponent<Image>().sprite = UnlockedIsland_Shop_Sales;
            priceIsland = 49;
        }

        if (purharesVolcano == 1){
            UnlockedVolcano_Shop.SetActive(true);
            UnlockedVolcano_Theme.SetActive(false);
        }
        else
        if (HolidaySalesInt == 1){
            UnlockedVolcano_Shop_Clasic.GetComponent<Image>().sprite = UnlockedVolcano_Shop_Sales;
            priceVolcano = 29;
        }

        if (purharesNightSky == 1){
            UnlockedNightSky_Shop.SetActive(true);
            UnlockedNightSky_Theme.SetActive(false);
        }
        else
        if (HolidaySalesInt == 1){
            UnlockedNightSky_Shop_Clasic.GetComponent<Image>().sprite = UnlockedNightSky_Shop_Sales;
            priceNightSky = 125000;
        }

        if (purharesAutumn == 1){
            UnlockedAutumn_Shop.SetActive(true);
            UnlockedAutumn_Theme.SetActive(false);
        }
        else
        if (HolidaySalesInt == 1){
            UnlockedAutumn_Shop_Clasic.GetComponent<Image>().sprite = UnlockedAutumn_Shop_Sales;
            priceAutumn = 75;
        }

        if (purharesDinosaurus == 1){
            UnlockedeDinosaurus_Shop.SetActive(true);
            UnlockedeDinosaurus_Theme.SetActive(false);
        }
        else
        if (HolidaySalesInt == 1){
            UnlockedeDinosaurus_Shop_Clasic.GetComponent<Image>().sprite = UnlockedeDinosaurus_Shop_Sales;
            priceDinosaurus = 75000;
        }

        if (purharesAquarium == 1){
            UnlockedAquarium_Shop.SetActive(true);
            UnlockedAquarium_Theme.SetActive(false);
        }
        else
        if (HolidaySalesInt == 1){
            UnlockedAquarium_Shop_Clasic.GetComponent<Image>().sprite = UnlockedAquarium_Shop_Sales;
            priceAquarium = 49;
        }

        if (purharesSpace == 1){
            UnlockedSpace_Shop.SetActive(true);
            UnlockedSpace_Theme.SetActive(false);
        }
        else
        if (HolidaySalesInt == 1){
            UnlockedSpace_Shop_Clasic.GetComponent<Image>().sprite = UnlockedSpace_Shop_Sales;
            priceSpace = 29;
        }

        if (purharesRain == 1){
            UnlockedRain_Shop.SetActive(true);
            UnlockedRain_Theme.SetActive(false);
        }
        else
        if (HolidaySalesInt == 1){
            UnlockedRain_Shop_Clasic.GetComponent<Image>().sprite = UnlockedRain_Shop_Sales;
            priceRain = 49999;
        }

        if (ThemeInt == 0)
        {
            if (OwnedField_Button == true)
            {
                for(int x = 0;x < OwnedObjects.Count;x++){
                OwnedObjects[x].SetActive(false);
                }

                OwnedField_Button.SetActive(true);
            }
        }
        if (ThemeInt == 1)
        {
            if (OwnedFlowers_Button == true)
            {
                for(int x = 0;x < OwnedObjects.Count;x++){
                OwnedObjects[x].SetActive(false);
                }

                OwnedFlowers_Button.SetActive(true);
            }
        }
        if (ThemeInt == 2)
        {
            if (OwnedField_Button == true)
            {
                for(int x = 0;x < OwnedObjects.Count;x++){
                OwnedObjects[x].SetActive(false);
                }

                OwnedPyramids_Button.SetActive(true);
            }
        }
        if (ThemeInt == 3)
        {
            if (OwnedField_Button == true)
            {
                for(int x = 0;x < OwnedObjects.Count;x++){
                OwnedObjects[x].SetActive(false);
                }

                OwnedDesert_Button.SetActive(true);
            }
        }
        if (ThemeInt == 4)
        {
            if (OwnedField_Button == true)
            {
                for(int x = 0;x < OwnedObjects.Count;x++){
                OwnedObjects[x].SetActive(false);
                }

                OwnedSnow_Button.SetActive(true);
            }
        }
        if (ThemeInt == 5)
        {
            if (OwnedField_Button == true)
            {
                for(int x = 0;x < OwnedObjects.Count;x++){
                OwnedObjects[x].SetActive(false);
                }

                OwnedIsland_Button.SetActive(true);
            }
        }
        if (ThemeInt == 6)
        {
            if (OwnedField_Button == true)
            {
                for(int x = 0;x < OwnedObjects.Count;x++){
                OwnedObjects[x].SetActive(false);
                }

                OwnedVolcano_Button.SetActive(true);
            }
        }
        if (ThemeInt == 7)
        {
            if (OwnedField_Button == true)
            {
                for(int x = 0;x < OwnedObjects.Count;x++){
                OwnedObjects[x].SetActive(false);
                }

                OwnedNightSky_Button.SetActive(true);
            }
        }
        if (ThemeInt == 8)
        {
            if (OwnedField_Button == true)
            {
                for(int x = 0;x < OwnedObjects.Count;x++){
                OwnedObjects[x].SetActive(false);
                }

                OwnedAutumn_Button.SetActive(true);
            }
        }
        if (ThemeInt == 9)
        {
            if (OwnedField_Button == true)
            {
                for(int x = 0;x < OwnedObjects.Count;x++){
                OwnedObjects[x].SetActive(false);
                }

                OwnedeDinosaurus_Button.SetActive(true);
            }
        }
        if (ThemeInt == 10)
        {
            if (OwnedField_Button == true)
            {
                for(int x = 0;x < OwnedObjects.Count;x++){
                OwnedObjects[x].SetActive(false);
                }

                OwnedAquarium_Button.SetActive(true);
            }
        }
        if (ThemeInt == 11)
        {
            if (OwnedField_Button == true)
            {
                for(int x = 0;x < OwnedObjects.Count;x++){
                OwnedObjects[x].SetActive(false);
                }

                OwnedSpace_Button.SetActive(true);
            }
        }
        if (ThemeInt == 12)
        {
            if (OwnedField_Button == true)
            {
                for(int x = 0;x < OwnedObjects.Count;x++){
                OwnedObjects[x].SetActive(false);
                }

                OwnedRain_Button.SetActive(true);
            }
        }
    }

    public void InventoryTimer ()
    {
        InventoryTimerInt = 1;
    }

    public void ThemeWinSpin ()
    {
        purharesFlowers = PlayerPrefs.GetInt("purharesFlowers");
        purharesPyramids = PlayerPrefs.GetInt("purharesPyramids");
        purharesDesert = PlayerPrefs.GetInt("purharesDesert");
        purharesSnow = PlayerPrefs.GetInt("purharesSnow");
        purharesIsland = PlayerPrefs.GetInt("purharesIsland");
        purharesVolcano = PlayerPrefs.GetInt("purharesVolcano");
        purharesNightSky = PlayerPrefs.GetInt("purharesNightSky");
        purharesAutumn = PlayerPrefs.GetInt("purharesAutumn");
        purharesDinosaurus = PlayerPrefs.GetInt("purharesDinosaurus");
        purharesAquarium = PlayerPrefs.GetInt("purharesAquarium");
        purharesSpace = PlayerPrefs.GetInt("purharesSpace");
        purharesRain = PlayerPrefs.GetInt("purharesRain");

        float random = Random.Range(1, 13);

            // everything is bought
            if (purharesFlowers == 1 && purharesPyramids == 1 && purharesDesert == 1 && purharesSnow == 1 && purharesIsland == 1 && purharesVolcano == 1 && purharesNightSky == 1 && purharesAutumn == 1 && purharesDinosaurus == 1 && purharesAquarium == 1 && purharesSpace == 1 && purharesRain == 1)
            {
                random = 0; 
            }

            if (random == 1){
            if (purharesFlowers == 0){

                purharesFlowers = 1;
                ThemeCount += 1;
                PlayerPrefs.SetInt("ThemeCount",ThemeCount);
                PlayerPrefs.SetInt("purharesFlowers",purharesFlowers);

                SystemShop();

                // Start inventory timer
                if (InventoryTimerInt == 1)
                {
                    InvScript.StartFlowers();
                    InventoryTimerInt = 0;
                }

            }
            else
            ThemeWinSpin();
            }

            if (random == 2){
            if (purharesPyramids == 0){
                
                purharesPyramids = 1;
                ThemeCount += 1;
                PlayerPrefs.SetInt("ThemeCount",ThemeCount);
                PlayerPrefs.SetInt("purharesPyramids",purharesPyramids);

                SystemShop();

                // Start inventory timer
                if (InventoryTimerInt == 1)
                {
                    InvScript.StartPyramids();
                    InventoryTimerInt = 0;
                }

            }
            else
            ThemeWinSpin();
            }

            if (random == 3){
            if (purharesDesert == 0){
                
                purharesDesert = 1;
                ThemeCount += 1;
                PlayerPrefs.SetInt("ThemeCount",ThemeCount);
                PlayerPrefs.SetInt("purharesDesert",purharesDesert);

                SystemShop();

                // Start inventory timer
                if (InventoryTimerInt == 1)
                {
                    InvScript.StartDesert();
                    InventoryTimerInt = 0;
                }

            }
            else
            ThemeWinSpin();
            }

            if (random == 4){
            if (purharesSnow == 0){

                purharesSnow = 1;
                ThemeCount += 1;
                PlayerPrefs.SetInt("ThemeCount",ThemeCount);
                PlayerPrefs.SetInt("purharesSnow",purharesSnow);

                SystemShop();

                // Start inventory timer
                if (InventoryTimerInt == 1)
                {
                    InvScript.StartSnow();
                    InventoryTimerInt = 0;
                }

            }
            else
            ThemeWinSpin();
            }

            if (random == 5){
            if (purharesIsland == 0){
                
                purharesIsland = 1;
                ThemeCount += 1;
                PlayerPrefs.SetInt("ThemeCount",ThemeCount);
                PlayerPrefs.SetInt("purharesIsland",purharesIsland);

                SystemShop();

                // Start inventory timer
                if (InventoryTimerInt == 1)
                {
                    InvScript.StartIsland();
                    InventoryTimerInt = 0;
                }

            }
            else
            ThemeWinSpin();
            }

            if (random == 6){
            if (purharesVolcano == 0){
                
                purharesVolcano = 1;
                ThemeCount += 1;
                PlayerPrefs.SetInt("ThemeCount",ThemeCount);
                PlayerPrefs.SetInt("purharesVolcano",purharesVolcano);

                SystemShop();

                // Start inventory timer
                if (InventoryTimerInt == 1)
                {
                    InvScript.StartVolcano();
                    InventoryTimerInt = 0;
                }

            }
            else
            ThemeWinSpin();
            }

            if (random == 7){
            if (purharesNightSky == 0){
                
                purharesNightSky = 1;
                ThemeCount += 1;
                PlayerPrefs.SetInt("ThemeCount",ThemeCount);
                PlayerPrefs.SetInt("purharesNightSky",purharesNightSky);

                SystemShop();

                // Start inventory timer
                if (InventoryTimerInt == 1)
                {
                    InvScript.StartNightSky();
                    InventoryTimerInt = 0;
                }

            }
            else
            ThemeWinSpin();
            }

            if (random == 8){
            if (purharesAutumn == 0){
                
                purharesAutumn = 1;
                ThemeCount += 1;
                PlayerPrefs.SetInt("ThemeCount",ThemeCount);
                PlayerPrefs.SetInt("purharesAutumn",purharesAutumn);

                SystemShop();

                // Start inventory timer
                if (InventoryTimerInt == 1)
                {
                    InvScript.StartAutumn();
                    InventoryTimerInt = 0;
                }

            }
            else
            ThemeWinSpin();
            }

            if (random == 9){
            if (purharesDinosaurus == 0){
                
                purharesDinosaurus = 1;
                ThemeCount += 1;
                PlayerPrefs.SetInt("ThemeCount",ThemeCount);
                PlayerPrefs.SetInt("purharesDinosaurus",purharesDinosaurus);

                SystemShop();

                // Start inventory timer
                if (InventoryTimerInt == 1)
                {
                    InvScript.StartDinosaurus();
                    InventoryTimerInt = 0;
                }

            }
            else
            ThemeWinSpin();
            }

            if (random == 10){
            if (purharesAquarium == 0){
                
                purharesAquarium = 1;
                ThemeCount += 1;
                PlayerPrefs.SetInt("ThemeCount",ThemeCount);
                PlayerPrefs.SetInt("purharesAquarium",purharesAquarium);

                SystemShop();

                // Start inventory timer
                if (InventoryTimerInt == 1)
                {
                    InvScript.StartAquarium();
                    InventoryTimerInt = 0;
                }

            }
            else
            ThemeWinSpin();
            }

            if (random == 11){
            if (purharesSpace == 0){
                
                purharesSpace = 1;
                ThemeCount += 1;
                PlayerPrefs.SetInt("ThemeCount",ThemeCount);
                PlayerPrefs.SetInt("purharesSpace",purharesSpace);

                SystemShop();

                // Start inventory timer
                if (InventoryTimerInt == 1)
                {
                    InvScript.StartSpace();
                    InventoryTimerInt = 0;
                }

            }
            else
            ThemeWinSpin();
            }
            
            if (random == 12){            
            if (purharesRain == 0){
                
                purharesRain = 1;
                ThemeCount += 1;
                PlayerPrefs.SetInt("ThemeCount",ThemeCount);
                PlayerPrefs.SetInt("purharesRain",purharesRain);

                SystemShop();

                // Start inventory timer
                if (InventoryTimerInt == 1)
                {
                    InvScript.StartRain();
                    InventoryTimerInt = 0;
                }

            }
            else
            ThemeWinSpin();
            }
    }

    public void TimerBonusThemeFlowerLeft ()
    {
        purharesFlowers = 0;
        ThemeCount -= 1;
        PlayerPrefs.SetInt("ThemeCount",ThemeCount);
        PlayerPrefs.SetInt("purharesFlowers",purharesFlowers);

        OwnedField_Button.SetActive(true);
        ThemeInt = 0;
        PlayerPrefs.SetInt("ThemeInt",ThemeInt);
        SystemShop();
    }

    public void TimerBonusThemePyramidsLeft ()
    {
        purharesPyramids = 0;
        ThemeCount -= 1;
        PlayerPrefs.SetInt("ThemeCount",ThemeCount);
        PlayerPrefs.SetInt("purharesPyramids",purharesPyramids);

        OwnedField_Button.SetActive(true);
        ThemeInt = 0;
        PlayerPrefs.SetInt("ThemeInt",ThemeInt);
        SystemShop();
    }

    public void TimerBonusThemeDesertLeft ()
    {
        purharesDesert = 0;
        ThemeCount -= 1;
        PlayerPrefs.SetInt("ThemeCount",ThemeCount);
        PlayerPrefs.SetInt("purharesDesert",purharesDesert);

        OwnedField_Button.SetActive(true);
        ThemeInt = 0;
        PlayerPrefs.SetInt("ThemeInt",ThemeInt);
        SystemShop();
    }

    public void TimerBonusThemeSnowLeft ()
    {
        purharesSnow = 0;
        ThemeCount -= 1;
        PlayerPrefs.SetInt("ThemeCount",ThemeCount);
        PlayerPrefs.SetInt("purharesSnow",purharesSnow);

        OwnedField_Button.SetActive(true);
        ThemeInt = 0;
        PlayerPrefs.SetInt("ThemeInt",ThemeInt);
        SystemShop();
    }

    public void TimerBonusThemeIslandLeft ()
    {
        purharesIsland = 0;
        ThemeCount -= 1;
        PlayerPrefs.SetInt("ThemeCount",ThemeCount);
        PlayerPrefs.SetInt("purharesIsland",purharesIsland);

        OwnedField_Button.SetActive(true);
        ThemeInt = 0;
        PlayerPrefs.SetInt("ThemeInt",ThemeInt);
        SystemShop();
    }

    public void TimerBonusThemeVolcanoLeft ()
    {
        purharesVolcano = 0;
        ThemeCount -= 1;
        PlayerPrefs.SetInt("ThemeCount",ThemeCount);
        PlayerPrefs.SetInt("purharesVolcano",purharesVolcano);

        OwnedField_Button.SetActive(true);
        ThemeInt = 0;
        PlayerPrefs.SetInt("ThemeInt",ThemeInt);
        SystemShop();
    }

    public void TimerBonusThemeNightSkyLeft ()
    {
        purharesNightSky = 0;
        ThemeCount -= 1;
        PlayerPrefs.SetInt("ThemeCount",ThemeCount);
        PlayerPrefs.SetInt("purharesNightSky",purharesNightSky);

        OwnedField_Button.SetActive(true);
        ThemeInt = 0;
        PlayerPrefs.SetInt("ThemeInt",ThemeInt);
        SystemShop();
    }

    public void TimerBonusThemeAutumnLeft ()
    {
        purharesAutumn = 0;
        ThemeCount -= 1;
        PlayerPrefs.SetInt("ThemeCount",ThemeCount);
        PlayerPrefs.SetInt("purharesAutumn",purharesAutumn);

        OwnedField_Button.SetActive(true);
        ThemeInt = 0;
        PlayerPrefs.SetInt("ThemeInt",ThemeInt);
        SystemShop();
    }

    public void TimerBonusThemeDinosaurusLeft ()
    { 
        purharesDinosaurus = 0;
        ThemeCount -= 1;
        PlayerPrefs.SetInt("ThemeCount",ThemeCount);
        PlayerPrefs.SetInt("purharesDinosaurus",purharesDinosaurus);

        OwnedField_Button.SetActive(true);
        ThemeInt = 0;
        PlayerPrefs.SetInt("ThemeInt",ThemeInt);
        SystemShop();
    }

    public void TimerBonusThemeAquariumLeft ()
    {
        purharesAquarium = 0;
        ThemeCount -= 1;
        PlayerPrefs.SetInt("ThemeCount",ThemeCount);
        PlayerPrefs.SetInt("purharesAquarium",purharesAquarium);

        OwnedField_Button.SetActive(true);
        ThemeInt = 0;
        PlayerPrefs.SetInt("ThemeInt",ThemeInt);
        SystemShop();
    }

    public void TimerBonusThemeSpaceLeft ()
    {
        purharesSpace = 0;
        ThemeCount -= 1;
        PlayerPrefs.SetInt("ThemeCount",ThemeCount);
        PlayerPrefs.SetInt("purharesSpace",purharesSpace);

        OwnedField_Button.SetActive(true);
        ThemeInt = 0;
        PlayerPrefs.SetInt("ThemeInt",ThemeInt);
        SystemShop();
    }

    public void TimerBonusThemeRainLeft ()
    {
        purharesRain = 0;
        ThemeCount -= 1;
        PlayerPrefs.SetInt("ThemeCount",ThemeCount);
        PlayerPrefs.SetInt("purharesRain",purharesRain);

        OwnedField_Button.SetActive(true);
        ThemeInt = 0;
        PlayerPrefs.SetInt("ThemeInt",ThemeInt);
        SystemShop();
    }

    private void Update()
    {
        ThemeInt = PlayerPrefs.GetInt("ThemeInt");
        Gems = PlayerPrefs.GetInt("Gems");
        Gold = PlayerPrefs.GetInt("Gold");

        ThemeCount = PlayerPrefs.GetInt("ThemeCount");
        ThemeCountText.text = ThemeCount.ToString() + "/13";
    }
}
