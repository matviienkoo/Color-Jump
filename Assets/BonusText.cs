using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BonusText : MonoBehaviour
{
    [Header("Main Sprite, Animation Sprite")]
    public GameObject main_sprite;
    public Animation animation_sprite;

    [Header("Options Sprite")]
    public Sprite Five_miles; 
    public Sprite Fifteen_miles;
    public Sprite Fifty_miles;
    public Sprite SeventyFive_miles;
    public Sprite Hundred_miles;
    public Sprite HundredTwentyFive_miles;
    public Sprite HundredFifty_miles;
    public Sprite HundredSeventyFive_miles;
    public Sprite TwoHundred_miles;
    public Sprite TwoHundredTwentyFive_miles;
    public Sprite TwoHundredFifty_miles;
    public Sprite TwoHundredSeventyFive_miles;
    public Sprite ThreeHundred_miles;
    public Sprite ThreeHundredFifty_miles;
    public Sprite FourHundred_miles;
    public Sprite FourHundredFifty_miles;
    public Sprite FiveHundred_miles;
    public Sprite SixHundred_miles;
    public Sprite SevenHundred_miles;
    public Sprite NineHundred_miles;
    public Sprite Thousand_miles;
    public Sprite ThousandTwoHundredFifty_miles;
    public Sprite ThousandFiveHundred_miles;
    public Sprite TwoThousandFiveHundred_miles;
    public Sprite ThreeThousand_miles;
    public Sprite ThreeThousandFiveHundred_miles;
    public Sprite FourThousandFiveHundred_miles;
    public Sprite SixThousand_miles;
    public Sprite SevenThousand_miles;
    public Sprite EightThousand_miles;
    public Sprite TenThousand_miles;

    [Header("Int Data")]
    public int Mils;
    public int BonusInt;
    public int ResumeInt;

    [Header("Sound")]
    public AudioSource SoundPop;

    private void Start ()
    {
        ResumeInt = PlayerPrefs.GetInt("ResumeInt");

        if (ResumeInt == 0){
        Mils = 0;
        PlayerPrefs.SetInt("intPos", Mils);
        }
    }

    public void DeletMilsInf ()
    {
        BonusInt = 0;
        PlayerPrefs.SetInt("BonusInt", BonusInt);
    }


    private void Update ()
    {
        BonusInt = PlayerPrefs.GetInt("BonusInt");
        Mils = PlayerPrefs.GetInt("intPos");

        // --- Clasic Text Bonus
        if (BonusInt == 0){
        if (Mils >= 5){
            main_sprite.GetComponent<SpriteRenderer>().sprite = Five_miles;
            BonusInt = 1;
            animation_sprite.Play();
            SoundPop.Play();
            PlayerPrefs.SetInt("BonusInt", BonusInt);
        }
        }

        if (BonusInt == 1){
        if (Mils >= 15){
            main_sprite.GetComponent<SpriteRenderer>().sprite = Fifteen_miles;
            BonusInt = 2;
            animation_sprite.Play();
            SoundPop.Play();
            PlayerPrefs.SetInt("BonusInt", BonusInt);
        }
        }

        if (BonusInt == 2){
        if (Mils >= 50){
            main_sprite.GetComponent<SpriteRenderer>().sprite = Fifty_miles;
            BonusInt = 3;
            animation_sprite.Play();
            SoundPop.Play();
            PlayerPrefs.SetInt("BonusInt", BonusInt);
        }
        }

        if (BonusInt == 3){
        if (Mils >= 75){
            main_sprite.GetComponent<SpriteRenderer>().sprite = SeventyFive_miles;
            BonusInt = 4;
            animation_sprite.Play();
            SoundPop.Play();
            PlayerPrefs.SetInt("BonusInt", BonusInt);
        }
        }

        if (BonusInt == 4){
        if (Mils >= 100){
            main_sprite.GetComponent<SpriteRenderer>().sprite = Hundred_miles;
            BonusInt = 5;
            animation_sprite.Play();
            SoundPop.Play();
            PlayerPrefs.SetInt("BonusInt", BonusInt);
        }
        }

        if (BonusInt == 5){
        if (Mils >= 125){
            main_sprite.GetComponent<SpriteRenderer>().sprite = HundredTwentyFive_miles;
            BonusInt = 6;
            animation_sprite.Play();
            SoundPop.Play();
            PlayerPrefs.SetInt("BonusInt", BonusInt);
        }
        }

        if (BonusInt == 6){
        if (Mils >= 150){
            main_sprite.GetComponent<SpriteRenderer>().sprite = HundredFifty_miles;
            BonusInt = 7;
            animation_sprite.Play();
            SoundPop.Play();
            PlayerPrefs.SetInt("BonusInt", BonusInt);
        }
        }

        if (BonusInt == 7){
        if (Mils >= 175){
            main_sprite.GetComponent<SpriteRenderer>().sprite = HundredSeventyFive_miles;
            BonusInt = 8;
            animation_sprite.Play();
            SoundPop.Play();
            PlayerPrefs.SetInt("BonusInt", BonusInt);
        }
        }

        if (BonusInt == 8){
        if (Mils >= 200){
            main_sprite.GetComponent<SpriteRenderer>().sprite = TwoHundred_miles;
            BonusInt = 9;
            animation_sprite.Play();
            SoundPop.Play();
            PlayerPrefs.SetInt("BonusInt", BonusInt);
        }
        }

        if (BonusInt == 9){
        if (Mils >= 225){
            main_sprite.GetComponent<SpriteRenderer>().sprite = TwoHundredTwentyFive_miles;
            BonusInt = 10;
            animation_sprite.Play();
            SoundPop.Play();
            PlayerPrefs.SetInt("BonusInt", BonusInt);
        }
        }

        if (BonusInt == 10){
        if (Mils >= 250){
            main_sprite.GetComponent<SpriteRenderer>().sprite = TwoHundredFifty_miles;
            BonusInt = 11;
            animation_sprite.Play();
            SoundPop.Play();
            PlayerPrefs.SetInt("BonusInt", BonusInt);
        }
        }

        if (BonusInt == 11){
        if (Mils >= 275){
            main_sprite.GetComponent<SpriteRenderer>().sprite = TwoHundredSeventyFive_miles;
            BonusInt = 12;
            animation_sprite.Play();
            SoundPop.Play();
            PlayerPrefs.SetInt("BonusInt", BonusInt);
        }
        }

        if (BonusInt == 12){
        if (Mils >= 300){
            main_sprite.GetComponent<SpriteRenderer>().sprite = ThreeHundred_miles;
            BonusInt = 13;
            animation_sprite.Play();
            SoundPop.Play();
            PlayerPrefs.SetInt("BonusInt", BonusInt);
        }
        }

        if (BonusInt == 13){
        if (Mils >= 350){
            main_sprite.GetComponent<SpriteRenderer>().sprite = ThreeHundredFifty_miles;
            BonusInt = 14;
            animation_sprite.Play();
            SoundPop.Play();
            PlayerPrefs.SetInt("BonusInt", BonusInt);
        }
        }

        if (BonusInt == 14){
        if (Mils >= 400){
            main_sprite.GetComponent<SpriteRenderer>().sprite = FourHundred_miles;
            BonusInt = 15;
            animation_sprite.Play();
            SoundPop.Play();
            PlayerPrefs.SetInt("BonusInt", BonusInt);
        }
        }

        if (BonusInt == 15){
        if (Mils >= 450){
            main_sprite.GetComponent<SpriteRenderer>().sprite = FourHundredFifty_miles;
            BonusInt = 16;
            animation_sprite.Play();
            SoundPop.Play();
            PlayerPrefs.SetInt("BonusInt", BonusInt);
        }
        }

        if (BonusInt == 16){
        if (Mils >= 500){
            main_sprite.GetComponent<SpriteRenderer>().sprite = FiveHundred_miles;
            BonusInt = 17;
            animation_sprite.Play();
            SoundPop.Play();
            PlayerPrefs.SetInt("BonusInt", BonusInt);
        }
        }

        if (BonusInt == 17){
        if (Mils >= 600){
            main_sprite.GetComponent<SpriteRenderer>().sprite = SixHundred_miles;
            BonusInt = 18;
            animation_sprite.Play();
            SoundPop.Play();
            PlayerPrefs.SetInt("BonusInt", BonusInt);
        }
        }

        if (BonusInt == 18){
        if (Mils >= 700){
            main_sprite.GetComponent<SpriteRenderer>().sprite = SevenHundred_miles;
            BonusInt = 19;
            animation_sprite.Play();
            SoundPop.Play();
            PlayerPrefs.SetInt("BonusInt", BonusInt);
        }
        }

        if (BonusInt == 19){
        if (Mils >= 900){
            main_sprite.GetComponent<SpriteRenderer>().sprite = NineHundred_miles;
            BonusInt = 20;
            animation_sprite.Play();
            SoundPop.Play();
            PlayerPrefs.SetInt("BonusInt", BonusInt);
        }
        }

        if (BonusInt == 20){
        if (Mils >= 1000){
            main_sprite.GetComponent<SpriteRenderer>().sprite = Thousand_miles;
            BonusInt = 21;
            animation_sprite.Play();
            SoundPop.Play();
            PlayerPrefs.SetInt("BonusInt", BonusInt);
        }
        }

        if (BonusInt == 21){
        if (Mils >= 1250){
            main_sprite.GetComponent<SpriteRenderer>().sprite = ThousandTwoHundredFifty_miles;
            BonusInt = 22;
            animation_sprite.Play();
            SoundPop.Play();
            PlayerPrefs.SetInt("BonusInt", BonusInt);
        }
        }

        if (BonusInt == 22){
        if (Mils >= 1500){
            main_sprite.GetComponent<SpriteRenderer>().sprite = ThousandFiveHundred_miles;
            BonusInt = 23;
            animation_sprite.Play();
            SoundPop.Play();
            PlayerPrefs.SetInt("BonusInt", BonusInt);
        }
        }

        if (BonusInt == 23){
        if (Mils >= 2500){
            main_sprite.GetComponent<SpriteRenderer>().sprite = TwoThousandFiveHundred_miles;
            BonusInt = 24;
            animation_sprite.Play();
            SoundPop.Play();
            PlayerPrefs.SetInt("BonusInt", BonusInt);
        }
        }

        if (BonusInt == 24){
        if (Mils >= 3000){
            main_sprite.GetComponent<SpriteRenderer>().sprite = ThreeThousand_miles;
            BonusInt = 25;
            animation_sprite.Play();
            SoundPop.Play();
            PlayerPrefs.SetInt("BonusInt", BonusInt);
        }
        }

        if (BonusInt == 25){
        if (Mils >= 3500){
            main_sprite.GetComponent<SpriteRenderer>().sprite = ThreeThousandFiveHundred_miles;
            BonusInt = 26;
            animation_sprite.Play();
            SoundPop.Play();
            PlayerPrefs.SetInt("BonusInt", BonusInt);
        }
        }

        if (BonusInt == 26){
        if (Mils >= 4500){
            main_sprite.GetComponent<SpriteRenderer>().sprite = FourThousandFiveHundred_miles;
            BonusInt = 27;
            animation_sprite.Play();
            SoundPop.Play();
            PlayerPrefs.SetInt("BonusInt", BonusInt);
        }
        }

        if (BonusInt == 27){
        if (Mils >= 6000){
            main_sprite.GetComponent<SpriteRenderer>().sprite = SixThousand_miles;
            BonusInt = 28;
            animation_sprite.Play();
            SoundPop.Play();
            PlayerPrefs.SetInt("BonusInt", BonusInt);
        }
        }

        if (BonusInt == 28){
        if (Mils >= 7000){
            main_sprite.GetComponent<SpriteRenderer>().sprite = SevenThousand_miles;
            BonusInt = 29;
            animation_sprite.Play();
            SoundPop.Play();
            PlayerPrefs.SetInt("BonusInt", BonusInt);
        }
        }

        if (BonusInt == 29){
        if (Mils >= 8000){
            main_sprite.GetComponent<SpriteRenderer>().sprite = EightThousand_miles;
            BonusInt = 30;
            animation_sprite.Play();
            SoundPop.Play();
            PlayerPrefs.SetInt("BonusInt", BonusInt);
        }
        }

        if (BonusInt == 30){
        if (Mils >= 10000){
            main_sprite.GetComponent<SpriteRenderer>().sprite = TenThousand_miles;
            BonusInt = 31;
            animation_sprite.Play();
            SoundPop.Play();
            PlayerPrefs.SetInt("BonusInt", BonusInt);
        }
        }
    }
}
