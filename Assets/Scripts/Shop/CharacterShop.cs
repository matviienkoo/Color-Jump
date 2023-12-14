using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterShop : MonoBehaviour
{
    public List<GameObject> OwnedObjects;
    private int InventoryTimerInt;

    [Header("Gold Gems")]
    [SerializeField] int Gold;
    [SerializeField] int Gems;
    [SerializeField] int CharacterInt;

    [SerializeField] int CharacterCount;
    [SerializeField] TextMeshProUGUI CharacterCountText;

    [Header("Ball")]
    [SerializeField] GameObject OwnedBall_Button;

    [Header("Star")]
    [SerializeField] int priceStar;
    [SerializeField] int purharesStar;
    [SerializeField] GameObject UnlockedStar_Shop;
    [SerializeField] GameObject UnlockedStar_Theme;
    [SerializeField] GameObject OwnedStar_Button;

    [SerializeField] Sprite UnlockedStar_Shop_Sales;
    [SerializeField] GameObject UnlockedStar_Shop_Clasic;

    [Header("CupCake")]
    [SerializeField] int priceCupcake;
    [SerializeField] int purharesCupcake;
    [SerializeField] GameObject UnlockedCupcake_Shop;
    [SerializeField] GameObject UnlockedCupcake_Theme;
    [SerializeField] GameObject OwnedCupcake_Button;

    [SerializeField] Sprite UnlockedCupcake_Shop_Sales;
    [SerializeField] GameObject UnlockedCupcake_Shop_Clasic;

    [Header("Heart")]
    [SerializeField] int priceHeart;
    [SerializeField] int purharesHeart;
    [SerializeField] GameObject UnlockedHeart_Shop;
    [SerializeField] GameObject UnlockedHeart_Theme;
    [SerializeField] GameObject OwnedHeart_Button;

    [SerializeField] Sprite UnlockedHeart_Shop_Sales;
    [SerializeField] GameObject UnlockedHeart_Shop_Clasic;

    [Header("Crab")]
    [SerializeField] int priceCrab;
    [SerializeField] int purharesCrab;
    [SerializeField] GameObject UnlockedCrab_Shop;
    [SerializeField] GameObject UnlockedCrab_Theme;
    [SerializeField] GameObject OwnedCrab_Button;

    [SerializeField] Sprite UnlockedCrab_Shop_Sales;
    [SerializeField] GameObject UnlockedCrab_Shop_Clasic;

    [Header("Ballon")]
    [SerializeField] int priceBalloon;
    [SerializeField] int purharesBallon;
    [SerializeField] GameObject UnlockedBalloon_Shop;
    [SerializeField] GameObject UnlockedBalloon_Theme;
    [SerializeField] GameObject OwnedBalloon_Button;

    [SerializeField] Sprite UnlockedBalloon_Shop_Sales;
    [SerializeField] GameObject UnlockedBalloon_Shop_Clasic;

    [Header("Ghost")]
    [SerializeField] int priceGhost;
    [SerializeField] int purharesGhost;
    [SerializeField] GameObject UnlockedGhost_Shop;
    [SerializeField] GameObject UnlockedGhost_Theme;
    [SerializeField] GameObject OwnedGhost_Button;

    [SerializeField] Sprite UnlockedGhost_Shop_Sales;
    [SerializeField] GameObject UnlockedGhost_Shop_Clasic;

    [Header("Squid")]
    [SerializeField] int priceSquid;
    [SerializeField] int purharesSquid;
    [SerializeField] GameObject UnlockedSquid_Shop;
    [SerializeField] GameObject UnlockedSquid_Theme;
    [SerializeField] GameObject OwnedSquid_Button;

    [SerializeField] Sprite UnlockedSquid_Shop_Sales;
    [SerializeField] GameObject UnlockedSquid_Shop_Clasic;

    [Header("Flame")]
    [SerializeField] int priceFlame;
    [SerializeField] int purharesFlame;
    [SerializeField] GameObject UnlockedFlame_Shop;
    [SerializeField] GameObject UnlockedFlame_Theme;
    [SerializeField] GameObject OwnedFlame_Button;

    [SerializeField] Sprite UnlockedFlame_Shop_Sales;
    [SerializeField] GameObject UnlockedFlame_Shop_Clasic;

    [Header("Strawberry")]
    [SerializeField] int priceStrawberry;
    [SerializeField] int purharesStrawberry;
    [SerializeField] GameObject UnlockedStrawberry_Shop;
    [SerializeField] GameObject UnlockedStrawberry_Theme;
    [SerializeField] GameObject OwnedStrawberry_Button;

    [SerializeField] Sprite UnlockedStrawberry_Shop_Sales;
    [SerializeField] GameObject UnlockedStrawberry_Shop_Clasic;

    [Header("Head")]
    [SerializeField] int priceHead;
    [SerializeField] int purharesHead;
    [SerializeField] GameObject UnlockedHead_Shop;
    [SerializeField] GameObject UnlockedHead_Theme;
    [SerializeField] GameObject OwnedHead_Button;

    [SerializeField] Sprite UnlockedHead_Shop_Sales;
    [SerializeField] GameObject UnlockedHead_Shop_Clasic;

    [Header("Slime")]
    [SerializeField] int priceSlime;
    [SerializeField] int purharesSlime;
    [SerializeField] GameObject UnlockedSlime_Shop;
    [SerializeField] GameObject UnlockedSlime_Theme;
    [SerializeField] GameObject OwnedSlime_Button;

    [SerializeField] Sprite UnlockedSlime_Shop_Sales;
    [SerializeField] GameObject UnlockedSlime_Shop_Clasic;

    [Header("Bunny")]
    [SerializeField] int priceBunny;
    [SerializeField] int purharesBunny;
    [SerializeField] GameObject UnlockedBunny_Shop;
    [SerializeField] GameObject UnlockedBunny_Theme;
    [SerializeField] GameObject OwnedBunny_Button;

    [SerializeField] Sprite UnlockedBunny_Shop_Sales;
    [SerializeField] GameObject UnlockedBunny_Shop_Clasic;

    [Header("Mushroom")]
    [SerializeField] int priceMushroom;
    [SerializeField] int purharesMushroom;
    [SerializeField] GameObject UnlockedMushroom_Shop;
    [SerializeField] GameObject UnlockedMushroom_Theme;
    [SerializeField] GameObject OwnedMushroom_Button;

    [SerializeField] Sprite UnlockedMushroom_Shop_Sales;
    [SerializeField] GameObject UnlockedMushroom_Shop_Clasic;

    [Header("IceCream")]
    [SerializeField] int priceIceCream;
    [SerializeField] int purharesIceCream;
    [SerializeField] GameObject UnlockedIceCream_Shop;
    [SerializeField] GameObject UnlockedIceCream_Theme;
    [SerializeField] GameObject OwnedIceCream_Button;

    [SerializeField] Sprite UnlockedIceCream_Shop_Sales;
    [SerializeField] GameObject UnlockedIceCream_Shop_Clasic;

    [Header("Bear")]
    [SerializeField] int priceBear;
    [SerializeField] int purharesBear;
    [SerializeField] GameObject UnlockedBear_Shop;
    [SerializeField] GameObject UnlockedBear_Theme;
    [SerializeField] GameObject OwnedBear_Button;

    [SerializeField] Sprite UnlockedBear_Shop_Sales;
    [SerializeField] GameObject UnlockedBear_Shop_Clasic;

    [Header("Flower")]
    [SerializeField] int priceFlower;
    [SerializeField] int purharesFlower;
    [SerializeField] GameObject UnlockedFlower_Shop;
    [SerializeField] GameObject UnlockedFlower_Theme;
    [SerializeField] GameObject OwnedFlower_Button;

    [SerializeField] Sprite UnlockedFlower_Shop_Sales;
    [SerializeField] GameObject UnlockedFlower_Shop_Clasic;

    [Header("Jellyfish")]
    [SerializeField] int priceJellyfish;
    [SerializeField] int purharesJellyfish;
    [SerializeField] GameObject UnlockedJellyfish_Shop;
    [SerializeField] GameObject UnlockedJellyfish_Theme;
    [SerializeField] GameObject OwnedJellyfish_Button;

    [SerializeField] Sprite UnlockedJellyfish_Shop_Sales;
    [SerializeField] GameObject UnlockedJellyfish_Shop_Clasic;

    [Header("Sales")]
    public int HolidaySalesInt;

    [Header("Script")]
    public InventoryScript InvScript;

    [Header("AudioCharacter")]
    public AudioSource UnLock_Audio;
    public AudioSource Eror_Audio;

    private void Start ()
    {
        CharacterInt = PlayerPrefs.GetInt("CharacterInt");
        CharacterCount = PlayerPrefs.GetInt("CharacterCount");
        HolidaySalesInt = PlayerPrefs.GetInt("HolidaySalesInt");

        purharesStar = PlayerPrefs.GetInt("purharesStar");
        purharesCupcake = PlayerPrefs.GetInt("purharesCupcake");
        purharesHeart = PlayerPrefs.GetInt("purharesHeart");
        purharesBallon = PlayerPrefs.GetInt("purharesBallon");
        purharesCrab = PlayerPrefs.GetInt("purharesCrab");
        purharesGhost = PlayerPrefs.GetInt("purharesGhost");
        purharesSquid = PlayerPrefs.GetInt("purharesSquid");
        purharesFlame = PlayerPrefs.GetInt("purharesFlame");
        purharesStrawberry = PlayerPrefs.GetInt("purharesStrawberry");
        purharesHead = PlayerPrefs.GetInt("purharesHead");
        purharesSlime = PlayerPrefs.GetInt("purharesSlime");
        purharesBunny = PlayerPrefs.GetInt("purharesBunny");
        purharesMushroom = PlayerPrefs.GetInt("purharesMushroom");
        purharesIceCream = PlayerPrefs.GetInt("purharesIceCream");
        purharesBear = PlayerPrefs.GetInt("purharesBear");
        purharesFlower = PlayerPrefs.GetInt("purharesFlower");
        purharesJellyfish = PlayerPrefs.GetInt("purharesJellyfish");

        if (CharacterCount == 0)
        {
            CharacterCount = 1;
            PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
        }
        SystemShop();
    }

    public void SelectedBall()
    {
        CharacterInt = 0;
        PlayerPrefs.SetInt("CharacterInt",CharacterInt);

        SystemShop();
    }
    public void SelectedStar()
    {
        CharacterInt = 1;
        PlayerPrefs.SetInt("CharacterInt",CharacterInt);

        SystemShop();
    }
    public void SelectedCupcake()
    {
        CharacterInt = 2;
        PlayerPrefs.SetInt("CharacterInt",CharacterInt);

        SystemShop();
    }
    public void SelectedHeart()
    {
        CharacterInt = 3;
        PlayerPrefs.SetInt("CharacterInt",CharacterInt);

        SystemShop();
    }
    public void SelectedCrab()
    {
        CharacterInt = 4;
        PlayerPrefs.SetInt("CharacterInt",CharacterInt);

        SystemShop();
    }
    public void SelectedBalloon()
    {
        CharacterInt = 5;
        PlayerPrefs.SetInt("CharacterInt",CharacterInt);

        SystemShop();
    }
    public void SelectedGhost()
    {
        CharacterInt = 6;
        PlayerPrefs.SetInt("CharacterInt",CharacterInt);

        SystemShop();
    }
    public void SelectedSquid()
    {
        CharacterInt = 7;
        PlayerPrefs.SetInt("CharacterInt",CharacterInt);

        SystemShop();
    }
    public void SelectedFlame()
    {
        CharacterInt = 8;
        PlayerPrefs.SetInt("CharacterInt",CharacterInt);

        SystemShop();
    }
    public void SelectedStrawberry()
    {
        CharacterInt = 9;
        PlayerPrefs.SetInt("CharacterInt",CharacterInt);

        SystemShop();
    }
    public void SelectedHead()
    {
        CharacterInt = 10;
        PlayerPrefs.SetInt("CharacterInt",CharacterInt);

        SystemShop();
    }
    public void SelectedSlime()
    {
        CharacterInt = 11;
        PlayerPrefs.SetInt("CharacterInt",CharacterInt);

        SystemShop();
    }
    public void SelectedBunny()
    {
        CharacterInt = 12;
        PlayerPrefs.SetInt("CharacterInt",CharacterInt);

        SystemShop();
    }
    public void SelectedMushroom()
    {
        CharacterInt = 13;
        PlayerPrefs.SetInt("CharacterInt",CharacterInt);

        SystemShop();
    }
    public void SelectedIceCream()
    {
        CharacterInt = 14;
        PlayerPrefs.SetInt("CharacterInt",CharacterInt);

        SystemShop();
    }
    public void SelectedBear()
    {
        CharacterInt = 15;
        PlayerPrefs.SetInt("CharacterInt",CharacterInt);

        SystemShop();
    }
    public void SelectedFlower()
    {
        CharacterInt = 16;
        PlayerPrefs.SetInt("CharacterInt",CharacterInt);

        SystemShop();
    }
    public void SelectedJellyfish()
    {
        CharacterInt = 17;
        PlayerPrefs.SetInt("CharacterInt",CharacterInt);

        SystemShop();
    }

    public void PurchaseStar()
    {
        if (Gold >= priceStar)
        {
            Gold -= priceStar;
            purharesStar = 1;
            CharacterCount += 1;
            UnlockedStar_Shop.SetActive(true);
            UnlockedStar_Theme.SetActive(false);

            PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
            PlayerPrefs.SetInt("purharesStar", purharesStar); 
            PlayerPrefs.SetInt("Gold",Gold);

            UnLock_Audio.Play();
        }  
        else
        Eror_Audio.Play();
    }
    public void PurchaseCupcake()
    {
        if (Gems >= priceCupcake)
        {
            Gems -= priceCupcake;
            purharesCupcake = 1;
            CharacterCount += 1;
            UnlockedCupcake_Shop.SetActive(true);
            UnlockedCupcake_Theme.SetActive(false);

            PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
            PlayerPrefs.SetInt("purharesCupcake", purharesCupcake); 
            PlayerPrefs.SetInt("Gems",Gems);

            UnLock_Audio.Play();
        }
        else
        Eror_Audio.Play();
    }
    public void PurchaseHeart()
    {
        if (Gold >= priceHeart)
        {
            Gold -= priceHeart;
            purharesHeart = 1;
            CharacterCount += 1;
            UnlockedHeart_Shop.SetActive(true);
            UnlockedHeart_Theme.SetActive(false);

            PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
            PlayerPrefs.SetInt("purharesHeart", purharesHeart); 
            PlayerPrefs.SetInt("Gold",Gold);

            UnLock_Audio.Play();
        }
        else
        Eror_Audio.Play();
    }
    public void PurchaseCrab()
    {
        if (Gems >= priceCrab)
        {
            Gems -= priceCrab;
            purharesCrab = 1;
            CharacterCount += 1;
            UnlockedCrab_Shop.SetActive(true);
            UnlockedCrab_Theme.SetActive(false);

            PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
            PlayerPrefs.SetInt("purharesCrab", purharesCrab); 
            PlayerPrefs.SetInt("Gems",Gems);

            UnLock_Audio.Play();
        }
        else
        Eror_Audio.Play();
    }
    public void PurchaseBalloon()
    {
        if (Gold >= priceBalloon)
        {
            Gold -= priceBalloon;
            purharesBallon = 1;
            CharacterCount += 1;
            UnlockedBalloon_Shop.SetActive(true);
            UnlockedBalloon_Theme.SetActive(false);

            PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
            PlayerPrefs.SetInt("purharesBallon", purharesBallon); 
            PlayerPrefs.SetInt("Gold",Gold);

            UnLock_Audio.Play();
        }
        else
        Eror_Audio.Play();
    }
    public void PurchaseGhost()
    {
        if (Gems >= priceGhost)
        {
            Gems -= priceGhost;
            purharesGhost = 1;
            CharacterCount += 1;
            UnlockedGhost_Shop.SetActive(true);
            UnlockedGhost_Theme.SetActive(false);

            PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
            PlayerPrefs.SetInt("purharesGhost", purharesGhost); 
            PlayerPrefs.SetInt("Gems",Gems);

            UnLock_Audio.Play();
        }
        else
        Eror_Audio.Play();
    }
    public void PurchaseSquid()
    {
        if (Gems >= priceSquid)
        {
            Gems -= priceSquid;
            purharesSquid = 1;
            CharacterCount += 1;
            UnlockedSquid_Shop.SetActive(true);
            UnlockedSquid_Theme.SetActive(false);

            PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
            PlayerPrefs.SetInt("purharesSquid", purharesSquid); 
            PlayerPrefs.SetInt("Gems",Gems);

            UnLock_Audio.Play();
        }
        else
        Eror_Audio.Play();
    }
    public void PurchaseFlame()
    {
        if (Gems >= priceFlame)
        {
            Gems -= priceFlame;
            purharesFlame = 1;
            CharacterCount += 1;
            UnlockedFlame_Shop.SetActive(true);
            UnlockedFlame_Theme.SetActive(false);

            PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
            PlayerPrefs.SetInt("purharesFlame", purharesFlame); 
            PlayerPrefs.SetInt("Gems",Gems);

            UnLock_Audio.Play();
        }
        else
        Eror_Audio.Play();
    }
    public void PurchaseStrawberry()
    {
        if (Gold >= priceStrawberry)
        {
            Gold -= priceStrawberry;
            purharesStrawberry = 1;
            CharacterCount += 1;
            UnlockedStrawberry_Shop.SetActive(true);
            UnlockedStrawberry_Theme.SetActive(false);

            PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
            PlayerPrefs.SetInt("purharesStrawberry", purharesStrawberry); 
            PlayerPrefs.SetInt("Gold",Gold);

            UnLock_Audio.Play();
        }
        else
        Eror_Audio.Play();
    }
    public void PurchaseHead()
    {
        if (Gems >= priceHead)
        {
            Gems -= priceHead;
            purharesHead = 1;
            CharacterCount += 1;
            UnlockedHead_Shop.SetActive(true);
            UnlockedHead_Theme.SetActive(false);

            PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
            PlayerPrefs.SetInt("purharesHead", purharesHead); 
            PlayerPrefs.SetInt("Gems",Gems);

            UnLock_Audio.Play();
        }
        else
        Eror_Audio.Play();
    }
    public void PurchaseSlime()
    {
        if (Gems >= priceSlime)
        {
            Gems -= priceSlime;
            purharesSlime = 1;
            CharacterCount += 1;
            UnlockedSlime_Shop.SetActive(true);
            UnlockedSlime_Theme.SetActive(false);

            PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
            PlayerPrefs.SetInt("purharesSlime", purharesSlime); 
            PlayerPrefs.SetInt("Gems",Gems);

            UnLock_Audio.Play();
        }
        else
        Eror_Audio.Play();
    }
    public void PurchaseBunny()
    {
        if (Gold >= priceBunny)
        {
            Gold -= priceBunny;
            purharesBunny = 1;
            CharacterCount += 1;
            UnlockedBunny_Shop.SetActive(true);
            UnlockedBunny_Theme.SetActive(false);

            PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
            PlayerPrefs.SetInt("purharesBunny", purharesBunny); 
            PlayerPrefs.SetInt("Gold",Gold);

            UnLock_Audio.Play();
        }
        else
        Eror_Audio.Play();
    }
    public void PurchaseMushroom()
    {
        if (Gems >= priceMushroom)
        {
            Gems -= priceMushroom;
            purharesMushroom = 1;
            CharacterCount += 1;
            UnlockedMushroom_Shop.SetActive(true);
            UnlockedMushroom_Theme.SetActive(false);

            PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
            PlayerPrefs.SetInt("purharesMushroom", purharesMushroom); 
            PlayerPrefs.SetInt("Gems",Gems);

            UnLock_Audio.Play();
        }
        else
        Eror_Audio.Play();
    }
    public void PurchaseIceCream()
    {
        if (Gems >= priceIceCream)
        {
            Gems -= priceIceCream;
            purharesIceCream = 1;
            CharacterCount += 1;
            UnlockedIceCream_Shop.SetActive(true);
            UnlockedIceCream_Theme.SetActive(false);

            PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
            PlayerPrefs.SetInt("purharesIceCream", purharesIceCream); 
            PlayerPrefs.SetInt("Gems",Gems);

            UnLock_Audio.Play();
        }
        else
        Eror_Audio.Play();
    }
    public void PurchaseBear()
    {
        if (Gems >= priceBear)
        {
            Gems -= priceBear;
            purharesBear = 1;
            CharacterCount += 1;
            UnlockedBear_Shop.SetActive(true);
            UnlockedBear_Theme.SetActive(false);

            PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
            PlayerPrefs.SetInt("purharesBear", purharesBear); 
            PlayerPrefs.SetInt("Gems",Gems);

            UnLock_Audio.Play();
        }
        else
        Eror_Audio.Play();
    }
    public void PurchaseFlower()
    {
        if (Gems >= priceFlower)
        {
            Gems -= priceFlower;
            purharesFlower = 1;
            CharacterCount += 1;
            UnlockedFlower_Shop.SetActive(true);
            UnlockedFlower_Theme.SetActive(false);

            PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
            PlayerPrefs.SetInt("purharesFlower", purharesFlower); 
            PlayerPrefs.SetInt("Gems",Gems);

            UnLock_Audio.Play();
        }
        else
        Eror_Audio.Play();
    }
    public void PurchaseJellyfish()
    {
        if (Gems >= priceJellyfish)
        {
            Gems -= priceJellyfish;
            purharesJellyfish = 1;
            CharacterCount += 1;
            UnlockedJellyfish_Shop.SetActive(true);
            UnlockedJellyfish_Theme.SetActive(false);

            PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
            PlayerPrefs.SetInt("purharesJellyfish", purharesJellyfish); 
            PlayerPrefs.SetInt("Gems",Gems);

            UnLock_Audio.Play();
        }
        else
        Eror_Audio.Play();
    }

    public void SystemShop ()
    {
        HolidaySalesInt = PlayerPrefs.GetInt("HolidaySalesInt");
        
        if (purharesStar == 1){
            UnlockedStar_Shop.SetActive(true);
            UnlockedStar_Theme.SetActive(false);
        }
        else
        if (HolidaySalesInt == 1){
            UnlockedStar_Shop_Clasic.GetComponent<Image>().sprite = UnlockedStar_Shop_Sales;
            priceStar = 25000;
        }

        if (purharesCupcake == 1){
            UnlockedCupcake_Shop.SetActive(true);
            UnlockedCupcake_Theme.SetActive(false);
        }
        else
        if (HolidaySalesInt == 1){
            UnlockedCupcake_Shop_Clasic.GetComponent<Image>().sprite = UnlockedCupcake_Shop_Sales;
            priceCupcake = 12;
        }

        if (purharesHeart == 1){
            UnlockedHeart_Shop.SetActive(true);
            UnlockedHeart_Theme.SetActive(false);
        }
        else
        if (HolidaySalesInt == 1){
            UnlockedHeart_Shop_Clasic.GetComponent<Image>().sprite = UnlockedHeart_Shop_Sales;
            priceHeart = 30000;
        }

        if (purharesCrab == 1){
            UnlockedCrab_Shop.SetActive(true);
            UnlockedCrab_Theme.SetActive(false);
        }
        else
        if (HolidaySalesInt == 1){
            UnlockedCrab_Shop_Clasic.GetComponent<Image>().sprite = UnlockedCrab_Shop_Sales;
            priceCrab = 12;
        }

        if (purharesBallon == 1){
            UnlockedBalloon_Shop.SetActive(true);
            UnlockedBalloon_Theme.SetActive(false);
        }
        else
        if (HolidaySalesInt == 1){
            UnlockedBalloon_Shop_Clasic.GetComponent<Image>().sprite = UnlockedBalloon_Shop_Sales;
            priceBalloon = 40000;
        }

        if (purharesGhost == 1){
            UnlockedGhost_Shop.SetActive(true);
            UnlockedGhost_Theme.SetActive(false);
        }
        else
        if (HolidaySalesInt == 1){
            UnlockedGhost_Shop_Clasic.GetComponent<Image>().sprite = UnlockedGhost_Shop_Sales;
            priceGhost = 12;
        }

        if (purharesSquid == 1){
            UnlockedSquid_Shop.SetActive(true);
            UnlockedSquid_Theme.SetActive(false);
        }
        else
        if (HolidaySalesInt == 1){
            UnlockedSquid_Shop_Clasic.GetComponent<Image>().sprite = UnlockedSquid_Shop_Sales;
            priceSquid = 12;
        }

        if (purharesFlame == 1){
            UnlockedFlame_Shop.SetActive(true);
            UnlockedFlame_Theme.SetActive(false);
        }
        else
        if (HolidaySalesInt == 1){
            UnlockedFlame_Shop_Clasic.GetComponent<Image>().sprite = UnlockedFlame_Shop_Sales;
            priceFlame = 12;
        }

        if (purharesStrawberry == 1){
            UnlockedStrawberry_Shop.SetActive(true);
            UnlockedStrawberry_Theme.SetActive(false);
        }
        else
        if (HolidaySalesInt == 1){
            UnlockedStrawberry_Shop_Clasic.GetComponent<Image>().sprite = UnlockedStrawberry_Shop_Sales;
            priceStrawberry = 49999;
        }

        if (purharesHead == 1){
            UnlockedHead_Shop.SetActive(true);
            UnlockedHead_Theme.SetActive(false);
        }
        else
        if (HolidaySalesInt == 1){
            UnlockedHead_Shop_Clasic.GetComponent<Image>().sprite = UnlockedHead_Shop_Sales;
            priceHead = 12;
        }

        if (purharesSlime == 1){
            UnlockedSlime_Shop.SetActive(true);
            UnlockedSlime_Theme.SetActive(false);
        }
        else
        if (HolidaySalesInt == 1){
            UnlockedSlime_Shop_Clasic.GetComponent<Image>().sprite = UnlockedSlime_Shop_Sales;
            priceSlime = 12;
        }

        if (purharesBunny == 1){
            UnlockedBunny_Shop.SetActive(true);
            UnlockedBunny_Theme.SetActive(false);
        }
        else
        if (HolidaySalesInt == 1){
            UnlockedBunny_Shop_Clasic.GetComponent<Image>().sprite = UnlockedBunny_Shop_Sales;
            priceBunny = 35000;
        }

        if (purharesMushroom == 1){
            UnlockedMushroom_Shop.SetActive(true);
            UnlockedMushroom_Theme.SetActive(false);
        }
        else
        if (HolidaySalesInt == 1){
            UnlockedMushroom_Shop_Clasic.GetComponent<Image>().sprite = UnlockedMushroom_Shop_Sales;
            priceMushroom = 12;
        }

        if (purharesIceCream == 1){
            UnlockedIceCream_Shop.SetActive(true);
            UnlockedIceCream_Theme.SetActive(false);
        }
        else
        if (HolidaySalesInt == 1){
            UnlockedIceCream_Shop_Clasic.GetComponent<Image>().sprite = UnlockedIceCream_Shop_Sales;
            priceIceCream = 12;
        }

        if (purharesBear == 1){
            UnlockedBear_Shop.SetActive(true);
            UnlockedBear_Theme.SetActive(false);
        }
        else
        if (HolidaySalesInt == 1){
            UnlockedBear_Shop_Clasic.GetComponent<Image>().sprite = UnlockedBear_Shop_Sales;
            priceBear = 12;
        }

        if (purharesFlower == 1){
            UnlockedFlower_Shop.SetActive(true);
            UnlockedFlower_Theme.SetActive(false);
        }
        else
        if (HolidaySalesInt == 1){
            UnlockedFlower_Shop_Clasic.GetComponent<Image>().sprite = UnlockedFlower_Shop_Sales;
            priceFlower = 12;
        }

        if (purharesJellyfish == 1){
            UnlockedJellyfish_Shop.SetActive(true);
            UnlockedJellyfish_Theme.SetActive(false);
        }
        else
        if (HolidaySalesInt == 1){
            UnlockedJellyfish_Shop_Clasic.GetComponent<Image>().sprite = UnlockedJellyfish_Shop_Sales;
            priceJellyfish = 12;
        }

        if (CharacterInt == 0)
        {
            if (OwnedBall_Button == true)
            {
                for(int x = 0;x < OwnedObjects.Count;x++){
                OwnedObjects[x].SetActive(false);
                }

                OwnedBall_Button.SetActive(true);
            }
        }
        if (CharacterInt == 1)
        {
            if (OwnedStar_Button == true)
            {
                for(int x = 0;x < OwnedObjects.Count;x++){
                OwnedObjects[x].SetActive(false);
                }

                OwnedStar_Button.SetActive(true);
            }
        }
        if (CharacterInt == 2)
        {
            if (OwnedCupcake_Button == true)
            {
                for(int x = 0;x < OwnedObjects.Count;x++){
                OwnedObjects[x].SetActive(false);
                }

                OwnedCupcake_Button.SetActive(true);
            }
        }
        if (CharacterInt == 3)
        {
            if (OwnedHeart_Button == true)
            {
                for(int x = 0;x < OwnedObjects.Count;x++){
                OwnedObjects[x].SetActive(false);
                }

                OwnedHeart_Button.SetActive(true);
            }
        }
        if (CharacterInt == 4)
        {
            if (OwnedCrab_Button == true)
            {
                for(int x = 0;x < OwnedObjects.Count;x++){
                OwnedObjects[x].SetActive(false);
                }

                OwnedCrab_Button.SetActive(true);
            }
        }
        if (CharacterInt == 5)
        {
            if (OwnedBalloon_Button == true)
            {
                for(int x = 0;x < OwnedObjects.Count;x++){
                OwnedObjects[x].SetActive(false);
                }

                OwnedBalloon_Button.SetActive(true);
            }
        }
        if (CharacterInt == 6)
        {
            if (OwnedGhost_Button == true)
            {
                for(int x = 0;x < OwnedObjects.Count;x++){
                OwnedObjects[x].SetActive(false);
                }

                OwnedGhost_Button.SetActive(true);
            }
        }
        if (CharacterInt == 7)
        {
            if (OwnedSquid_Button == true)
            {
                for(int x = 0;x < OwnedObjects.Count;x++){
                OwnedObjects[x].SetActive(false);
                }

                OwnedSquid_Button.SetActive(true);
            }
        }
        if (CharacterInt == 8)
        {
            if (OwnedFlame_Button == true)
            {
                for(int x = 0;x < OwnedObjects.Count;x++){
                OwnedObjects[x].SetActive(false);
                }

                OwnedFlame_Button.SetActive(true);
            }
        }
        if (CharacterInt == 9)
        {
            if (OwnedStrawberry_Button == true)
            {
                for(int x = 0;x < OwnedObjects.Count;x++){
                OwnedObjects[x].SetActive(false);
                }

                OwnedStrawberry_Button.SetActive(true);
            }
        }
        if (CharacterInt == 10)
        {
            if (OwnedHead_Button == true)
            {
                for(int x = 0;x < OwnedObjects.Count;x++){
                OwnedObjects[x].SetActive(false);
                }

                OwnedHead_Button.SetActive(true);
            }
        }
        if (CharacterInt == 11)
        {
            if (OwnedSlime_Button == true)
            {
                for(int x = 0;x < OwnedObjects.Count;x++){
                OwnedObjects[x].SetActive(false);
                }

                OwnedSlime_Button.SetActive(true);
            }
        }
        if (CharacterInt == 12)
        {
            if (OwnedBunny_Button == true)
            {
                for(int x = 0;x < OwnedObjects.Count;x++){
                OwnedObjects[x].SetActive(false);
                }

                OwnedBunny_Button.SetActive(true);
            }
        }
        if (CharacterInt == 13)
        {
            if (OwnedMushroom_Button == true)
            {
                for(int x = 0;x < OwnedObjects.Count;x++){
                OwnedObjects[x].SetActive(false);
                }

                OwnedMushroom_Button.SetActive(true);
            }
        }
        if (CharacterInt == 14)
        {
            if (OwnedIceCream_Button == true)
            {
                for(int x = 0;x < OwnedObjects.Count;x++){
                OwnedObjects[x].SetActive(false);
                }

                OwnedIceCream_Button.SetActive(true);
            }
        }
        if (CharacterInt == 15)
        {
            if (OwnedBear_Button == true)
            {
                for(int x = 0;x < OwnedObjects.Count;x++){
                OwnedObjects[x].SetActive(false);
                }

                OwnedBear_Button.SetActive(true);
            }
        }
        if (CharacterInt == 16)
        {
            if (OwnedFlower_Button == true)
            {
                for(int x = 0;x < OwnedObjects.Count;x++){
                OwnedObjects[x].SetActive(false);
                }

                OwnedFlower_Button.SetActive(true);
            }
        }
        if (CharacterInt == 17)
        {
            if (OwnedJellyfish_Button == true)
            {
                for(int x = 0;x < OwnedObjects.Count;x++){
                OwnedObjects[x].SetActive(false);
                }

                OwnedJellyfish_Button.SetActive(true);
            }
        }
    }

    public void InventoryTimer ()
    {
        InventoryTimerInt = 1;
    }

    public void CharacterWinSpin ()
    {
        purharesStar = PlayerPrefs.GetInt("purharesStar");
        purharesCupcake = PlayerPrefs.GetInt("purharesCupcake");
        purharesHeart = PlayerPrefs.GetInt("purharesHeart");
        purharesBallon = PlayerPrefs.GetInt("purharesBallon");
        purharesCupcake = PlayerPrefs.GetInt("purharesCrab");
        purharesCupcake = PlayerPrefs.GetInt("purharesGhost");
        purharesCupcake = PlayerPrefs.GetInt("purharesSquid");
        purharesCupcake = PlayerPrefs.GetInt("purharesFlame");
        purharesCupcake = PlayerPrefs.GetInt("purharesStrawberry");
        purharesCupcake = PlayerPrefs.GetInt("purharesHead");
        purharesCupcake = PlayerPrefs.GetInt("purharesSlime");
        purharesCupcake = PlayerPrefs.GetInt("purharesBunny");
        purharesCupcake = PlayerPrefs.GetInt("purharesMushroom");
        purharesCupcake = PlayerPrefs.GetInt("purharesIceCream");
        purharesCupcake = PlayerPrefs.GetInt("purharesBear");
        purharesCupcake = PlayerPrefs.GetInt("purharesFlower");
        purharesCupcake = PlayerPrefs.GetInt("purharesJellyfish");

        float random = Random.Range(1, 18);

            // everything is bought
            if (purharesStar == 1 && purharesCupcake == 1 && purharesHeart == 1 && purharesBallon == 1 && purharesCrab == 1 && purharesGhost == 1 && purharesSquid == 1 && purharesFlame == 1 && purharesStrawberry == 1 && purharesHead == 1 && purharesSlime == 1 && purharesBunny == 1 && purharesMushroom == 1 && purharesIceCream == 1 && purharesBear == 1 && purharesFlower == 1 && purharesJellyfish == 1)
            {
                random = 0; 
            }

            if (random == 1){
            if (purharesStar == 0){

                purharesStar = 1;
                CharacterCount += 1;
                PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
                PlayerPrefs.SetInt("purharesStar", purharesStar); 

                SystemShop();

                // Start inventory timer
                if (InventoryTimerInt == 1)
                {
                    InvScript.StartStar();
                    InventoryTimerInt = 0;
                }

            }
            else
            CharacterWinSpin();
            }

            if (random == 2){
            if (purharesCupcake == 0){

                purharesCupcake = 1;
                CharacterCount += 1;

                PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
                PlayerPrefs.SetInt("purharesCupcake", purharesCupcake); 

                SystemShop();

                // Start inventory timer
                if (InventoryTimerInt == 1)
                {
                    InvScript.StartCupCake();
                    InventoryTimerInt = 0;
                }
                
            }
            else
            CharacterWinSpin();
            }

            if (random == 3){
            if (purharesHeart == 0){

                purharesHeart = 1;
                CharacterCount += 1;

                PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
                PlayerPrefs.SetInt("purharesHeart", purharesHeart); 

                SystemShop();

                // Start inventory timer
                if (InventoryTimerInt == 1)
                {
                    InvScript.StartHeart();
                    InventoryTimerInt = 0;
                }
                
            }
            else
            CharacterWinSpin();
            }

            if (random == 4){
            if (purharesBallon == 0){

                purharesBallon = 1;
                CharacterCount += 1;

                PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
                PlayerPrefs.SetInt("purharesBallon", purharesBallon); 

                SystemShop();

                // Start inventory timer
                if (InventoryTimerInt == 1)
                {
                    InvScript.StartBallon();
                    InventoryTimerInt = 0;
                }
                
            }
            else
            CharacterWinSpin();
            }

            if (random == 5){
            if (purharesCrab == 0){

                purharesCrab = 1;
                CharacterCount += 1;

                PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
                PlayerPrefs.SetInt("purharesCrab", purharesCrab); 

                SystemShop();

                // Start inventory timer
                if (InventoryTimerInt == 1)
                {
                    InvScript.StartCrab();
                    InventoryTimerInt = 0;
                }
                
            }
            else
            CharacterWinSpin();
            }

            if (random == 6){
            if (purharesGhost == 0){

                purharesGhost = 1;
                CharacterCount += 1;

                PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
                PlayerPrefs.SetInt("purharesGhost", purharesGhost); 

                SystemShop();

                // Start inventory timer
                if (InventoryTimerInt == 1)
                {
                    InvScript.StartGhost();
                    InventoryTimerInt = 0;
                }
                
            }
            else
            CharacterWinSpin();
            }

            if (random == 7){
            if (purharesSquid == 0){

                purharesSquid = 1;
                CharacterCount += 1;

                PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
                PlayerPrefs.SetInt("purharesSquid", purharesSquid); 

                SystemShop();

                // Start inventory timer
                if (InventoryTimerInt == 1)
                {
                    InvScript.StartSquid();
                    InventoryTimerInt = 0;
                }
                
            }
            else
            CharacterWinSpin();
            }

            if (random == 8){
            if (purharesFlame == 0){

                purharesFlame = 1;
                CharacterCount += 1;

                PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
                PlayerPrefs.SetInt("purharesFlame", purharesFlame); 

                SystemShop();

                // Start inventory timer
                if (InventoryTimerInt == 1)
                {
                    InvScript.StartFlame();
                    InventoryTimerInt = 0;
                }
                
            }
            else
            CharacterWinSpin();
            }

            if (random == 9){
            if (purharesStrawberry == 0){

                purharesStrawberry = 1;
                CharacterCount += 1;

                PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
                PlayerPrefs.SetInt("purharesStrawberry", purharesStrawberry); 

                SystemShop();

                // Start inventory timer
                if (InventoryTimerInt == 1)
                {
                    InvScript.StartStrawbeery();
                    InventoryTimerInt = 0;
                }
                
            }
            else
            CharacterWinSpin();
            }

            if (random == 10){
            if (purharesHead == 0){

                purharesHead = 1;
                CharacterCount += 1;

                PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
                PlayerPrefs.SetInt("purharesHead", purharesHead); 

                SystemShop();

                // Start inventory timer
                if (InventoryTimerInt == 1)
                {
                    InvScript.StartHead();
                    InventoryTimerInt = 0;
                }
                
            }
            else
            CharacterWinSpin();
            }

            if (random == 11){
            if (purharesSlime == 0){

                purharesSlime = 1;
                CharacterCount += 1;

                PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
                PlayerPrefs.SetInt("purharesSlime", purharesSlime); 

                SystemShop();

                // Start inventory timer
                if (InventoryTimerInt == 1)
                {
                    InvScript.StartSlime();
                    InventoryTimerInt = 0;
                }
                
            }
            else
            CharacterWinSpin();
            }

            if (random == 12){
            if (purharesBunny == 0){

                purharesBunny = 1;
                CharacterCount += 1;

                PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
                PlayerPrefs.SetInt("purharesBunny", purharesBunny); 

                SystemShop();

                // Start inventory timer
                if (InventoryTimerInt == 1)
                {
                    InvScript.StartBunny();
                    InventoryTimerInt = 0;
                }
                
            }
            else
            CharacterWinSpin();
            }

            if (random == 13){
            if (purharesMushroom == 0){

                purharesMushroom = 1;
                CharacterCount += 1;

                PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
                PlayerPrefs.SetInt("purharesMushroom", purharesMushroom); 

                SystemShop();

                // Start inventory timer
                if (InventoryTimerInt == 1)
                {
                    InvScript.StartMushroom();
                    InventoryTimerInt = 0;
                }
                
            }
            else
            CharacterWinSpin();
            }

            if (random == 14){
            if (purharesIceCream == 0){

                purharesIceCream = 1;
                CharacterCount += 1;

                PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
                PlayerPrefs.SetInt("purharesIceCream", purharesIceCream); 

                SystemShop();

                // Start inventory timer
                if (InventoryTimerInt == 1)
                {
                    InvScript.StartIceCream();
                    InventoryTimerInt = 0;
                }
                
            }
            else
            CharacterWinSpin();
            }

            if (random == 15){
            if (purharesBear == 0){

                purharesBear = 1;
                CharacterCount += 1;

                PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
                PlayerPrefs.SetInt("purharesBear", purharesBear); 

                SystemShop();

                // Start inventory timer
                if (InventoryTimerInt == 1)
                {
                    InvScript.StartBear();
                    InventoryTimerInt = 0;
                }
                
            }
            else
            CharacterWinSpin();
            }

            if (random == 16){
            if (purharesFlower == 0){

                purharesFlower = 1;
                CharacterCount += 1;

                PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
                PlayerPrefs.SetInt("purharesFlower", purharesFlower); 

                SystemShop();

                // Start inventory timer
                if (InventoryTimerInt == 1)
                {
                    InvScript.StartFlower();
                    InventoryTimerInt = 0;
                }
                
            }
            else
            CharacterWinSpin();
            }

            if (random == 17){
            if (purharesJellyfish == 0){

                purharesJellyfish = 1;
                CharacterCount += 1;

                PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
                PlayerPrefs.SetInt("purharesJellyfish", purharesJellyfish); 

                SystemShop();

                // Start inventory timer
                if (InventoryTimerInt == 1)
                {
                    InvScript.StartJellyfish();
                    InventoryTimerInt = 0;
                }

            }
            else
            CharacterWinSpin();
            }
    }

    public void TimerBonusThemeStarLeft ()
    {
        purharesStar = 0;
        CharacterCount -= 1;
        PlayerPrefs.SetInt("CharacterCount", CharacterCount);
        PlayerPrefs.SetInt("purharesStar", purharesStar); 

        OwnedBall_Button.SetActive(true);
        CharacterInt = 0;
        PlayerPrefs.SetInt("CharacterInt",CharacterInt);
        SystemShop();
    }

    public void TimerBonusThemeCupCakeLeft ()
    {
        purharesCupcake = 0;
        CharacterCount -= 1;
        PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
        PlayerPrefs.SetInt("purharesCupcake", purharesCupcake); 
        
        OwnedBall_Button.SetActive(true);
        CharacterInt = 0;
        PlayerPrefs.SetInt("CharacterInt",CharacterInt);
        SystemShop();
    }

    public void TimerBonusThemeHeartLeft ()
    {
        purharesHeart = 0;
        CharacterCount -= 1;
        PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
        PlayerPrefs.SetInt("purharesHeart", purharesHeart); 
        
        OwnedBall_Button.SetActive(true);
        CharacterInt = 0;
        PlayerPrefs.SetInt("CharacterInt",CharacterInt);
        SystemShop();
    }

    public void TimerBonusThemeCrabLeft ()
    {
        purharesCrab = 0;
        CharacterCount -= 1;
        PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
        PlayerPrefs.SetInt("purharesCrab", purharesCrab); 
        
        OwnedBall_Button.SetActive(true);
        CharacterInt = 0;
        PlayerPrefs.SetInt("CharacterInt",CharacterInt);
        SystemShop();
    }

    public void TimerBonusThemeBalloonLeft ()
    {
        purharesBallon = 0;
        CharacterCount -= 1;
        PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
        PlayerPrefs.SetInt("purharesBallon", purharesBallon); 
        
        OwnedBall_Button.SetActive(true);
        CharacterInt = 0;
        PlayerPrefs.SetInt("CharacterInt",CharacterInt);
        SystemShop(); 
    }

    public void TimerBonusThemeGhostLeft ()
    {
        purharesGhost = 0;
        CharacterCount -= 1;
        PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
        PlayerPrefs.SetInt("purharesGhost", purharesGhost); 
        
        OwnedBall_Button.SetActive(true);
        CharacterInt = 0;
        PlayerPrefs.SetInt("CharacterInt",CharacterInt);
        SystemShop();
    }

    public void TimerBonusThemeSquidLeft ()
    {
        purharesSquid = 0;
        CharacterCount -= 1;
        PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
        PlayerPrefs.SetInt("purharesSquid", purharesSquid); 
        
        OwnedBall_Button.SetActive(true);
        CharacterInt = 0;
        PlayerPrefs.SetInt("CharacterInt",CharacterInt);
        SystemShop(); 
    }

    public void TimerBonusThemeFlameLeft ()
    {
        purharesFlame = 0;
        CharacterCount -= 1;
        PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
        PlayerPrefs.SetInt("purharesFlame", purharesFlame); 
        
        OwnedBall_Button.SetActive(true);
        CharacterInt = 0;
        PlayerPrefs.SetInt("CharacterInt",CharacterInt);
        SystemShop();
    }

    public void TimerBonusThemeStrawberryLeft ()
    {
        purharesStrawberry = 0;
        CharacterCount -= 1;
        PlayerPrefs.SetInt("CharacterCount", CharacterCount);
        PlayerPrefs.SetInt("purharesStrawberry", purharesStrawberry); 
        
        OwnedBall_Button.SetActive(true);
        CharacterInt = 0;
        PlayerPrefs.SetInt("CharacterInt",CharacterInt);
        SystemShop();
    }

    public void TimerBonusThemeHeadLeft ()
    {
        purharesHead = 0;
        CharacterCount -= 1;
        PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
        PlayerPrefs.SetInt("purharesHead", purharesHead); 
        
        OwnedBall_Button.SetActive(true);
        CharacterInt = 0;
        PlayerPrefs.SetInt("CharacterInt",CharacterInt);
        SystemShop();
    }

    public void TimerBonusThemeSlimeLeft ()
    {
        purharesSlime = 0;
        CharacterCount -= 1;
        PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
        PlayerPrefs.SetInt("purharesSlime", purharesSlime); 
        
        OwnedBall_Button.SetActive(true);
        CharacterInt = 0;
        PlayerPrefs.SetInt("CharacterInt",CharacterInt);
        SystemShop();
    }

    public void TimerBonusThemeBunnyLeft ()
    {
        purharesBunny = 0;
        CharacterCount -= 1;
        PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
        PlayerPrefs.SetInt("purharesBunny", purharesBunny); 
        
        OwnedBall_Button.SetActive(true);
        CharacterInt = 0;
        PlayerPrefs.SetInt("CharacterInt",CharacterInt);
        SystemShop();
    }

    public void TimerBonusThemeMushroomLeft ()
    {
        purharesMushroom = 0;
        CharacterCount -= 1;
        PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
        PlayerPrefs.SetInt("purharesMushroom", purharesMushroom); 
        
        OwnedBall_Button.SetActive(true);
        CharacterInt = 0;
        PlayerPrefs.SetInt("CharacterInt",CharacterInt);
        SystemShop();
    }

    public void TimerBonusThemeIceCreamLeft ()
    {
        purharesIceCream = 0;
        CharacterCount -= 1;
        PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
        PlayerPrefs.SetInt("purharesIceCream", purharesIceCream); 
        
        OwnedBall_Button.SetActive(true);
        CharacterInt = 0;
        PlayerPrefs.SetInt("CharacterInt",CharacterInt);
        SystemShop();
    }

    public void TimerBonusThemeBearLeft ()
    {
        purharesBear = 0;
        CharacterCount -= 1;
        PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
        PlayerPrefs.SetInt("purharesBear", purharesBear); 
        
        OwnedBall_Button.SetActive(true);
        CharacterInt = 0;
        PlayerPrefs.SetInt("CharacterInt",CharacterInt);
        SystemShop();
    }

    public void TimerBonusThemeFlowerLeft ()
    {
        purharesFlower = 0;
        CharacterCount -= 1;
        PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
        PlayerPrefs.SetInt("purharesFlower", purharesFlower); 
        
        OwnedBall_Button.SetActive(true);
        CharacterInt = 0;
        PlayerPrefs.SetInt("CharacterInt",CharacterInt);
        SystemShop();
    }

    public void TimerBonusThemeJellyFishLeft ()
    {
        purharesJellyfish = 0;
        CharacterCount -= 1;
        PlayerPrefs.SetInt("CharacterCount", CharacterCount); 
        PlayerPrefs.SetInt("purharesJellyfish", purharesJellyfish); 
        
        OwnedBall_Button.SetActive(true);
        CharacterInt = 0;
        PlayerPrefs.SetInt("CharacterInt",CharacterInt);
        SystemShop(); 
    }

    private void Update()
    {
        CharacterInt = PlayerPrefs.GetInt("CharacterInt");
        Gems = PlayerPrefs.GetInt("Gems");
        Gold = PlayerPrefs.GetInt("Gold");

        CharacterCount = PlayerPrefs.GetInt("CharacterCount");
        CharacterCountText.text = CharacterCount.ToString() + "/18";
    }
}
