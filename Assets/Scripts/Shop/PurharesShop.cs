using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Purchasing;
using TMPro;

public class PurharesShop : MonoBehaviour
{
[Header("Gold")]
public int Gold;
public int GoldAnalitics;

[Header("Gems")]
public int Gems;
public int GemsAnalitics;

[Header("GameObject")]
public GameObject EmailObject;

[Header("Sounds")]
public AudioSource Gold_Audio;
public AudioSource Clasic_Audio;
public AudioSource Eror_Audio;

[Header("Script")]
public NoAdsPurhares NoAdsPursh;
public CharacterShop ChrShop;
public ThemeShop ThmShop;

[Header("Sale Int")]
public int HolidaySalesInt;

[Header("Sale Design (Pouch Of Gold)")]
public GameObject Image_PouchGold;
public Sprite Sprite_PouchGold;

[Header("Sale Design (Bag Of Gold)")]
public GameObject Image_BagGold;
public Sprite Sprite_BagGold;

[Header("Sale Design (Chest Of Gold)")]
public GameObject Image_ChestGold;
public Sprite Sprite_ChestGold;

[Header("Sale Design (Wagon Of Gold)")]
public GameObject Image_WagonGold;
public Sprite Sprite_WagonGold;

// --- Pouch of Gems (Sale Design)
[Header("Sale Design (Pouch Of Gems)")]
public Image Image_PouchGems;
public Sprite Sprite_PouchGems;
public GameObject GameObject_PouchGems_Clasic;
public GameObject GameObject_PouchGems_Sale;

[Header("Sale Design (Bag Of Gems)")]
public Image Image_BagGems;
public Sprite Sprite_BagGems;
public GameObject GameObject_BagGems_Clasic;
public GameObject GameObject_BagGems_Sale;

[Header("Sale Design (Chest Of Gems)")]
public Image Image_ChestGems;
public Sprite Sprite_ChestGems;
public GameObject GameObject_ChestGems_Clasic;
public GameObject GameObject_ChestGems_Sale;

[Header("Sale Design (Wagon Of Gems)")]
public Image Image_WagonGems;
public Sprite Sprite_WagonGems;
public GameObject GameObject_WagonGems_Clasic;
public GameObject GameObject_WagonGems_Sale;
    
    private void Start ()
    {
        // If today holiday 
        HolidaySalesInt = PlayerPrefs.GetInt("HolidaySalesInt");
        if (HolidaySalesInt == 1)
        {
            ChangeDesing();
        }
    }

    public void ChangeDesing ()
    {
        // Pouch of Gold
        Image_PouchGold.GetComponent<Image>().sprite = Sprite_PouchGold;
        Image_BagGold.GetComponent<Image>().sprite = Sprite_BagGold;
        Image_ChestGold.GetComponent<Image>().sprite = Sprite_ChestGold;
        Image_WagonGold.GetComponent<Image>().sprite = Sprite_WagonGold;

        // Pouch of Gems
        Image_PouchGems.GetComponent<Image>().sprite = Sprite_PouchGems;
        GameObject_PouchGems_Clasic.SetActive(false);
        GameObject_PouchGems_Sale.SetActive(true);

        Image_BagGems.GetComponent<Image>().sprite = Sprite_BagGems;
        GameObject_BagGems_Clasic.SetActive(false);
        GameObject_BagGems_Sale.SetActive(true);

        Image_ChestGems.GetComponent<Image>().sprite = Sprite_ChestGems;
        GameObject_ChestGems_Clasic.SetActive(false);
        GameObject_ChestGems_Sale.SetActive(true);

        Image_WagonGems.GetComponent<Image>().sprite = Sprite_WagonGems;
        GameObject_WagonGems_Clasic.SetActive(false);
        GameObject_WagonGems_Sale.SetActive(true);
    }

    public void OnPurchaseComplete(Product product)
    {
        switch (product.definition.id)
        {
            case "pouchgems":
            {
                Gems += 25;
                GemsAnalitics += 25;
                PlayerPrefs.SetInt("Gems",Gems);
                PlayerPrefs.SetInt("GemsAnalitics",GemsAnalitics);
            }
            break;

            case "pouchofgemssales":
            {
                Gems += 25;
                GemsAnalitics += 25;
                PlayerPrefs.SetInt("Gems",Gems);
                PlayerPrefs.SetInt("GemsAnalitics",GemsAnalitics);
            }
            break;

            case "baggems":
            {
                Gems += 250;
                GemsAnalitics += 250;
                PlayerPrefs.SetInt("Gems",Gems);
                PlayerPrefs.SetInt("GemsAnalitics",GemsAnalitics);
            }
            break;

            case "baggemssales":
            {
                Gems += 250;
                GemsAnalitics += 250;
                PlayerPrefs.SetInt("Gems",Gems);
                PlayerPrefs.SetInt("GemsAnalitics",GemsAnalitics);
            }
            break;

            case "chestgems":
            {
                Gems += 1000;
                GemsAnalitics += 1000;
                PlayerPrefs.SetInt("Gems",Gems);
                PlayerPrefs.SetInt("GemsAnalitics",GemsAnalitics);
            }
            break;

            case "chestgemssales":
            {
                Gems += 1000;
                GemsAnalitics += 1000;
                PlayerPrefs.SetInt("Gems",Gems);
                PlayerPrefs.SetInt("GemsAnalitics",GemsAnalitics);
            }
            break;

            case "wagongems":
            {
                Gems += 2500;
                GemsAnalitics += 2500;
                PlayerPrefs.SetInt("Gems",Gems);
                PlayerPrefs.SetInt("GemsAnalitics",GemsAnalitics);
            }
            break;

            case "wagongemssales":
            {
                Gems += 2500;
                GemsAnalitics += 2500;
                PlayerPrefs.SetInt("Gems",Gems);
                PlayerPrefs.SetInt("GemsAnalitics",GemsAnalitics);
            }
            break;

            case "noads":
            {
                NoAdsPursh.BuyAds();
            }
            break;

            case "noadssales":
            {
                NoAdsPursh.BuyAds();
            }
            break;

            case "gold_subscription":
            {
                // gold
                Gold += 2500;
                GoldAnalitics += 2500;
                PlayerPrefs.SetInt("Gold",Gold);
                PlayerPrefs.SetInt("GoldAnalitics",GoldAnalitics);

                // gems
                Gems += 15;
                GemsAnalitics += 15;
                PlayerPrefs.SetInt("Gems",Gems);
                PlayerPrefs.SetInt("GemsAnalitics",GemsAnalitics);

                // ads
                NoAdsPursh.BuyAds();

                // character
                ChrShop.CharacterWinSpin();
            }
            break;

            case "diamond_subscription":
            {
                // gold
                Gold += 5000;
                GoldAnalitics += 5000;
                PlayerPrefs.SetInt("Gold",Gold);
                PlayerPrefs.SetInt("GoldAnalitics",GoldAnalitics);

                // gems
                Gems += 30;
                GemsAnalitics += 30;
                PlayerPrefs.SetInt("Gems",Gems);
                PlayerPrefs.SetInt("GemsAnalitics",GemsAnalitics);

                // ads
                NoAdsPursh.BuyAds();

                // character and theme
                ChrShop.CharacterWinSpin();
                ThmShop.ThemeWinSpin();
            }
            break;
        }
    }

    public void PremiumVersion ()
    {
        Gems += 100000;
        PlayerPrefs.SetInt("Gems",Gems);
        Gold += 5000000;
        PlayerPrefs.SetInt("Gold",Gold);

        NoAdsPursh.BuyAds();
    }

    public void pouch_gold_Thousand ()
    {
        HolidaySalesInt = PlayerPrefs.GetInt("HolidaySalesInt");
        Gold = PlayerPrefs.GetInt("Gold");
        Gems = PlayerPrefs.GetInt("Gems");

        // Normal day
        if (HolidaySalesInt == 0){
        if (Gems >= 25)
        {
            Gold_Audio.Play();
            Gold += 1000;
            Gems -= 25;
            PlayerPrefs.SetInt("Gold",Gold);
            PlayerPrefs.SetInt("Gems",Gems);
        }
        else
        Eror_Audio.Play();
        }

        // Holiday
        if (HolidaySalesInt == 1){
        if (Gems >= 12)
        {
            Gold_Audio.Play();
            Gold += 1000;
            Gems -= 12;
            PlayerPrefs.SetInt("Gold",Gold);
            PlayerPrefs.SetInt("Gems",Gems);
        }
        else
        Eror_Audio.Play();
        }
    }

    public void pouch_gold_TenThousand ()
    {
        HolidaySalesInt = PlayerPrefs.GetInt("HolidaySalesInt");
        Gold = PlayerPrefs.GetInt("Gold");
        Gems = PlayerPrefs.GetInt("Gems");

        // Normal day
        if (HolidaySalesInt == 0){
        if (Gems >= 250)
        {
            Gold_Audio.Play();
            Gold += 10000;
            Gems -= 250;
            PlayerPrefs.SetInt("Gold",Gold);
            PlayerPrefs.SetInt("Gems",Gems);
        }
        else
        Eror_Audio.Play();
        }

        // Holiday
        if (HolidaySalesInt == 1){
        if (Gems >= 125)
        {
            Gold_Audio.Play();
            Gold += 10000;
            Gems -= 125;
            PlayerPrefs.SetInt("Gold",Gold);
            PlayerPrefs.SetInt("Gems",Gems);
        }
        else
        Eror_Audio.Play();
        }
    }

    public void pouch_gold_OneHundredThousand ()
    {
        HolidaySalesInt = PlayerPrefs.GetInt("HolidaySalesInt");
        Gold = PlayerPrefs.GetInt("Gold");
        Gems = PlayerPrefs.GetInt("Gems");

        // Normal day
        if (HolidaySalesInt == 0){
        if (Gems >= 500)
        {
            Gold_Audio.Play();
            Gold += 100000;
            Gems -= 500;
            PlayerPrefs.SetInt("Gold",Gold);
            PlayerPrefs.SetInt("Gems",Gems);
        }
        else
        Eror_Audio.Play();
        }

        // Holiday
        if (HolidaySalesInt == 1){
        if (Gems >= 250)
        {
            Gold_Audio.Play();
            Gold += 100000;
            Gems -= 250;
            PlayerPrefs.SetInt("Gold",Gold);
            PlayerPrefs.SetInt("Gems",Gems);
        }
        else
        Eror_Audio.Play();
        }
    }

    public void pouch_gold_FiveHundredThousand ()
    {
        HolidaySalesInt = PlayerPrefs.GetInt("HolidaySalesInt");
        Gold = PlayerPrefs.GetInt("Gold");
        Gems = PlayerPrefs.GetInt("Gems");

        // Normal day
        if (HolidaySalesInt == 0){
        if (Gems >= 1500)
        {
            Gold_Audio.Play();
            Gold += 500000;
            Gems -= 1500;
            PlayerPrefs.SetInt("Gold",Gold);
            PlayerPrefs.SetInt("Gems",Gems);
        }
        else
        Eror_Audio.Play();
        }

        // Holiday
        if (HolidaySalesInt == 1){
        if (Gems >= 750)
        {
            Gold_Audio.Play();
            Gold += 500000;
            Gems -= 750;
            PlayerPrefs.SetInt("Gold",Gold);
            PlayerPrefs.SetInt("Gems",Gems);
        }
        else
        Eror_Audio.Play();
        }
    }

    public void promote_one_month ()
    {
        HolidaySalesInt = PlayerPrefs.GetInt("HolidaySalesInt");
        Gems = PlayerPrefs.GetInt("Gems");

        // Normal day
        if (HolidaySalesInt == 0){
        if (Gems >= 1000)
        {
            Gems -= 1000;
            PlayerPrefs.SetInt("Gems",Gems);

            EmailObject.SetActive(true);
            Clasic_Audio.Play();
        }
        else
        Eror_Audio.Play();
        }

        // Holiday
        if (HolidaySalesInt == 1){
        if (Gems >= 500)
        {
            Gems -= 500;
            PlayerPrefs.SetInt("Gems",Gems);

            EmailObject.SetActive(true);
            Clasic_Audio.Play();
        }
        else
        Eror_Audio.Play();
        }
    }

    public void promote_six_month ()
    {
        HolidaySalesInt = PlayerPrefs.GetInt("HolidaySalesInt");
        Gems = PlayerPrefs.GetInt("Gems");

        // Normal day
        if (HolidaySalesInt == 0){
        if (Gems >= 2500)
        {
            Gems -= 2500;
            PlayerPrefs.SetInt("Gems",Gems);

            EmailObject.SetActive(true);
            Clasic_Audio.Play();
        }
        else
        Eror_Audio.Play();
        }

        // Holiday
        if (HolidaySalesInt == 1){
        if (Gems >= 1250)
        {
            Gems -= 1250;
            PlayerPrefs.SetInt("Gems",Gems);

            EmailObject.SetActive(true);
            Clasic_Audio.Play();
        }
        else
        Eror_Audio.Play();
        }
    }

    public void promote_one_year()
    {
        HolidaySalesInt = PlayerPrefs.GetInt("HolidaySalesInt");
        Gems = PlayerPrefs.GetInt("Gems");

        // Normal day
        if (HolidaySalesInt == 0){
        if (Gems >= 3000)
        {
            Gems -= 3000;
            PlayerPrefs.SetInt("Gems",Gems);

            EmailObject.SetActive(true);
            Clasic_Audio.Play();
        }
        else
        Eror_Audio.Play();
        }

        // Holiday
        if (HolidaySalesInt == 1){
        if (Gems >= 1500)
        {
            Gems -= 1500;
            PlayerPrefs.SetInt("Gems",Gems);

            EmailObject.SetActive(true);
            Clasic_Audio.Play();
        }
        else
        Eror_Audio.Play();
        }
    }
}
