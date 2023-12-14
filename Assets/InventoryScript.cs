using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class InventoryScript : MonoBehaviour
{

[Header("1 Timer")]
public Image PanelFirst;
public GameObject ObjectFirst;
public TextMeshProUGUI TextFirst;
public GameObject GameObjectFirst;

public float WaitMsFirst;
private ulong LastTimeFirst;
public int IntFirst;

[Header("2 Timer")]
public Image PanelSecond;
public GameObject ObjectSecond;
public TextMeshProUGUI TextSecond;
public GameObject GameObjectSecond;

public float WaitMsSecond;
private ulong LastTimeSecond;
public int IntSecond;

[Header("3 Timer")]
public Image PanelThirt;
public GameObject ObjectThirt;
public TextMeshProUGUI TextThirt;
public GameObject GameObjectThirt;

public float WaitMsThirt;
private ulong LastTimeThirt;
public int IntThirt;

[Header("4 Timer")]
public Image PanelFour;
public GameObject ObjectFour;
public TextMeshProUGUI TextFour;
public GameObject GameObjectFour;

public float WaitMsFour;
private ulong LastTimeFour;
public int IntFour;

[Header("5 Timer")]
public Image PanelFive;
public GameObject ObjectFive;
public TextMeshProUGUI TextFive;
public GameObject GameObjectFive;

public float WaitMsFive;
private ulong LastTimeFive;
public int IntFive;

[Header("6 Timer")]
public Image PanelSix;
public GameObject ObjectSix;
public TextMeshProUGUI TextSix;
public GameObject GameObjectSix;

public float WaitMsSix;
private ulong LastTimeSix;
public int IntSix;

[Header("7 Timer")]
public Image PanelSeven;
public GameObject ObjectSeven;
public TextMeshProUGUI TextSeven;
public GameObject GameObjectSeven;

public float WaitMsSeven;
private ulong LastTimeSeven;
public int IntSeven;

[Header("8 Timer")]
public Image PanelEight;
public GameObject ObjectEight;
public TextMeshProUGUI TextEight;
public GameObject GameObjectEight;

public float WaitMsEight;
private ulong LastTimeEight;
public int IntEight;

[Header("9 Timer")]
public Image PanelNine;
public GameObject ObjectNine;
public TextMeshProUGUI TextNine;
public GameObject GameObjectNine;

public float WaitMsNine;
private ulong LastTimeNine;
public int IntNine;

[Header("10 Timer")]
public Image PanelTen;
public GameObject ObjectTen;
public TextMeshProUGUI TextTen;
public GameObject GameObjectTen;

public float WaitMsTen;
private ulong LastTimeTen;
public int IntTen;

[Header("11 Timer")]
public Image PanelEleven;
public GameObject ObjectEleven;
public TextMeshProUGUI TextEleven;
public GameObject GameObjectEleven;

public float WaitMsEleven;
private ulong LastTimeEleven;
public int IntEleven;

[Header("12 Timer")]
public Image PanelTwelve;
public GameObject ObjectTwelve;
public TextMeshProUGUI TextTwelve;
public GameObject GameObjectTwelve;

public float WaitMsTwelve;
private ulong LastTimeTwelve;
public int IntTwelve;

[Header("13 Timer")]
public Image PanelThreeteen;
public GameObject ObjectThreeteen;
public TextMeshProUGUI TextThreeteen;
public GameObject GameObjectThreeteen;

public float WaitMsThreeteen;
private ulong LastTimeThreeteen;
public int IntThreeteen;

[Header("14 Timer")]
public Image PanelFourteen;
public GameObject ObjectFourteen;
public TextMeshProUGUI TextFourteen;
public GameObject GameObjectFourteen;

public float WaitMsFourteen;
private ulong LastTimeFourteen;
public int IntFourteen;

[Header("15 Timer")]
public Image PanelFiveteen;
public GameObject ObjectFiveteen;
public TextMeshProUGUI TextFiveteen;
public GameObject GameObjectFiveteen;

public float WaitMsFiveteen;
private ulong LastTimeFiveteen;
public int IntFiveteen;


[Header("Clasic Sprite")]
public Sprite Clasic_Sprite;
public int IntCharacterTheme;
public int IntPanel;
public int IntPanelSpecial;

[Header("Character Objects")]
public Sprite Star_Character;
public Sprite Cupcake_Character;
public Sprite Heart_Character;
public Sprite Crab_Character;
public Sprite Ballon_Character;
public Sprite Ghost_Character;
public Sprite Squid_Character;
public Sprite Flame_Character;
public Sprite Strawberry_Character;
public Sprite Head_Character;
public Sprite Slime_Character;
public Sprite Bunny_Character;
public Sprite Mushroom_Character;
public Sprite IceCream_Character;
public Sprite Bear_Character;
public Sprite Flower_Character;
public Sprite JellyFish_Character;

[Header("Theme Objects")]
public Sprite Flowers_Theme;
public Sprite Pyramids_Theme;
public Sprite Desert_Theme;
public Sprite Snow_Theme;
public Sprite Island_Theme;
public Sprite Volcano_Theme;
public Sprite NightSky_Theme;
public Sprite Autumn_Theme;
public Sprite Dinosaurus_Theme;
public Sprite Aquarium_Theme;
public Sprite Space_Theme;
public Sprite Rain_Theme;

[Header("Select Sprites")]
public int IntCharacterFirst;
public int IntCharacterSecond;
public int IntCharacterThirt;
public int IntCharacterFour;
public int IntCharacterFive;
public int IntCharacterSix;
public int IntCharacterSeven;
public int IntCharacterEight;
public int IntCharacterNine;
public int IntCharacterTen;
public int IntCharacterEleven;
public int IntCharacterTwelve;
public int IntCharacterThirteen;
public int IntCharacterFourteen;
public int IntCharacterFifteen;


[Header("Scripts")]
public CharacterShop ScriptCharacter;
public ThemeShop ScriptTheme;

private void Start ()
{
    IntFirst = PlayerPrefs.GetInt("IntFirst");
    if(PlayerPrefs.HasKey("FirstTable")){
    LastTimeFirst = ulong.Parse(PlayerPrefs.GetString("FirstTable"));
    }else{
    LastTimeFirst = (ulong)DateTime.Now.Ticks;
    PlayerPrefs.SetString("FirstTable", LastTimeFirst.ToString());
    }

    IntSecond = PlayerPrefs.GetInt("IntSecond");
    if(PlayerPrefs.HasKey("SecondTable")){
    LastTimeSecond = ulong.Parse(PlayerPrefs.GetString("SecondTable"));
    }else{
    LastTimeSecond = (ulong)DateTime.Now.Ticks;
    PlayerPrefs.SetString("SecondTable", LastTimeSecond.ToString());
    }

    IntThirt = PlayerPrefs.GetInt("IntThirt");
    if(PlayerPrefs.HasKey("ThreeTable")){
    LastTimeThirt = ulong.Parse(PlayerPrefs.GetString("ThreeTable"));
    }else{
    LastTimeThirt = (ulong)DateTime.Now.Ticks;
    PlayerPrefs.SetString("ThreeTable", LastTimeThirt.ToString());
    }

    IntFour = PlayerPrefs.GetInt("IntFour");
    if(PlayerPrefs.HasKey("FourTable")){
    LastTimeFour = ulong.Parse(PlayerPrefs.GetString("FourTable"));
    }else{
    LastTimeFour = (ulong)DateTime.Now.Ticks;
    PlayerPrefs.SetString("FourTable", LastTimeFour.ToString());
    }

    IntFive = PlayerPrefs.GetInt("IntFive");
    if(PlayerPrefs.HasKey("FiveTable")){
    LastTimeFive = ulong.Parse(PlayerPrefs.GetString("FiveTable"));
    }else{
    LastTimeFive = (ulong)DateTime.Now.Ticks;
    PlayerPrefs.SetString("FiveTable", LastTimeFive.ToString());
    }

    IntSix = PlayerPrefs.GetInt("IntSix");
    if(PlayerPrefs.HasKey("SixTable")){
    LastTimeSix = ulong.Parse(PlayerPrefs.GetString("SixTable"));
    }else{
    LastTimeSix = (ulong)DateTime.Now.Ticks;
    PlayerPrefs.SetString("SixTable", LastTimeSix.ToString());
    }

    IntSeven = PlayerPrefs.GetInt("IntSeven");
    if(PlayerPrefs.HasKey("SevenTable")){
    LastTimeSeven = ulong.Parse(PlayerPrefs.GetString("SevenTable"));
    }else{
    LastTimeSeven = (ulong)DateTime.Now.Ticks;
    PlayerPrefs.SetString("SevenTable", LastTimeSeven.ToString());
    }

    IntEight = PlayerPrefs.GetInt("IntEight");
    if(PlayerPrefs.HasKey("EightTable")){
    LastTimeEight = ulong.Parse(PlayerPrefs.GetString("EightTable"));
    }else{
    LastTimeEight = (ulong)DateTime.Now.Ticks;
    PlayerPrefs.SetString("EightTable", LastTimeEight.ToString());
    }

    IntNine = PlayerPrefs.GetInt("IntNine");
    if(PlayerPrefs.HasKey("NineTable")){
    LastTimeNine = ulong.Parse(PlayerPrefs.GetString("NineTable"));
    }else{
    LastTimeNine = (ulong)DateTime.Now.Ticks;
    PlayerPrefs.SetString("NineTable", LastTimeNine.ToString());
    }

    IntTen = PlayerPrefs.GetInt("IntTen");
    if(PlayerPrefs.HasKey("TenTable")){
    LastTimeTen = ulong.Parse(PlayerPrefs.GetString("TenTable"));
    }else{
    LastTimeTen = (ulong)DateTime.Now.Ticks;
    PlayerPrefs.SetString("TenTable", LastTimeTen.ToString());
    }

    IntEleven = PlayerPrefs.GetInt("IntEleven");
    if(PlayerPrefs.HasKey("ElevenTable")){
    LastTimeEleven = ulong.Parse(PlayerPrefs.GetString("ElevenTable"));
    }else{
    LastTimeEleven = (ulong)DateTime.Now.Ticks;
    PlayerPrefs.SetString("ElevenTable", LastTimeEleven.ToString());
    }

    IntTwelve = PlayerPrefs.GetInt("IntTwelve");
    if(PlayerPrefs.HasKey("TwelveTable")){
    LastTimeTwelve = ulong.Parse(PlayerPrefs.GetString("TwelveTable"));
    }else{
    LastTimeTwelve = (ulong)DateTime.Now.Ticks;
    PlayerPrefs.SetString("TwelveTable", LastTimeTwelve.ToString());
    }

    IntThreeteen = PlayerPrefs.GetInt("IntThreeteen");
    if(PlayerPrefs.HasKey("ThirteenTable")){
    LastTimeThreeteen = ulong.Parse(PlayerPrefs.GetString("ThirteenTable"));
    }else{
    LastTimeThreeteen = (ulong)DateTime.Now.Ticks;
    PlayerPrefs.SetString("ThirteenTable", LastTimeThreeteen.ToString());
    }

    IntFourteen = PlayerPrefs.GetInt("IntFourteen");
    if(PlayerPrefs.HasKey("FourteenTable")){
    LastTimeFourteen = ulong.Parse(PlayerPrefs.GetString("FourteenTable"));
    }else{
    LastTimeFourteen = (ulong)DateTime.Now.Ticks;
    PlayerPrefs.SetString("FourteenTable", LastTimeFourteen.ToString());
    }

    IntFiveteen = PlayerPrefs.GetInt("IntFiveteen");
    if(PlayerPrefs.HasKey("FifteenTable")){
    LastTimeFiveteen = ulong.Parse(PlayerPrefs.GetString("FifteenTable"));
    }else{
    LastTimeFiveteen = (ulong)DateTime.Now.Ticks;
    PlayerPrefs.SetString("FifteenTable", LastTimeFiveteen.ToString());
    }

    IntPanel = PlayerPrefs.GetInt("IntPanel");
    IntPanelSpecial = PlayerPrefs.GetInt("IntPanelSpecial");
    IntCharacterTheme = PlayerPrefs.GetInt("IntCharacterTheme");

    SelectSprites();
}

public void StartStar ()
{
    IntPanel += 1;
    PlayerPrefs.SetInt("IntPanel", IntPanel); 

    IntPanelSpecial += 1;
    PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial); 

    IntCharacterTheme = 1;
    PlayerPrefs.SetInt("IntCharacterTheme", IntCharacterTheme); 

    RandomObject();
    UpdateInventory();
}

public void StartCupCake ()
{
    IntPanel += 1;
    PlayerPrefs.SetInt("IntPanel", IntPanel); 

    IntPanelSpecial += 1;
    PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial); 

    IntCharacterTheme = 2;
    PlayerPrefs.SetInt("IntCharacterTheme", IntCharacterTheme); 

    RandomObject();
    UpdateInventory();
}

public void StartHeart ()
{
    IntPanel += 1;
    PlayerPrefs.SetInt("IntPanel", IntPanel); 

    IntPanelSpecial += 1;
    PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial); 

    IntCharacterTheme = 3;
    PlayerPrefs.SetInt("IntCharacterTheme", IntCharacterTheme); 

    RandomObject();
    UpdateInventory();
}

public void StartBallon ()
{
    IntPanel += 1;
    PlayerPrefs.SetInt("IntPanel", IntPanel); 

    IntPanelSpecial += 1;
    PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial); 

    IntCharacterTheme = 4;
    PlayerPrefs.SetInt("IntCharacterTheme", IntCharacterTheme); 

    RandomObject();
    UpdateInventory();
}

public void StartCrab ()
{
    IntPanel += 1;
    PlayerPrefs.SetInt("IntPanel", IntPanel); 

    IntPanelSpecial += 1;
    PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial); 

    IntCharacterTheme = 5;
    PlayerPrefs.SetInt("IntCharacterTheme", IntCharacterTheme); 

    RandomObject();
    UpdateInventory();
}

public void StartGhost ()
{
    IntPanel += 1;
    PlayerPrefs.SetInt("IntPanel", IntPanel); 

    IntPanelSpecial += 1;
    PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial); 

    IntCharacterTheme = 6;
    PlayerPrefs.SetInt("IntCharacterTheme", IntCharacterTheme); 

    RandomObject();
    UpdateInventory();
}

public void StartSquid ()
{
    IntPanel += 1;
    PlayerPrefs.SetInt("IntPanel", IntPanel); 

    IntPanelSpecial += 1;
    PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial); 

    IntCharacterTheme = 7;
    PlayerPrefs.SetInt("IntCharacterTheme", IntCharacterTheme); 

    RandomObject();
    UpdateInventory();
}

public void StartFlame ()
{
    IntPanel += 1;
    PlayerPrefs.SetInt("IntPanel", IntPanel); 

    IntPanelSpecial += 1;
    PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial); 

    IntCharacterTheme = 8;
    PlayerPrefs.SetInt("IntCharacterTheme", IntCharacterTheme); 

    RandomObject();
    UpdateInventory();
}

public void StartStrawbeery ()
{
    IntPanel += 1;
    PlayerPrefs.SetInt("IntPanel", IntPanel); 

    IntPanelSpecial += 1;
    PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial); 

    IntCharacterTheme = 9;
    PlayerPrefs.SetInt("IntCharacterTheme", IntCharacterTheme); 

    RandomObject();
    UpdateInventory();
}

public void StartHead ()
{
    IntPanel += 1;
    PlayerPrefs.SetInt("IntPanel", IntPanel); 

    IntPanelSpecial += 1;
    PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial); 

    IntCharacterTheme = 10;
    PlayerPrefs.SetInt("IntCharacterTheme", IntCharacterTheme); 

    RandomObject();
    UpdateInventory();
}

public void StartSlime ()
{
    IntPanel += 1;
    PlayerPrefs.SetInt("IntPanel", IntPanel); 

    IntPanelSpecial += 1;
    PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial); 

    IntCharacterTheme = 11;
    PlayerPrefs.SetInt("IntCharacterTheme", IntCharacterTheme); 

    RandomObject();
    UpdateInventory();
}

public void StartBunny ()
{
    IntPanel += 1;
    PlayerPrefs.SetInt("IntPanel", IntPanel); 

    IntPanelSpecial += 1;
    PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial); 

    IntCharacterTheme = 12;
    PlayerPrefs.SetInt("IntCharacterTheme", IntCharacterTheme); 

    RandomObject();
    UpdateInventory();
}

public void StartMushroom ()
{
    IntPanel += 1;
    PlayerPrefs.SetInt("IntPanel", IntPanel); 

    IntPanelSpecial += 1;
    PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial); 

    IntCharacterTheme = 13;
    PlayerPrefs.SetInt("IntCharacterTheme", IntCharacterTheme); 

    RandomObject();
    UpdateInventory();
}

public void StartIceCream ()
{
    IntPanel += 1;
    PlayerPrefs.SetInt("IntPanel", IntPanel); 

    IntPanelSpecial += 1;
    PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial); 

    IntCharacterTheme = 14;
    PlayerPrefs.SetInt("IntCharacterTheme", IntCharacterTheme); 

    RandomObject();
    UpdateInventory();
}

public void StartBear ()
{
    IntPanel += 1;
    PlayerPrefs.SetInt("IntPanel", IntPanel); 

    IntPanelSpecial += 1;
    PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial); 

    IntCharacterTheme = 15;
    PlayerPrefs.SetInt("IntCharacterTheme", IntCharacterTheme); 

    RandomObject();
    UpdateInventory();
}

public void StartFlower ()
{
    IntPanel += 1;
    PlayerPrefs.SetInt("IntPanel", IntPanel); 

    IntPanelSpecial += 1;
    PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial); 

    IntCharacterTheme = 16;
    PlayerPrefs.SetInt("IntCharacterTheme", IntCharacterTheme); 

    RandomObject();
    UpdateInventory();
}

public void StartJellyfish ()
{
    IntPanel += 1;
    PlayerPrefs.SetInt("IntPanel", IntPanel); 

    IntPanelSpecial += 1;
    PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial); 

    IntCharacterTheme = 17;
    PlayerPrefs.SetInt("IntCharacterTheme", IntCharacterTheme); 

    RandomObject();
    UpdateInventory();
}

public void StartFlowers ()
{
    IntPanel += 1;
    PlayerPrefs.SetInt("IntPanel", IntPanel); 

    IntPanelSpecial += 1;
    PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial); 

    IntCharacterTheme = 18;
    PlayerPrefs.SetInt("IntCharacterTheme", IntCharacterTheme); 

    RandomObject();
    UpdateInventory();
}

public void StartPyramids ()
{
    IntPanel += 1;
    PlayerPrefs.SetInt("IntPanel", IntPanel); 

    IntPanelSpecial += 1;
    PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial); 

    IntCharacterTheme = 19;
    PlayerPrefs.SetInt("IntCharacterTheme", IntCharacterTheme); 

    RandomObject();
    UpdateInventory();
}

public void StartDesert ()
{
    IntPanel += 1;
    PlayerPrefs.SetInt("IntPanel", IntPanel); 

    IntPanelSpecial += 1;
    PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial); 

    IntCharacterTheme = 20;
    PlayerPrefs.SetInt("IntCharacterTheme", IntCharacterTheme); 

    RandomObject();
    UpdateInventory();
}

public void StartSnow ()
{
    IntPanel += 1;
    PlayerPrefs.SetInt("IntPanel", IntPanel); 

    IntPanelSpecial += 1;
    PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial); 

    IntCharacterTheme = 21;
    PlayerPrefs.SetInt("IntCharacterTheme", IntCharacterTheme); 

    RandomObject();
    UpdateInventory();
}

public void StartIsland ()
{
    IntPanel += 1;
    PlayerPrefs.SetInt("IntPanel", IntPanel); 

    IntPanelSpecial += 1;
    PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial); 

    IntCharacterTheme = 22;
    PlayerPrefs.SetInt("IntCharacterTheme", IntCharacterTheme); 

    RandomObject();
    UpdateInventory();
}

public void StartVolcano ()
{
    IntPanel += 1;
    PlayerPrefs.SetInt("IntPanel", IntPanel); 

    IntPanelSpecial += 1;
    PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial); 

    IntCharacterTheme = 23;
    PlayerPrefs.SetInt("IntCharacterTheme", IntCharacterTheme); 

    RandomObject();
    UpdateInventory();
}

public void StartNightSky ()
{
    IntPanel += 1;
    PlayerPrefs.SetInt("IntPanel", IntPanel); 

    IntPanelSpecial += 1;
    PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial); 

    IntCharacterTheme = 24;
    PlayerPrefs.SetInt("IntCharacterTheme", IntCharacterTheme); 

    RandomObject();
    UpdateInventory();
}

public void StartAutumn ()
{
    IntPanel += 1;
    PlayerPrefs.SetInt("IntPanel", IntPanel); 

    IntPanelSpecial += 1;
    PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial); 

    IntCharacterTheme = 25;
    PlayerPrefs.SetInt("IntCharacterTheme", IntCharacterTheme); 

    RandomObject();
    UpdateInventory();
}

public void StartDinosaurus ()
{
    IntPanel += 1;
    PlayerPrefs.SetInt("IntPanel", IntPanel); 

    IntPanelSpecial += 1;
    PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial); 

    IntCharacterTheme = 26;
    PlayerPrefs.SetInt("IntCharacterTheme", IntCharacterTheme); 

    RandomObject();
    UpdateInventory();
}

public void StartAquarium ()
{
    IntPanel += 1;
    PlayerPrefs.SetInt("IntPanel", IntPanel); 

    IntPanelSpecial += 1;
    PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial); 

    IntCharacterTheme = 27;
    PlayerPrefs.SetInt("IntCharacterTheme", IntCharacterTheme); 

    RandomObject();
    UpdateInventory();
}

public void StartSpace ()
{
    IntPanel += 1;
    PlayerPrefs.SetInt("IntPanel", IntPanel); 

    IntPanelSpecial += 1;
    PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial); 

    IntCharacterTheme = 28;
    PlayerPrefs.SetInt("IntCharacterTheme", IntCharacterTheme); 

    RandomObject();
    UpdateInventory();
}

public void StartRain ()
{
    IntPanel += 1;
    PlayerPrefs.SetInt("IntPanel", IntPanel); 

    IntPanelSpecial += 1;
    PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial); 

    IntCharacterTheme = 29;
    PlayerPrefs.SetInt("IntCharacterTheme", IntCharacterTheme); 

    RandomObject();
    UpdateInventory();
}

private void RandomObject ()
{
    int RandomCharacter = UnityEngine.Random.Range(1, 16);

    if (RandomCharacter == 1){
    if (IntFirst == 1){
        RandomObject();
    }
    else if (IntFirst == 0){
        IntPanel = 1;
        ObjectFirst.SetActive(true);
    }
    }

    if (RandomCharacter == 2){
    if (IntSecond == 1){
        RandomObject();
    }
    else if (IntSecond == 0){
        IntPanel = 2;
        ObjectSecond.SetActive(true);
    }
    }

    if (RandomCharacter == 3){
    if (IntThirt == 1){
        RandomObject();
    }
    else if (IntThirt == 0){
        IntPanel = 3;
        ObjectThirt.SetActive(true);
    }
    }

    if (RandomCharacter == 4){
    if (IntFour == 1){
        RandomObject();
    }
    else if (IntFour == 0){
        IntPanel = 4;
        ObjectFour.SetActive(true);
    }
    }

    if (RandomCharacter == 5){
    if (IntFive == 1){
        RandomObject();
    }
    else if (IntFive == 0){
        IntPanel = 5;
        ObjectFive.SetActive(true);
    }
    }

    if (RandomCharacter == 6){
    if (IntSix == 1){
      RandomObject();
    }
    else if (IntSix == 0){
        IntPanel = 6;
        ObjectSix.SetActive(true);
    }
    }

    if (RandomCharacter == 7){
    if (IntSeven == 1){
        RandomObject();
    }
    else if (IntSeven == 0){
        IntPanel = 7;
        ObjectSeven.SetActive(true);
    }
    }

    if (RandomCharacter == 8){
    if (IntEight == 1){
        RandomObject();
    }
    else if (IntEight == 0){
        IntPanel = 8;
        ObjectEight.SetActive(true);
    }
    }

    if (RandomCharacter == 9){
    if (IntNine == 1){
        RandomObject();
    }
    else if (IntNine == 0){
        IntPanel = 9;
        ObjectNine.SetActive(true);
    }
    }

    if (RandomCharacter == 10){
    if (IntTen == 1){
        RandomObject();
    }
    else if (IntTen == 0){
        IntPanel = 10;
        ObjectTen.SetActive(true);
    }
    }

    if (RandomCharacter == 11){
    if (IntEleven == 1){
        RandomObject();
    }
    else if (IntEleven == 0){
        IntPanel = 11;
        ObjectEleven.SetActive(true);
    }
    }

    if (RandomCharacter == 12){
    if (IntTwelve == 1){
        RandomObject();
    }
    else if (IntTwelve == 0){
        IntPanel = 12;
        ObjectTwelve.SetActive(true);
    }
    }

    if (RandomCharacter == 13){
    if (IntThreeteen == 1){
        RandomObject();
    }
    else if (IntThreeteen == 0){
        IntPanel = 13;
        ObjectThreeteen.SetActive(true);
    }
    }

    if (RandomCharacter == 14){
    if (IntFourteen == 1){
        RandomObject();
    }
    else if (IntFourteen == 0){
        IntPanel = 14;
        ObjectFourteen.SetActive(true);
    }
    }

    if (RandomCharacter == 15){
    if (IntFiveteen == 1){
        RandomObject();
    }
    else if (IntFiveteen == 0){
        IntPanel = 15;
        ObjectFiveteen.SetActive(true);
    }
    }

    PlayerPrefs.SetInt("IntPanel", IntPanel); 
}

private void SelectSprites ()
{
    IntCharacterFirst = PlayerPrefs.GetInt("IntCharacterFirst");
    IntFirst = PlayerPrefs.GetInt("IntFirst");

    IntCharacterSecond = PlayerPrefs.GetInt("IntCharacterSecond");
    IntSecond = PlayerPrefs.GetInt("IntSecond");

    IntCharacterThirt = PlayerPrefs.GetInt("IntCharacterThirt");
    IntThirt = PlayerPrefs.GetInt("IntThirt");

    IntCharacterFour = PlayerPrefs.GetInt("IntCharacterFour");
    IntFour = PlayerPrefs.GetInt("IntFour");

    IntCharacterFive = PlayerPrefs.GetInt("IntCharacterFive");
    IntFive = PlayerPrefs.GetInt("IntFive");

    IntCharacterSix = PlayerPrefs.GetInt("IntCharacterSix");
    IntSix = PlayerPrefs.GetInt("IntSix");

    IntCharacterSeven = PlayerPrefs.GetInt("IntCharacterSeven");
    IntSeven = PlayerPrefs.GetInt("IntSeven");

    IntCharacterEight = PlayerPrefs.GetInt("IntCharacterEight");
    IntEight = PlayerPrefs.GetInt("IntEight");

    IntCharacterNine = PlayerPrefs.GetInt("IntCharacterNine");
    IntNine = PlayerPrefs.GetInt("IntNine");

    IntCharacterTen = PlayerPrefs.GetInt("IntCharacterTen");
    IntTen = PlayerPrefs.GetInt("IntTen");

    IntCharacterEleven = PlayerPrefs.GetInt("IntCharacterEleven");
    IntCharacterTwelve = PlayerPrefs.GetInt("IntCharacterTwelve");
    IntCharacterThirteen = PlayerPrefs.GetInt("IntCharacterThirteen");
    IntCharacterFourteen = PlayerPrefs.GetInt("IntCharacterFourteen");
    IntCharacterFifteen = PlayerPrefs.GetInt("IntCharacterFifteen");

if (IntFirst == 1)
{
    ObjectFirst.SetActive(true);
    if (IntCharacterFirst == 1){
    PanelFirst.GetComponent<Image>().sprite = Star_Character;
    }
    if (IntCharacterFirst == 2){
    PanelFirst.GetComponent<Image>().sprite = Cupcake_Character;
    }
    if (IntCharacterFirst == 3){
    PanelFirst.GetComponent<Image>().sprite = Heart_Character;
    }
    if (IntCharacterFirst == 4){
    PanelFirst.GetComponent<Image>().sprite = Ballon_Character;
    }
    if (IntCharacterFirst == 5){
    PanelFirst.GetComponent<Image>().sprite = Crab_Character;
    }
    if (IntCharacterFirst == 6){
    PanelFirst.GetComponent<Image>().sprite = Ghost_Character;
    }
    if (IntCharacterFirst == 7){
    PanelFirst.GetComponent<Image>().sprite = Squid_Character;
    }
    if (IntCharacterFirst == 8){
    PanelFirst.GetComponent<Image>().sprite = Flame_Character;
    }
    if (IntCharacterFirst == 9){
    PanelFirst.GetComponent<Image>().sprite = Strawberry_Character;
    }
    if (IntCharacterFirst == 10){
    PanelFirst.GetComponent<Image>().sprite = Head_Character;
    }
    if (IntCharacterFirst == 11){
    PanelFirst.GetComponent<Image>().sprite = Slime_Character;
    }
    if (IntCharacterFirst == 12){
    PanelFirst.GetComponent<Image>().sprite = Bunny_Character;
    }
    if (IntCharacterFirst == 13){
    PanelFirst.GetComponent<Image>().sprite = Mushroom_Character;
    }
    if (IntCharacterFirst == 14){
    PanelFirst.GetComponent<Image>().sprite = IceCream_Character;
    }
    if (IntCharacterFirst == 15){
    PanelFirst.GetComponent<Image>().sprite = Bear_Character;
    }
    if (IntCharacterFirst == 16){
    PanelFirst.GetComponent<Image>().sprite = Flower_Character;
    }
    if (IntCharacterFirst == 17){
    PanelFirst.GetComponent<Image>().sprite = JellyFish_Character;
    }
    if (IntCharacterFirst == 18){
    PanelFirst.GetComponent<Image>().sprite = Flowers_Theme;
    }
    if (IntCharacterFirst == 19){
    PanelFirst.GetComponent<Image>().sprite = Pyramids_Theme;
    }
    if (IntCharacterFirst == 20){
    PanelFirst.GetComponent<Image>().sprite = Desert_Theme;
    }
    if (IntCharacterFirst == 21){
    PanelFirst.GetComponent<Image>().sprite = Snow_Theme;
    }
    if (IntCharacterFirst == 22){
    PanelFirst.GetComponent<Image>().sprite = Island_Theme;
    }
    if (IntCharacterFirst == 23){
    PanelFirst.GetComponent<Image>().sprite = Volcano_Theme;
    }
    if (IntCharacterFirst == 24){
    PanelFirst.GetComponent<Image>().sprite = NightSky_Theme;
    }
    if (IntCharacterFirst == 25){
    PanelFirst.GetComponent<Image>().sprite = Autumn_Theme;
    }
    if (IntCharacterFirst == 26){
    PanelFirst.GetComponent<Image>().sprite = Dinosaurus_Theme;
    }
    if (IntCharacterFirst == 27){
    PanelFirst.GetComponent<Image>().sprite = Aquarium_Theme;
    }
    if (IntCharacterFirst == 28){
    PanelFirst.GetComponent<Image>().sprite = Space_Theme;
    }
    if (IntCharacterFirst == 29){
    PanelFirst.GetComponent<Image>().sprite = Rain_Theme;
    }
}
if (IntSecond == 1)
{
    ObjectSecond.SetActive(true);
    if (IntCharacterSecond == 1){
    PanelSecond.GetComponent<Image>().sprite = Star_Character;
    }
    if (IntCharacterSecond == 2){
    PanelSecond.GetComponent<Image>().sprite = Cupcake_Character;
    }
    if (IntCharacterSecond == 3){
    PanelSecond.GetComponent<Image>().sprite = Heart_Character;
    }
    if (IntCharacterSecond == 4){
    PanelSecond.GetComponent<Image>().sprite = Ballon_Character;
    }
    if (IntCharacterSecond == 5){
    PanelSecond.GetComponent<Image>().sprite = Crab_Character;
    }
    if (IntCharacterSecond == 6){
    PanelSecond.GetComponent<Image>().sprite = Ghost_Character;
    }
    if (IntCharacterSecond == 7){
    PanelSecond.GetComponent<Image>().sprite = Squid_Character;
    }
    if (IntCharacterSecond == 8){
    PanelSecond.GetComponent<Image>().sprite = Flame_Character;
    }
    if (IntCharacterSecond == 9){
    PanelSecond.GetComponent<Image>().sprite = Strawberry_Character;
    }
    if (IntCharacterSecond == 10){
    PanelSecond.GetComponent<Image>().sprite = Head_Character;
    }
    if (IntCharacterSecond == 11){
    PanelSecond.GetComponent<Image>().sprite = Slime_Character;
    }
    if (IntCharacterSecond == 12){
    PanelSecond.GetComponent<Image>().sprite = Bunny_Character;
    }
    if (IntCharacterSecond == 13){
    PanelSecond.GetComponent<Image>().sprite = Mushroom_Character;
    }
    if (IntCharacterSecond == 14){
    PanelSecond.GetComponent<Image>().sprite = IceCream_Character;
    }
    if (IntCharacterSecond == 15){
    PanelSecond.GetComponent<Image>().sprite = Bear_Character;
    }
    if (IntCharacterSecond == 16){
    PanelSecond.GetComponent<Image>().sprite = Flower_Character;
    }
    if (IntCharacterSecond == 17){
    PanelSecond.GetComponent<Image>().sprite = JellyFish_Character;
    }
    if (IntCharacterSecond == 18){
    PanelSecond.GetComponent<Image>().sprite = Flowers_Theme;
    }
    if (IntCharacterSecond == 19){
    PanelSecond.GetComponent<Image>().sprite = Pyramids_Theme;
    }
    if (IntCharacterSecond == 20){
    PanelSecond.GetComponent<Image>().sprite = Desert_Theme;
    }
    if (IntCharacterSecond == 21){
    PanelSecond.GetComponent<Image>().sprite = Snow_Theme;
    }
    if (IntCharacterSecond == 22){
    PanelSecond.GetComponent<Image>().sprite = Island_Theme;
    }
    if (IntCharacterSecond == 23){
    PanelSecond.GetComponent<Image>().sprite = Volcano_Theme;
    }
    if (IntCharacterSecond == 24){
    PanelSecond.GetComponent<Image>().sprite = NightSky_Theme;
    }
    if (IntCharacterSecond == 25){
    PanelSecond.GetComponent<Image>().sprite = Autumn_Theme;
    }
    if (IntCharacterSecond == 26){
    PanelSecond.GetComponent<Image>().sprite = Dinosaurus_Theme;
    }
    if (IntCharacterSecond == 27){
    PanelSecond.GetComponent<Image>().sprite = Aquarium_Theme;
    }
    if (IntCharacterSecond == 28){
    PanelSecond.GetComponent<Image>().sprite = Space_Theme;
    }
    if (IntCharacterSecond == 29){
    PanelSecond.GetComponent<Image>().sprite = Rain_Theme;
    }
  }
  if (IntThirt == 1){
  ObjectThirt.SetActive(true);
    if (IntCharacterThirt == 1){
    PanelThirt.GetComponent<Image>().sprite = Star_Character;
    }
    if (IntCharacterThirt == 2){
    PanelThirt.GetComponent<Image>().sprite = Cupcake_Character;
    }
    if (IntCharacterThirt == 3){
    PanelThirt.GetComponent<Image>().sprite = Heart_Character;
    }
    if (IntCharacterThirt == 4){
    PanelThirt.GetComponent<Image>().sprite = Ballon_Character;
    }
    if (IntCharacterThirt == 5){
    PanelThirt.GetComponent<Image>().sprite = Crab_Character;
    }
    if (IntCharacterThirt == 6){
    PanelThirt.GetComponent<Image>().sprite = Ghost_Character;
    }
    if (IntCharacterThirt == 7){
    PanelThirt.GetComponent<Image>().sprite = Squid_Character;
    }
    if (IntCharacterThirt == 8){
    PanelThirt.GetComponent<Image>().sprite = Flame_Character;
    }
    if (IntCharacterThirt == 9){
    PanelThirt.GetComponent<Image>().sprite = Strawberry_Character;
    }
    if (IntCharacterThirt == 10){
    PanelThirt.GetComponent<Image>().sprite = Head_Character;
    }
    if (IntCharacterThirt == 11){
    PanelThirt.GetComponent<Image>().sprite = Slime_Character;
    }
    if (IntCharacterThirt == 12){
    PanelThirt.GetComponent<Image>().sprite = Bunny_Character;
    }
    if (IntCharacterThirt == 13){
    PanelThirt.GetComponent<Image>().sprite = Mushroom_Character;
    }
    if (IntCharacterThirt == 14){
    PanelThirt.GetComponent<Image>().sprite = IceCream_Character;
    }
    if (IntCharacterThirt == 15){
    PanelThirt.GetComponent<Image>().sprite = Bear_Character;
    }
    if (IntCharacterThirt == 16){
    PanelThirt.GetComponent<Image>().sprite = Flower_Character;
    }
    if (IntCharacterThirt == 17){
    PanelThirt.GetComponent<Image>().sprite = JellyFish_Character;
    }
    if (IntCharacterThirt == 18){
    PanelThirt.GetComponent<Image>().sprite = Flowers_Theme;
    }
    if (IntCharacterThirt == 19){
    PanelThirt.GetComponent<Image>().sprite = Pyramids_Theme;
    }
    if (IntCharacterThirt == 20){
    PanelThirt.GetComponent<Image>().sprite = Desert_Theme;
    }
    if (IntCharacterThirt == 21){
    PanelThirt.GetComponent<Image>().sprite = Snow_Theme;
    }
    if (IntCharacterThirt == 22){
    PanelThirt.GetComponent<Image>().sprite = Island_Theme;
    }
    if (IntCharacterThirt == 23){
    PanelThirt.GetComponent<Image>().sprite = Volcano_Theme;
    }
    if (IntCharacterThirt == 24){
    PanelThirt.GetComponent<Image>().sprite = NightSky_Theme;
    }
    if (IntCharacterThirt == 25){
    PanelThirt.GetComponent<Image>().sprite = Autumn_Theme;
    }
    if (IntCharacterThirt == 26){
    PanelThirt.GetComponent<Image>().sprite = Dinosaurus_Theme;
    }
    if (IntCharacterThirt == 27){
    PanelThirt.GetComponent<Image>().sprite = Aquarium_Theme;
    }
    if (IntCharacterThirt == 28){
    PanelThirt.GetComponent<Image>().sprite = Space_Theme;
    }
    if (IntCharacterThirt == 29){
    PanelThirt.GetComponent<Image>().sprite = Rain_Theme;
    }
  }
  if (IntFour == 1){
  ObjectFour.SetActive(true);
    if (IntCharacterFour == 1){
    PanelFour.GetComponent<Image>().sprite = Star_Character;
    }
    if (IntCharacterFour == 2){
    PanelFour.GetComponent<Image>().sprite = Cupcake_Character;
    }
    if (IntCharacterFour == 3){
    PanelFour.GetComponent<Image>().sprite = Heart_Character;
    }
    if (IntCharacterFour == 4){
    PanelFour.GetComponent<Image>().sprite = Ballon_Character;
    }
    if (IntCharacterFour == 5){
    PanelFour.GetComponent<Image>().sprite = Crab_Character;
    }
    if (IntCharacterFour == 6){
    PanelFour.GetComponent<Image>().sprite = Ghost_Character;
    }
    if (IntCharacterFour == 7){
    PanelFour.GetComponent<Image>().sprite = Squid_Character;
    }
    if (IntCharacterFour == 8){
    PanelFour.GetComponent<Image>().sprite = Flame_Character;
    }
    if (IntCharacterFour == 9){
    PanelFour.GetComponent<Image>().sprite = Strawberry_Character;
    }
    if (IntCharacterFour == 10){
    PanelFour.GetComponent<Image>().sprite = Head_Character;
    }
    if (IntCharacterFour == 11){
    PanelFour.GetComponent<Image>().sprite = Slime_Character;
    }
    if (IntCharacterFour == 12){
    PanelFour.GetComponent<Image>().sprite = Bunny_Character;
    }
    if (IntCharacterFour == 13){
    PanelFour.GetComponent<Image>().sprite = Mushroom_Character;
    }
    if (IntCharacterFour == 14){
    PanelFour.GetComponent<Image>().sprite = IceCream_Character;
    }
    if (IntCharacterFour == 15){
    PanelFour.GetComponent<Image>().sprite = Bear_Character;
    }
    if (IntCharacterFour == 16){
    PanelFour.GetComponent<Image>().sprite = Flower_Character;
    }
    if (IntCharacterFour == 17){
    PanelFour.GetComponent<Image>().sprite = JellyFish_Character;
    }
    if (IntCharacterFour == 18){
    PanelFour.GetComponent<Image>().sprite = Flowers_Theme;
    }
    if (IntCharacterFour == 19){
    PanelFour.GetComponent<Image>().sprite = Pyramids_Theme;
    }
    if (IntCharacterFour == 20){
    PanelFour.GetComponent<Image>().sprite = Desert_Theme;
    }
    if (IntCharacterFour == 21){
    PanelFour.GetComponent<Image>().sprite = Snow_Theme;
    }
    if (IntCharacterFour == 22){
    PanelFour.GetComponent<Image>().sprite = Island_Theme;
    }
    if (IntCharacterFour == 23){
    PanelFour.GetComponent<Image>().sprite = Volcano_Theme;
    }
    if (IntCharacterFour == 24){
    PanelFour.GetComponent<Image>().sprite = NightSky_Theme;
    }
    if (IntCharacterFour == 25){
    PanelFour.GetComponent<Image>().sprite = Autumn_Theme;
    }
    if (IntCharacterFour == 26){
    PanelFour.GetComponent<Image>().sprite = Dinosaurus_Theme;
    }
    if (IntCharacterFour == 27){
    PanelFour.GetComponent<Image>().sprite = Aquarium_Theme;
    }
    if (IntCharacterFour == 28){
    PanelFour.GetComponent<Image>().sprite = Space_Theme;
    }
    if (IntCharacterFour == 29){
    PanelFour.GetComponent<Image>().sprite = Rain_Theme;
    }
  }
  if (IntFive == 1){
  ObjectFive.SetActive(true);
    if (IntCharacterFive == 1){
    PanelFive.GetComponent<Image>().sprite = Star_Character;
    }
    if (IntCharacterFive == 2){
    PanelFive.GetComponent<Image>().sprite = Cupcake_Character;
    }
    if (IntCharacterFive == 3){
    PanelFive.GetComponent<Image>().sprite = Heart_Character;
    }
    if (IntCharacterFive == 4){
    PanelFive.GetComponent<Image>().sprite = Ballon_Character;
    }
    if (IntCharacterFive == 5){
    PanelFive.GetComponent<Image>().sprite = Crab_Character;
    }
    if (IntCharacterFive == 6){
    PanelFive.GetComponent<Image>().sprite = Ghost_Character;
    }
    if (IntCharacterFive == 7){
    PanelFive.GetComponent<Image>().sprite = Squid_Character;
    }
    if (IntCharacterFive == 8){
    PanelFive.GetComponent<Image>().sprite = Flame_Character;
    }
    if (IntCharacterFive == 9){
    PanelFive.GetComponent<Image>().sprite = Strawberry_Character;
    }
    if (IntCharacterFive == 10){
    PanelFive.GetComponent<Image>().sprite = Head_Character;
    }
    if (IntCharacterFive == 11){
    PanelFive.GetComponent<Image>().sprite = Slime_Character;
    }
    if (IntCharacterFive == 12){
    PanelFive.GetComponent<Image>().sprite = Bunny_Character;
    }
    if (IntCharacterFive == 13){
    PanelFive.GetComponent<Image>().sprite = Mushroom_Character;
    }
    if (IntCharacterFive == 14){
    PanelFive.GetComponent<Image>().sprite = IceCream_Character;
    }
    if (IntCharacterFive == 15){
    PanelFive.GetComponent<Image>().sprite = Bear_Character;
    }
    if (IntCharacterFive == 16){
    PanelFive.GetComponent<Image>().sprite = Flower_Character;
    }
    if (IntCharacterFive == 17){
    PanelFive.GetComponent<Image>().sprite = JellyFish_Character;
    }
    if (IntCharacterFive == 18){
    PanelFive.GetComponent<Image>().sprite = Flowers_Theme;
    }
    if (IntCharacterFive == 19){
    PanelFive.GetComponent<Image>().sprite = Pyramids_Theme;
    }
    if (IntCharacterFive == 20){
    PanelFive.GetComponent<Image>().sprite = Desert_Theme;
    }
    if (IntCharacterFive == 21){
    PanelFive.GetComponent<Image>().sprite = Snow_Theme;
    }
    if (IntCharacterFive == 22){
    PanelFive.GetComponent<Image>().sprite = Island_Theme;
    }
    if (IntCharacterFive == 23){
    PanelFive.GetComponent<Image>().sprite = Volcano_Theme;
    }
    if (IntCharacterFive == 24){
    PanelFive.GetComponent<Image>().sprite = NightSky_Theme;
    }
    if (IntCharacterFive == 25){
    PanelFive.GetComponent<Image>().sprite = Autumn_Theme;
    }
    if (IntCharacterFive == 26){
    PanelFive.GetComponent<Image>().sprite = Dinosaurus_Theme;
    }
    if (IntCharacterFive == 27){
    PanelFive.GetComponent<Image>().sprite = Aquarium_Theme;
    }
    if (IntCharacterFive == 28){
    PanelFive.GetComponent<Image>().sprite = Space_Theme;
    }
    if (IntCharacterFive == 29){
    PanelFive.GetComponent<Image>().sprite = Rain_Theme;
    }
  }
  if (IntSix == 1){
  ObjectSix.SetActive(true);
    if (IntCharacterSix == 1){
    PanelSix.GetComponent<Image>().sprite = Star_Character;
    }
    if (IntCharacterSix == 2){
    PanelSix.GetComponent<Image>().sprite = Cupcake_Character;
    }
    if (IntCharacterSix == 3){
    PanelSix.GetComponent<Image>().sprite = Heart_Character;
    }
    if (IntCharacterSix == 4){
    PanelSix.GetComponent<Image>().sprite = Ballon_Character;
    }
    if (IntCharacterSix == 5){
    PanelSix.GetComponent<Image>().sprite = Crab_Character;
    }
    if (IntCharacterSix == 6){
    PanelSix.GetComponent<Image>().sprite = Ghost_Character;
    }
    if (IntCharacterSix == 7){
    PanelSix.GetComponent<Image>().sprite = Squid_Character;
    }
    if (IntCharacterSix == 8){
    PanelSix.GetComponent<Image>().sprite = Flame_Character;
    }
    if (IntCharacterSix == 9){
    PanelSix.GetComponent<Image>().sprite = Strawberry_Character;
    }
    if (IntCharacterSix == 10){
    PanelSix.GetComponent<Image>().sprite = Head_Character;
    }
    if (IntCharacterSix == 11){
    PanelSix.GetComponent<Image>().sprite = Slime_Character;
    }
    if (IntCharacterSix == 12){
    PanelSix.GetComponent<Image>().sprite = Bunny_Character;
    }
    if (IntCharacterSix == 13){
    PanelSix.GetComponent<Image>().sprite = Mushroom_Character;
    }
    if (IntCharacterSix == 14){
    PanelSix.GetComponent<Image>().sprite = IceCream_Character;
    }
    if (IntCharacterSix == 15){
    PanelSix.GetComponent<Image>().sprite = Bear_Character;
    }
    if (IntCharacterSix == 16){
    PanelSix.GetComponent<Image>().sprite = Flower_Character;
    }
    if (IntCharacterSix == 17){
    PanelSix.GetComponent<Image>().sprite = JellyFish_Character;
    }
    if (IntCharacterSix == 18){
    PanelSix.GetComponent<Image>().sprite = Flowers_Theme;
    }
    if (IntCharacterSix == 19){
    PanelSix.GetComponent<Image>().sprite = Pyramids_Theme;
    }
    if (IntCharacterSix == 20){
    PanelSix.GetComponent<Image>().sprite = Desert_Theme;
    }
    if (IntCharacterSix == 21){
    PanelSix.GetComponent<Image>().sprite = Snow_Theme;
    }
    if (IntCharacterSix == 22){
    PanelSix.GetComponent<Image>().sprite = Island_Theme;
    }
    if (IntCharacterSix == 23){
    PanelSix.GetComponent<Image>().sprite = Volcano_Theme;
    }
    if (IntCharacterSix == 24){
    PanelSix.GetComponent<Image>().sprite = NightSky_Theme;
    }
    if (IntCharacterSix == 25){
    PanelSix.GetComponent<Image>().sprite = Autumn_Theme;
    }
    if (IntCharacterSix == 26){
    PanelSix.GetComponent<Image>().sprite = Dinosaurus_Theme;
    }
    if (IntCharacterSix == 27){
    PanelSix.GetComponent<Image>().sprite = Aquarium_Theme;
    }
    if (IntCharacterSix == 28){
    PanelSix.GetComponent<Image>().sprite = Space_Theme;
    }
    if (IntCharacterSix == 29){
    PanelSix.GetComponent<Image>().sprite = Rain_Theme;
    }
  }
  if (IntSeven == 1){
  ObjectSeven.SetActive(true);
    if (IntCharacterSeven == 1){
    PanelSeven.GetComponent<Image>().sprite = Star_Character;
    }
    if (IntCharacterSeven == 2){
    PanelSeven.GetComponent<Image>().sprite = Cupcake_Character;
    }
    if (IntCharacterSeven == 3){
    PanelSeven.GetComponent<Image>().sprite = Heart_Character;
    }
    if (IntCharacterSeven == 4){
    PanelSeven.GetComponent<Image>().sprite = Ballon_Character;
    }
    if (IntCharacterSeven == 5){
    PanelSeven.GetComponent<Image>().sprite = Crab_Character;
    }
    if (IntCharacterSeven == 6){
    PanelSeven.GetComponent<Image>().sprite = Ghost_Character;
    }
    if (IntCharacterSeven == 7){
    PanelSeven.GetComponent<Image>().sprite = Squid_Character;
    }
    if (IntCharacterSeven == 8){
    PanelSeven.GetComponent<Image>().sprite = Flame_Character;
    }
    if (IntCharacterSeven == 9){
    PanelSeven.GetComponent<Image>().sprite = Strawberry_Character;
    }
    if (IntCharacterSeven == 10){
    PanelSeven.GetComponent<Image>().sprite = Head_Character;
    }
    if (IntCharacterSeven == 11){
    PanelSeven.GetComponent<Image>().sprite = Slime_Character;
    }
    if (IntCharacterSeven == 12){
    PanelSeven.GetComponent<Image>().sprite = Bunny_Character;
    }
    if (IntCharacterSeven == 13){
    PanelSeven.GetComponent<Image>().sprite = Mushroom_Character;
    }
    if (IntCharacterSeven == 14){
    PanelSeven.GetComponent<Image>().sprite = IceCream_Character;
    }
    if (IntCharacterSeven == 15){
    PanelSeven.GetComponent<Image>().sprite = Bear_Character;
    }
    if (IntCharacterSeven == 16){
    PanelSeven.GetComponent<Image>().sprite = Flower_Character;
    }
    if (IntCharacterSeven == 17){
    PanelSeven.GetComponent<Image>().sprite = JellyFish_Character;
    }
    if (IntCharacterSeven == 18){
    PanelSeven.GetComponent<Image>().sprite = Flowers_Theme;
    }
    if (IntCharacterSeven == 19){
    PanelSeven.GetComponent<Image>().sprite = Pyramids_Theme;
    }
    if (IntCharacterSeven == 20){
    PanelSeven.GetComponent<Image>().sprite = Desert_Theme;
    }
    if (IntCharacterSeven == 21){
    PanelSeven.GetComponent<Image>().sprite = Snow_Theme;
    }
    if (IntCharacterSeven == 22){
    PanelSeven.GetComponent<Image>().sprite = Island_Theme;
    }
    if (IntCharacterSeven == 23){
    PanelSeven.GetComponent<Image>().sprite = Volcano_Theme;
    }
    if (IntCharacterSeven == 24){
    PanelSeven.GetComponent<Image>().sprite = NightSky_Theme;
    }
    if (IntCharacterSeven == 25){
    PanelSeven.GetComponent<Image>().sprite = Autumn_Theme;
    }
    if (IntCharacterSeven == 26){
    PanelSeven.GetComponent<Image>().sprite = Dinosaurus_Theme;
    }
    if (IntCharacterSeven == 27){
    PanelSeven.GetComponent<Image>().sprite = Aquarium_Theme;
    }
    if (IntCharacterSeven == 28){
    PanelSeven.GetComponent<Image>().sprite = Space_Theme;
    }
    if (IntCharacterSeven == 29){
    PanelSeven.GetComponent<Image>().sprite = Rain_Theme;
    }
  }
  if (IntEight == 1){
  ObjectEight.SetActive(true);
    if (IntCharacterEight == 1){
    PanelEight.GetComponent<Image>().sprite = Star_Character;
    }
    if (IntCharacterEight == 2){
    PanelEight.GetComponent<Image>().sprite = Cupcake_Character;
    }
    if (IntCharacterEight == 3){
    PanelEight.GetComponent<Image>().sprite = Heart_Character;
    }
    if (IntCharacterEight == 4){
    PanelEight.GetComponent<Image>().sprite = Ballon_Character;
    }
    if (IntCharacterEight == 5){
    PanelEight.GetComponent<Image>().sprite = Crab_Character;
    }
    if (IntCharacterEight == 6){
    PanelEight.GetComponent<Image>().sprite = Ghost_Character;
    }
    if (IntCharacterEight == 7){
    PanelEight.GetComponent<Image>().sprite = Squid_Character;
    }
    if (IntCharacterEight == 8){
    PanelEight.GetComponent<Image>().sprite = Flame_Character;
    }
    if (IntCharacterEight == 9){
    PanelEight.GetComponent<Image>().sprite = Strawberry_Character;
    }
    if (IntCharacterEight == 10){
    PanelEight.GetComponent<Image>().sprite = Head_Character;
    }
    if (IntCharacterEight == 11){
    PanelEight.GetComponent<Image>().sprite = Slime_Character;
    }
    if (IntCharacterEight == 12){
    PanelEight.GetComponent<Image>().sprite = Bunny_Character;
    }
    if (IntCharacterEight == 13){
    PanelEight.GetComponent<Image>().sprite = Mushroom_Character;
    }
    if (IntCharacterEight == 14){
    PanelEight.GetComponent<Image>().sprite = IceCream_Character;
    }
    if (IntCharacterEight == 15){
    PanelEight.GetComponent<Image>().sprite = Bear_Character;
    }
    if (IntCharacterEight == 16){
    PanelEight.GetComponent<Image>().sprite = Flower_Character;
    }
    if (IntCharacterEight == 17){
    PanelEight.GetComponent<Image>().sprite = JellyFish_Character;
    }
    if (IntCharacterEight == 18){
    PanelEight.GetComponent<Image>().sprite = Flowers_Theme;
    }
    if (IntCharacterEight == 19){
    PanelEight.GetComponent<Image>().sprite = Pyramids_Theme;
    }
    if (IntCharacterEight == 20){
    PanelEight.GetComponent<Image>().sprite = Desert_Theme;
    }
    if (IntCharacterEight == 21){
    PanelEight.GetComponent<Image>().sprite = Snow_Theme;
    }
    if (IntCharacterEight == 22){
    PanelEight.GetComponent<Image>().sprite = Island_Theme;
    }
    if (IntCharacterEight == 23){
    PanelEight.GetComponent<Image>().sprite = Volcano_Theme;
    }
    if (IntCharacterEight == 24){
    PanelEight.GetComponent<Image>().sprite = NightSky_Theme;
    }
    if (IntCharacterEight == 25){
    PanelEight.GetComponent<Image>().sprite = Autumn_Theme;
    }
    if (IntCharacterEight == 26){
    PanelEight.GetComponent<Image>().sprite = Dinosaurus_Theme;
    }
    if (IntCharacterEight == 27){
    PanelEight.GetComponent<Image>().sprite = Aquarium_Theme;
    }
    if (IntCharacterEight == 28){
    PanelEight.GetComponent<Image>().sprite = Space_Theme;
    }
    if (IntCharacterEight == 29){
    PanelEight.GetComponent<Image>().sprite = Rain_Theme;
    }
  }
  if (IntNine == 1){
  ObjectNine.SetActive(true);
    if (IntCharacterNine == 1){
    PanelNine.GetComponent<Image>().sprite = Star_Character;
    }
    if (IntCharacterNine == 2){
    PanelNine.GetComponent<Image>().sprite = Cupcake_Character;
    }
    if (IntCharacterNine == 3){
    PanelNine.GetComponent<Image>().sprite = Heart_Character;
    }
    if (IntCharacterNine == 4){
    PanelNine.GetComponent<Image>().sprite = Ballon_Character;
    }
    if (IntCharacterNine == 5){
    PanelNine.GetComponent<Image>().sprite = Crab_Character;
    }
    if (IntCharacterNine == 6){
    PanelNine.GetComponent<Image>().sprite = Ghost_Character;
    }
    if (IntCharacterNine == 7){
    PanelNine.GetComponent<Image>().sprite = Squid_Character;
    }
    if (IntCharacterNine == 8){
    PanelNine.GetComponent<Image>().sprite = Flame_Character;
    }
    if (IntCharacterNine == 9){
    PanelNine.GetComponent<Image>().sprite = Strawberry_Character;
    }
    if (IntCharacterNine == 10){
    PanelNine.GetComponent<Image>().sprite = Head_Character;
    }
    if (IntCharacterNine == 11){
    PanelNine.GetComponent<Image>().sprite = Slime_Character;
    }
    if (IntCharacterNine == 12){
    PanelNine.GetComponent<Image>().sprite = Bunny_Character;
    }
    if (IntCharacterNine == 13){
    PanelNine.GetComponent<Image>().sprite = Mushroom_Character;
    }
    if (IntCharacterNine == 14){
    PanelNine.GetComponent<Image>().sprite = IceCream_Character;
    }
    if (IntCharacterNine == 15){
    PanelNine.GetComponent<Image>().sprite = Bear_Character;
    }
    if (IntCharacterNine == 16){
    PanelNine.GetComponent<Image>().sprite = Flower_Character;
    }
    if (IntCharacterNine == 17){
    PanelNine.GetComponent<Image>().sprite = JellyFish_Character;
    }
    if (IntCharacterNine == 18){
    PanelNine.GetComponent<Image>().sprite = Flowers_Theme;
    }
    if (IntCharacterNine == 19){
    PanelNine.GetComponent<Image>().sprite = Pyramids_Theme;
    }
    if (IntCharacterNine == 20){
    PanelNine.GetComponent<Image>().sprite = Desert_Theme;
    }
    if (IntCharacterNine == 21){
    PanelNine.GetComponent<Image>().sprite = Snow_Theme;
    }
    if (IntCharacterNine == 22){
    PanelNine.GetComponent<Image>().sprite = Island_Theme;
    }
    if (IntCharacterNine == 23){
    PanelNine.GetComponent<Image>().sprite = Volcano_Theme;
    }
    if (IntCharacterNine == 24){
    PanelNine.GetComponent<Image>().sprite = NightSky_Theme;
    }
    if (IntCharacterNine == 25){
    PanelNine.GetComponent<Image>().sprite = Autumn_Theme;
    }
    if (IntCharacterNine == 26){
    PanelNine.GetComponent<Image>().sprite = Dinosaurus_Theme;
    }
    if (IntCharacterNine == 27){
    PanelNine.GetComponent<Image>().sprite = Aquarium_Theme;
    }
    if (IntCharacterNine == 28){
    PanelNine.GetComponent<Image>().sprite = Space_Theme;
    }
    if (IntCharacterNine == 29){
    PanelNine.GetComponent<Image>().sprite = Rain_Theme;
    }
  }
  if (IntTen == 1){
  ObjectTen.SetActive(true);
    if (IntCharacterTen == 1){
    PanelTen.GetComponent<Image>().sprite = Star_Character;
    }
    if (IntCharacterTen == 2){
    PanelTen.GetComponent<Image>().sprite = Cupcake_Character;
    }
    if (IntCharacterTen == 3){
    PanelTen.GetComponent<Image>().sprite = Heart_Character;
    }
    if (IntCharacterTen == 4){
    PanelTen.GetComponent<Image>().sprite = Ballon_Character;
    }
    if (IntCharacterTen == 5){
    PanelTen.GetComponent<Image>().sprite = Crab_Character;
    }
    if (IntCharacterTen == 6){
    PanelTen.GetComponent<Image>().sprite = Ghost_Character;
    }
    if (IntCharacterTen == 7){
    PanelTen.GetComponent<Image>().sprite = Squid_Character;
    }
    if (IntCharacterTen == 8){
    PanelTen.GetComponent<Image>().sprite = Flame_Character;
    }
    if (IntCharacterTen == 9){
    PanelTen.GetComponent<Image>().sprite = Strawberry_Character;
    }
    if (IntCharacterTen == 10){
    PanelTen.GetComponent<Image>().sprite = Head_Character;
    }
    if (IntCharacterTen == 11){
    PanelTen.GetComponent<Image>().sprite = Slime_Character;
    }
    if (IntCharacterTen == 12){
    PanelTen.GetComponent<Image>().sprite = Bunny_Character;
    }
    if (IntCharacterTen == 13){
    PanelTen.GetComponent<Image>().sprite = Mushroom_Character;
    }
    if (IntCharacterTen == 14){
    PanelTen.GetComponent<Image>().sprite = IceCream_Character;
    }
    if (IntCharacterTen == 15){
    PanelTen.GetComponent<Image>().sprite = Bear_Character;
    }
    if (IntCharacterTen == 16){
    PanelTen.GetComponent<Image>().sprite = Flower_Character;
    }
    if (IntCharacterTen == 17){
    PanelTen.GetComponent<Image>().sprite = JellyFish_Character;
    }
    if (IntCharacterTen == 18){
    PanelTen.GetComponent<Image>().sprite = Flowers_Theme;
    }
    if (IntCharacterTen == 19){
    PanelTen.GetComponent<Image>().sprite = Pyramids_Theme;
    }
    if (IntCharacterTen == 20){
    PanelTen.GetComponent<Image>().sprite = Desert_Theme;
    }
    if (IntCharacterTen == 21){
    PanelTen.GetComponent<Image>().sprite = Snow_Theme;
    }
    if (IntCharacterTen == 22){
    PanelTen.GetComponent<Image>().sprite = Island_Theme;
    }
    if (IntCharacterTen == 23){
    PanelTen.GetComponent<Image>().sprite = Volcano_Theme;
    }
    if (IntCharacterTen == 24){
    PanelTen.GetComponent<Image>().sprite = NightSky_Theme;
    }
    if (IntCharacterTen == 25){
    PanelTen.GetComponent<Image>().sprite = Autumn_Theme;
    }
    if (IntCharacterTen == 26){
    PanelTen.GetComponent<Image>().sprite = Dinosaurus_Theme;
    }
    if (IntCharacterTen == 27){
    PanelTen.GetComponent<Image>().sprite = Aquarium_Theme;
    }
    if (IntCharacterTen == 28){
    PanelTen.GetComponent<Image>().sprite = Space_Theme;
    }
    if (IntCharacterTen == 29){
    PanelTen.GetComponent<Image>().sprite = Rain_Theme;
    }
  }
  if (IntEleven == 1){
  ObjectEleven.SetActive(true);
    if (IntCharacterEleven == 1){
    PanelEleven.GetComponent<Image>().sprite = Star_Character;
    }
    if (IntCharacterEleven == 2){
    PanelEleven.GetComponent<Image>().sprite = Cupcake_Character;
    }
    if (IntCharacterEleven == 3){
    PanelEleven.GetComponent<Image>().sprite = Heart_Character;
    }
    if (IntCharacterEleven == 4){
    PanelEleven.GetComponent<Image>().sprite = Ballon_Character;
    }
    if (IntCharacterEleven == 5){
    PanelEleven.GetComponent<Image>().sprite = Crab_Character;
    }
    if (IntCharacterEleven == 6){
    PanelEleven.GetComponent<Image>().sprite = Ghost_Character;
    }
    if (IntCharacterEleven == 7){
    PanelEleven.GetComponent<Image>().sprite = Squid_Character;
    }
    if (IntCharacterEleven == 8){
    PanelEleven.GetComponent<Image>().sprite = Flame_Character;
    }
    if (IntCharacterEleven == 9){
    PanelEleven.GetComponent<Image>().sprite = Strawberry_Character;
    }
    if (IntCharacterEleven == 10){
    PanelEleven.GetComponent<Image>().sprite = Head_Character;
    }
    if (IntCharacterEleven == 11){
    PanelEleven.GetComponent<Image>().sprite = Slime_Character;
    }
    if (IntCharacterEleven == 12){
    PanelEleven.GetComponent<Image>().sprite = Bunny_Character;
    }
    if (IntCharacterEleven == 13){
    PanelEleven.GetComponent<Image>().sprite = Mushroom_Character;
    }
    if (IntCharacterEleven == 14){
    PanelEleven.GetComponent<Image>().sprite = IceCream_Character;
    }
    if (IntCharacterEleven == 15){
    PanelEleven.GetComponent<Image>().sprite = Bear_Character;
    }
    if (IntCharacterEleven == 16){
    PanelEleven.GetComponent<Image>().sprite = Flower_Character;
    }
    if (IntCharacterEleven == 17){
    PanelEleven.GetComponent<Image>().sprite = JellyFish_Character;
    }
    if (IntCharacterEleven == 18){
    PanelEleven.GetComponent<Image>().sprite = Flowers_Theme;
    }
    if (IntCharacterEleven == 19){
    PanelEleven.GetComponent<Image>().sprite = Pyramids_Theme;
    }
    if (IntCharacterEleven == 20){
    PanelEleven.GetComponent<Image>().sprite = Desert_Theme;
    }
    if (IntCharacterEleven == 21){
    PanelEleven.GetComponent<Image>().sprite = Snow_Theme;
    }
    if (IntCharacterEleven == 22){
    PanelEleven.GetComponent<Image>().sprite = Island_Theme;
    }
    if (IntCharacterEleven == 23){
    PanelEleven.GetComponent<Image>().sprite = Volcano_Theme;
    }
    if (IntCharacterEleven == 24){
    PanelEleven.GetComponent<Image>().sprite = NightSky_Theme;
    }
    if (IntCharacterEleven == 25){
    PanelEleven.GetComponent<Image>().sprite = Autumn_Theme;
    }
    if (IntCharacterEleven == 26){
    PanelEleven.GetComponent<Image>().sprite = Dinosaurus_Theme;
    }
    if (IntCharacterEleven == 27){
    PanelEleven.GetComponent<Image>().sprite = Aquarium_Theme;
    }
    if (IntCharacterEleven == 28){
    PanelEleven.GetComponent<Image>().sprite = Space_Theme;
    }
    if (IntCharacterEleven == 29){
    PanelEleven.GetComponent<Image>().sprite = Rain_Theme;
    }
  }
  if (IntTwelve == 1){
  ObjectTwelve.SetActive(true);
    if (IntCharacterTwelve == 1){
    PanelTwelve.GetComponent<Image>().sprite = Star_Character;
    }
    if (IntCharacterTwelve == 2){
    PanelTwelve.GetComponent<Image>().sprite = Cupcake_Character;
    }
    if (IntCharacterTwelve == 3){
    PanelTwelve.GetComponent<Image>().sprite = Heart_Character;
    }
    if (IntCharacterTwelve == 4){
    PanelTwelve.GetComponent<Image>().sprite = Ballon_Character;
    }
    if (IntCharacterTwelve == 5){
    PanelTwelve.GetComponent<Image>().sprite = Crab_Character;
    }
    if (IntCharacterTwelve == 6){
    PanelTwelve.GetComponent<Image>().sprite = Ghost_Character;
    }
    if (IntCharacterTwelve == 7){
    PanelTwelve.GetComponent<Image>().sprite = Squid_Character;
    }
    if (IntCharacterTwelve == 8){
    PanelTwelve.GetComponent<Image>().sprite = Flame_Character;
    }
    if (IntCharacterTwelve == 9){
    PanelTwelve.GetComponent<Image>().sprite = Strawberry_Character;
    }
    if (IntCharacterTwelve == 10){
    PanelTwelve.GetComponent<Image>().sprite = Head_Character;
    }
    if (IntCharacterTwelve == 11){
    PanelTwelve.GetComponent<Image>().sprite = Slime_Character;
    }
    if (IntCharacterTwelve == 12){
    PanelTwelve.GetComponent<Image>().sprite = Bunny_Character;
    }
    if (IntCharacterTwelve == 13){
    PanelTwelve.GetComponent<Image>().sprite = Mushroom_Character;
    }
    if (IntCharacterTwelve == 14){
    PanelTwelve.GetComponent<Image>().sprite = IceCream_Character;
    }
    if (IntCharacterTwelve == 15){
    PanelTwelve.GetComponent<Image>().sprite = Bear_Character;
    }
    if (IntCharacterTwelve == 16){
    PanelTwelve.GetComponent<Image>().sprite = Flower_Character;
    }
    if (IntCharacterTwelve == 17){
    PanelTwelve.GetComponent<Image>().sprite = JellyFish_Character;
    }
    if (IntCharacterTwelve == 18){
    PanelTwelve.GetComponent<Image>().sprite = Flowers_Theme;
    }
    if (IntCharacterTwelve == 19){
    PanelTwelve.GetComponent<Image>().sprite = Pyramids_Theme;
    }
    if (IntCharacterTwelve == 20){
    PanelTwelve.GetComponent<Image>().sprite = Desert_Theme;
    }
    if (IntCharacterTwelve == 21){
    PanelTwelve.GetComponent<Image>().sprite = Snow_Theme;
    }
    if (IntCharacterTwelve == 22){
    PanelTwelve.GetComponent<Image>().sprite = Island_Theme;
    }
    if (IntCharacterTwelve == 23){
    PanelTwelve.GetComponent<Image>().sprite = Volcano_Theme;
    }
    if (IntCharacterTwelve == 24){
    PanelTwelve.GetComponent<Image>().sprite = NightSky_Theme;
    }
    if (IntCharacterTwelve == 25){
    PanelTwelve.GetComponent<Image>().sprite = Autumn_Theme;
    }
    if (IntCharacterTwelve == 26){
    PanelTwelve.GetComponent<Image>().sprite = Dinosaurus_Theme;
    }
    if (IntCharacterTwelve == 27){
    PanelTwelve.GetComponent<Image>().sprite = Aquarium_Theme;
    }
    if (IntCharacterTwelve == 28){
    PanelTwelve.GetComponent<Image>().sprite = Space_Theme;
    }
    if (IntCharacterTwelve == 29){
    PanelTwelve.GetComponent<Image>().sprite = Rain_Theme;
    }
  }
  if (IntThreeteen == 1){
  ObjectThreeteen.SetActive(true);
    if (IntCharacterThirteen == 1){
    PanelThreeteen.GetComponent<Image>().sprite = Star_Character;
    }
    if (IntCharacterThirteen == 2){
    PanelThreeteen.GetComponent<Image>().sprite = Cupcake_Character;
    }
    if (IntCharacterThirteen == 3){
    PanelThreeteen.GetComponent<Image>().sprite = Heart_Character;
    }
    if (IntCharacterThirteen == 4){
    PanelThreeteen.GetComponent<Image>().sprite = Ballon_Character;
    }
    if (IntCharacterThirteen == 5){
    PanelThreeteen.GetComponent<Image>().sprite = Crab_Character;
    }
    if (IntCharacterThirteen == 6){
    PanelThreeteen.GetComponent<Image>().sprite = Ghost_Character;
    }
    if (IntCharacterThirteen == 7){
    PanelThreeteen.GetComponent<Image>().sprite = Squid_Character;
    }
    if (IntCharacterThirteen == 8){
    PanelThreeteen.GetComponent<Image>().sprite = Flame_Character;
    }
    if (IntCharacterThirteen == 9){
    PanelThreeteen.GetComponent<Image>().sprite = Strawberry_Character;
    }
    if (IntCharacterThirteen == 10){
    PanelThreeteen.GetComponent<Image>().sprite = Head_Character;
    }
    if (IntCharacterThirteen == 11){
    PanelThreeteen.GetComponent<Image>().sprite = Slime_Character;
    }
    if (IntCharacterThirteen == 12){
    PanelThreeteen.GetComponent<Image>().sprite = Bunny_Character;
    }
    if (IntCharacterThirteen == 13){
    PanelThreeteen.GetComponent<Image>().sprite = Mushroom_Character;
    }
    if (IntCharacterThirteen == 14){
    PanelThreeteen.GetComponent<Image>().sprite = IceCream_Character;
    }
    if (IntCharacterThirteen == 15){
    PanelThreeteen.GetComponent<Image>().sprite = Bear_Character;
    }
    if (IntCharacterThirteen == 16){
    PanelThreeteen.GetComponent<Image>().sprite = Flower_Character;
    }
    if (IntCharacterThirteen == 17){
    PanelThreeteen.GetComponent<Image>().sprite = JellyFish_Character;
    }
    if (IntCharacterThirteen == 18){
    PanelThreeteen.GetComponent<Image>().sprite = Flowers_Theme;
    }
    if (IntCharacterThirteen == 19){
    PanelThreeteen.GetComponent<Image>().sprite = Pyramids_Theme;
    }
    if (IntCharacterThirteen == 20){
    PanelThreeteen.GetComponent<Image>().sprite = Desert_Theme;
    }
    if (IntCharacterThirteen == 21){
    PanelThreeteen.GetComponent<Image>().sprite = Snow_Theme;
    }
    if (IntCharacterThirteen == 22){
    PanelThreeteen.GetComponent<Image>().sprite = Island_Theme;
    }
    if (IntCharacterThirteen == 23){
    PanelThreeteen.GetComponent<Image>().sprite = Volcano_Theme;
    }
    if (IntCharacterThirteen == 24){
    PanelThreeteen.GetComponent<Image>().sprite = NightSky_Theme;
    }
    if (IntCharacterThirteen == 25){
    PanelThreeteen.GetComponent<Image>().sprite = Autumn_Theme;
    }
    if (IntCharacterThirteen == 26){
    PanelThreeteen.GetComponent<Image>().sprite = Dinosaurus_Theme;
    }
    if (IntCharacterThirteen == 27){
    PanelThreeteen.GetComponent<Image>().sprite = Aquarium_Theme;
    }
    if (IntCharacterThirteen == 28){
    PanelThreeteen.GetComponent<Image>().sprite = Space_Theme;
    }
    if (IntCharacterThirteen == 29){
    PanelThreeteen.GetComponent<Image>().sprite = Rain_Theme;
    }
  }
  if (IntFourteen == 1){
  ObjectFourteen.SetActive(true);
    if (IntCharacterFourteen == 1){
    PanelFourteen.GetComponent<Image>().sprite = Star_Character;
    }
    if (IntCharacterFourteen == 2){
    PanelFourteen.GetComponent<Image>().sprite = Cupcake_Character;
    }
    if (IntCharacterFourteen == 3){
    PanelFourteen.GetComponent<Image>().sprite = Heart_Character;
    }
    if (IntCharacterFourteen == 4){
    PanelFourteen.GetComponent<Image>().sprite = Ballon_Character;
    }
    if (IntCharacterFourteen == 5){
    PanelFourteen.GetComponent<Image>().sprite = Crab_Character;
    }
    if (IntCharacterFourteen == 6){
    PanelFourteen.GetComponent<Image>().sprite = Ghost_Character;
    }
    if (IntCharacterFourteen == 7){
    PanelFourteen.GetComponent<Image>().sprite = Squid_Character;
    }
    if (IntCharacterFourteen == 8){
    PanelFourteen.GetComponent<Image>().sprite = Flame_Character;
    }
    if (IntCharacterFourteen == 9){
    PanelFourteen.GetComponent<Image>().sprite = Strawberry_Character;
    }
    if (IntCharacterFourteen == 10){
    PanelFourteen.GetComponent<Image>().sprite = Head_Character;
    }
    if (IntCharacterFourteen == 11){
    PanelFourteen.GetComponent<Image>().sprite = Slime_Character;
    }
    if (IntCharacterFourteen == 12){
    PanelFourteen.GetComponent<Image>().sprite = Bunny_Character;
    }
    if (IntCharacterFourteen == 13){
    PanelFourteen.GetComponent<Image>().sprite = Mushroom_Character;
    }
    if (IntCharacterFourteen == 14){
    PanelFourteen.GetComponent<Image>().sprite = IceCream_Character;
    }
    if (IntCharacterFourteen == 15){
    PanelFourteen.GetComponent<Image>().sprite = Bear_Character;
    }
    if (IntCharacterFourteen == 16){
    PanelFourteen.GetComponent<Image>().sprite = Flower_Character;
    }
    if (IntCharacterFourteen == 17){
    PanelFourteen.GetComponent<Image>().sprite = JellyFish_Character;
    }
    if (IntCharacterFourteen == 18){
    PanelFourteen.GetComponent<Image>().sprite = Flowers_Theme;
    }
    if (IntCharacterFourteen == 19){
    PanelFourteen.GetComponent<Image>().sprite = Pyramids_Theme;
    }
    if (IntCharacterFourteen == 20){
    PanelFourteen.GetComponent<Image>().sprite = Desert_Theme;
    }
    if (IntCharacterFourteen == 21){
    PanelFourteen.GetComponent<Image>().sprite = Snow_Theme;
    }
    if (IntCharacterFourteen == 22){
    PanelFourteen.GetComponent<Image>().sprite = Island_Theme;
    }
    if (IntCharacterFourteen == 23){
    PanelFourteen.GetComponent<Image>().sprite = Volcano_Theme;
    }
    if (IntCharacterFourteen == 24){
    PanelFourteen.GetComponent<Image>().sprite = NightSky_Theme;
    }
    if (IntCharacterFourteen == 25){
    PanelFourteen.GetComponent<Image>().sprite = Autumn_Theme;
    }
    if (IntCharacterFourteen == 26){
    PanelFourteen.GetComponent<Image>().sprite = Dinosaurus_Theme;
    }
    if (IntCharacterFourteen == 27){
    PanelFourteen.GetComponent<Image>().sprite = Aquarium_Theme;
    }
    if (IntCharacterFourteen == 28){
    PanelFourteen.GetComponent<Image>().sprite = Space_Theme;
    }
    if (IntCharacterFourteen == 29){
    PanelFourteen.GetComponent<Image>().sprite = Rain_Theme;
    }
  }
  if (IntFiveteen == 1){
  ObjectFiveteen.SetActive(true);
    if (IntCharacterFifteen == 1){
    PanelFiveteen.GetComponent<Image>().sprite = Star_Character;
    }
    if (IntCharacterFifteen == 2){
    PanelFiveteen.GetComponent<Image>().sprite = Cupcake_Character;
    }
    if (IntCharacterFifteen == 3){
    PanelFiveteen.GetComponent<Image>().sprite = Heart_Character;
    }
    if (IntCharacterFifteen == 4){
    PanelFiveteen.GetComponent<Image>().sprite = Ballon_Character;
    }
    if (IntCharacterFifteen == 5){
    PanelFiveteen.GetComponent<Image>().sprite = Crab_Character;
    }
    if (IntCharacterFifteen == 6){
    PanelFiveteen.GetComponent<Image>().sprite = Ghost_Character;
    }
    if (IntCharacterFifteen == 7){
    PanelFiveteen.GetComponent<Image>().sprite = Squid_Character;
    }
    if (IntCharacterFifteen == 8){
    PanelFiveteen.GetComponent<Image>().sprite = Flame_Character;
    }
    if (IntCharacterFifteen == 9){
    PanelFiveteen.GetComponent<Image>().sprite = Strawberry_Character;
    }
    if (IntCharacterFifteen == 10){
    PanelFiveteen.GetComponent<Image>().sprite = Head_Character;
    }
    if (IntCharacterFifteen == 11){
    PanelFiveteen.GetComponent<Image>().sprite = Slime_Character;
    }
    if (IntCharacterFifteen == 12){
    PanelFiveteen.GetComponent<Image>().sprite = Bunny_Character;
    }
    if (IntCharacterFifteen == 13){
    PanelFiveteen.GetComponent<Image>().sprite = Mushroom_Character;
    }
    if (IntCharacterFifteen == 14){
    PanelFiveteen.GetComponent<Image>().sprite = IceCream_Character;
    }
    if (IntCharacterFifteen == 15){
    PanelFiveteen.GetComponent<Image>().sprite = Bear_Character;
    }
    if (IntCharacterFifteen == 16){
    PanelFiveteen.GetComponent<Image>().sprite = Flower_Character;
    }
    if (IntCharacterFifteen == 17){
    PanelFiveteen.GetComponent<Image>().sprite = JellyFish_Character;
    }
    if (IntCharacterFifteen == 18){
    PanelFiveteen.GetComponent<Image>().sprite = Flowers_Theme;
    }
    if (IntCharacterFifteen == 19){
    PanelFiveteen.GetComponent<Image>().sprite = Pyramids_Theme;
    }
    if (IntCharacterFifteen == 20){
    PanelFiveteen.GetComponent<Image>().sprite = Desert_Theme;
    }
    if (IntCharacterFifteen == 21){
    PanelFiveteen.GetComponent<Image>().sprite = Snow_Theme;
    }
    if (IntCharacterFifteen == 22){
    PanelFiveteen.GetComponent<Image>().sprite = Island_Theme;
    }
    if (IntCharacterFifteen == 23){
    PanelFiveteen.GetComponent<Image>().sprite = Volcano_Theme;
    }
    if (IntCharacterFifteen == 24){
    PanelFiveteen.GetComponent<Image>().sprite = NightSky_Theme;
    }
    if (IntCharacterFifteen == 25){
    PanelFiveteen.GetComponent<Image>().sprite = Autumn_Theme;
    }
    if (IntCharacterFifteen == 26){
    PanelFiveteen.GetComponent<Image>().sprite = Dinosaurus_Theme;
    }
    if (IntCharacterFifteen == 27){
    PanelFiveteen.GetComponent<Image>().sprite = Aquarium_Theme;
    }
    if (IntCharacterFifteen == 28){
    PanelFiveteen.GetComponent<Image>().sprite = Space_Theme;
    }
    if (IntCharacterFifteen == 29){
    PanelFiveteen.GetComponent<Image>().sprite = Rain_Theme;
    }
  }
}

private void UpdateInventory ()
{
    IntCharacterTheme = PlayerPrefs.GetInt("IntCharacterTheme");
    IntPanel = PlayerPrefs.GetInt("IntPanel");

    if (IntPanel == 1){

      if (IntFirst == 0)
      {
        LastTimeFirst = (ulong)DateTime.Now.Ticks;
        PlayerPrefs.SetString("FirstTable", LastTimeFirst.ToString());
      } 

      IntFirst = 1;
      PlayerPrefs.SetInt("IntFirst", IntFirst);

      GameObjectFirst.SetActive(true);

      if (IntCharacterTheme == 1){
      PanelFirst.GetComponent<Image>().sprite = Star_Character;
      IntCharacterFirst = 1;
      }
      if (IntCharacterTheme == 2){
      PanelFirst.GetComponent<Image>().sprite = Cupcake_Character;
      IntCharacterFirst = 2;
      }
      if (IntCharacterTheme == 3){
      PanelFirst.GetComponent<Image>().sprite = Heart_Character;
      IntCharacterFirst = 3;
      }
      if (IntCharacterTheme == 4){
      PanelFirst.GetComponent<Image>().sprite = Ballon_Character;
      IntCharacterFirst = 4;
      }
      if (IntCharacterTheme == 5){
      PanelFirst.GetComponent<Image>().sprite = Crab_Character;
      IntCharacterFirst = 5;
      }
      if (IntCharacterTheme == 6){
      PanelFirst.GetComponent<Image>().sprite = Ghost_Character;
      IntCharacterFirst = 6;
      }
      if (IntCharacterTheme == 7){
      PanelFirst.GetComponent<Image>().sprite = Squid_Character;
      IntCharacterFirst = 7;
      }
      if (IntCharacterTheme == 8){
      PanelFirst.GetComponent<Image>().sprite = Flame_Character;
      IntCharacterFirst = 8;
      }
      if (IntCharacterTheme == 9){
      PanelFirst.GetComponent<Image>().sprite = Strawberry_Character;
      IntCharacterFirst = 9;
      }
      if (IntCharacterTheme == 10){
      PanelFirst.GetComponent<Image>().sprite = Head_Character;
      IntCharacterFirst = 10;
      }
      if (IntCharacterTheme == 11){
      PanelFirst.GetComponent<Image>().sprite = Slime_Character;
      IntCharacterFirst = 11;
      }
      if (IntCharacterTheme == 12){
      PanelFirst.GetComponent<Image>().sprite = Bunny_Character;
      IntCharacterFirst = 12;
      }
      if (IntCharacterTheme == 13){
      PanelFirst.GetComponent<Image>().sprite = Mushroom_Character;
      IntCharacterFirst = 13;
      }
      if (IntCharacterTheme == 14){
      PanelFirst.GetComponent<Image>().sprite = IceCream_Character;
      IntCharacterFirst = 14;
      }
      if (IntCharacterTheme == 15){
      PanelFirst.GetComponent<Image>().sprite = Bear_Character;
      IntCharacterFirst = 15;
      }
      if (IntCharacterTheme == 16){
      PanelFirst.GetComponent<Image>().sprite = Flower_Character;
      IntCharacterFirst = 16;
      }
      if (IntCharacterTheme == 17){
      PanelFirst.GetComponent<Image>().sprite = JellyFish_Character;
      IntCharacterFirst = 17;
      }
      if (IntCharacterTheme == 18){
      PanelFirst.GetComponent<Image>().sprite = Flowers_Theme;
      IntCharacterFirst = 18;
      }
      if (IntCharacterTheme == 19){
      PanelFirst.GetComponent<Image>().sprite = Pyramids_Theme;
      IntCharacterFirst = 19;
      }
      if (IntCharacterTheme == 20){
      PanelFirst.GetComponent<Image>().sprite = Desert_Theme;
      IntCharacterFirst = 20;
      }
      if (IntCharacterTheme == 21){
      PanelFirst.GetComponent<Image>().sprite = Snow_Theme;
      IntCharacterFirst = 21;
      }
      if (IntCharacterTheme == 22){
      PanelFirst.GetComponent<Image>().sprite = Island_Theme;
      IntCharacterFirst = 22;
      }
      if (IntCharacterTheme == 23){
      PanelFirst.GetComponent<Image>().sprite = Volcano_Theme;
      IntCharacterFirst = 23;
      }
      if (IntCharacterTheme == 24){
      PanelFirst.GetComponent<Image>().sprite = NightSky_Theme;
      IntCharacterFirst = 24;
      }
      if (IntCharacterTheme == 25){
      PanelFirst.GetComponent<Image>().sprite = Autumn_Theme;
      IntCharacterFirst = 25;
      }
      if (IntCharacterTheme == 26){
      PanelFirst.GetComponent<Image>().sprite = Dinosaurus_Theme;
      IntCharacterFirst = 26;
      }
      if (IntCharacterTheme == 27){
      PanelFirst.GetComponent<Image>().sprite = Aquarium_Theme;
      IntCharacterFirst = 27;
      }
      if (IntCharacterTheme == 28){
      PanelFirst.GetComponent<Image>().sprite = Space_Theme;
      IntCharacterFirst = 28;
      }
      if (IntCharacterTheme == 29){
      PanelFirst.GetComponent<Image>().sprite = Rain_Theme;
      IntCharacterFirst = 29;
      }

      PlayerPrefs.SetInt("IntCharacterFirst", IntCharacterFirst);
    }

    if (IntPanel == 2){

      if (IntSecond == 0)
      {
        LastTimeSecond = (ulong)DateTime.Now.Ticks;
        PlayerPrefs.SetString("SecondTable", LastTimeSecond.ToString());
      } 

      IntSecond = 1;
      PlayerPrefs.SetInt("IntSecond", IntSecond); 

      GameObjectSecond.SetActive(true);

      if (IntCharacterTheme == 1){
      PanelSecond.GetComponent<Image>().sprite = Star_Character;
      IntCharacterSecond = 1;
      }
      if (IntCharacterTheme == 2){
      PanelSecond.GetComponent<Image>().sprite = Cupcake_Character;
      IntCharacterSecond = 2;
      }
      if (IntCharacterTheme == 3){
      PanelSecond.GetComponent<Image>().sprite = Heart_Character;
      IntCharacterSecond = 3;
      }
      if (IntCharacterTheme == 4){
      PanelSecond.GetComponent<Image>().sprite = Ballon_Character;
      IntCharacterSecond = 4;
      }
      if (IntCharacterTheme == 5){
      PanelSecond.GetComponent<Image>().sprite = Crab_Character;
      IntCharacterSecond = 5;
      }
      if (IntCharacterTheme == 6){
      PanelSecond.GetComponent<Image>().sprite = Ghost_Character;
      IntCharacterSecond = 6;
      }
      if (IntCharacterTheme == 7){
      PanelSecond.GetComponent<Image>().sprite = Squid_Character;
      IntCharacterSecond = 7;
      }
      if (IntCharacterTheme == 8){
      PanelSecond.GetComponent<Image>().sprite = Flame_Character;
      IntCharacterSecond = 8;
      }
      if (IntCharacterTheme == 9){
      PanelSecond.GetComponent<Image>().sprite = Strawberry_Character;
      IntCharacterSecond = 9;
      }
      if (IntCharacterTheme == 10){
      PanelSecond.GetComponent<Image>().sprite = Head_Character;
      IntCharacterSecond = 10;
      }
      if (IntCharacterTheme == 11){
      PanelSecond.GetComponent<Image>().sprite = Slime_Character;
      IntCharacterSecond = 11;
      }
      if (IntCharacterTheme == 12){
      PanelSecond.GetComponent<Image>().sprite = Bunny_Character;
      IntCharacterSecond = 12;
      }
      if (IntCharacterTheme == 13){
      PanelSecond.GetComponent<Image>().sprite = Mushroom_Character;
      IntCharacterSecond = 13;
      }
      if (IntCharacterTheme == 14){
      PanelSecond.GetComponent<Image>().sprite = IceCream_Character;
      IntCharacterSecond = 14;
      }
      if (IntCharacterTheme == 15){
      PanelSecond.GetComponent<Image>().sprite = Bear_Character;
      IntCharacterSecond = 15;
      }
      if (IntCharacterTheme == 16){
      PanelSecond.GetComponent<Image>().sprite = Flower_Character;
      IntCharacterSecond = 16;
      }
      if (IntCharacterTheme == 17){
      PanelSecond.GetComponent<Image>().sprite = JellyFish_Character;
      IntCharacterSecond = 17;
      }
      if (IntCharacterTheme == 18){
      PanelSecond.GetComponent<Image>().sprite = Flowers_Theme;
      IntCharacterSecond = 18;
      }
      if (IntCharacterTheme == 19){
      PanelSecond.GetComponent<Image>().sprite = Pyramids_Theme;
      IntCharacterSecond = 19;
      }
      if (IntCharacterTheme == 20){
      PanelSecond.GetComponent<Image>().sprite = Desert_Theme;
      IntCharacterSecond = 20;
      }
      if (IntCharacterTheme == 21){
      PanelSecond.GetComponent<Image>().sprite = Snow_Theme;
      IntCharacterSecond = 21;
      }
      if (IntCharacterTheme == 22){
      PanelSecond.GetComponent<Image>().sprite = Island_Theme;
      IntCharacterSecond = 22;
      }
      if (IntCharacterTheme == 23){
      PanelSecond.GetComponent<Image>().sprite = Volcano_Theme;
      IntCharacterSecond = 23;
      }
      if (IntCharacterTheme == 24){
      PanelSecond.GetComponent<Image>().sprite = NightSky_Theme;
      IntCharacterSecond = 24;
      }
      if (IntCharacterTheme == 25){
      PanelSecond.GetComponent<Image>().sprite = Autumn_Theme;
      IntCharacterSecond = 25;
      }
      if (IntCharacterTheme == 26){
      PanelSecond.GetComponent<Image>().sprite = Dinosaurus_Theme;
      IntCharacterSecond = 26;
      }
      if (IntCharacterTheme == 27){
      PanelSecond.GetComponent<Image>().sprite = Aquarium_Theme;
      IntCharacterSecond = 27;
      }
      if (IntCharacterTheme == 28){
      PanelSecond.GetComponent<Image>().sprite = Space_Theme;
      IntCharacterSecond = 28;
      }
      if (IntCharacterTheme == 29){
      PanelSecond.GetComponent<Image>().sprite = Rain_Theme;
      IntCharacterSecond = 29;
      }

      PlayerPrefs.SetInt("IntCharacterSecond", IntCharacterSecond); 
    }

    if (IntPanel == 3){

      if (IntThirt == 0)
      {
        LastTimeThirt = (ulong)DateTime.Now.Ticks;
        PlayerPrefs.SetString("ThreeTable", LastTimeThirt.ToString());
      }

      IntThirt = 1;
      PlayerPrefs.SetInt("IntThirt", IntThirt); 

      GameObjectThirt.SetActive(true);

      if (IntCharacterTheme == 1){
      PanelThirt.GetComponent<Image>().sprite = Star_Character;
      IntCharacterThirt = 1;
      }
      if (IntCharacterTheme == 2){
      PanelThirt.GetComponent<Image>().sprite = Cupcake_Character;
      IntCharacterThirt = 2;
      }
      if (IntCharacterTheme == 3){
      PanelThirt.GetComponent<Image>().sprite = Heart_Character;
      IntCharacterThirt = 3;
      }
      if (IntCharacterTheme == 4){
      PanelThirt.GetComponent<Image>().sprite = Ballon_Character;
      IntCharacterThirt = 4;
      }
      if (IntCharacterTheme == 5){
      PanelThirt.GetComponent<Image>().sprite = Crab_Character;
      IntCharacterThirt = 5;
      }
      if (IntCharacterTheme == 6){
      PanelThirt.GetComponent<Image>().sprite = Ghost_Character;
      IntCharacterThirt = 6;
      }
      if (IntCharacterTheme == 7){
      PanelThirt.GetComponent<Image>().sprite = Squid_Character;
      IntCharacterThirt = 7;
      }
      if (IntCharacterTheme == 8){
      PanelThirt.GetComponent<Image>().sprite = Flame_Character;
      IntCharacterThirt = 8;
      }
      if (IntCharacterTheme == 9){
      PanelThirt.GetComponent<Image>().sprite = Strawberry_Character;
      IntCharacterThirt = 9;
      }
      if (IntCharacterTheme == 10){
      PanelThirt.GetComponent<Image>().sprite = Head_Character;
      IntCharacterThirt = 10;
      }
      if (IntCharacterTheme == 11){
      PanelThirt.GetComponent<Image>().sprite = Slime_Character;
      IntCharacterThirt = 11;
      }
      if (IntCharacterTheme == 12){
      PanelThirt.GetComponent<Image>().sprite = Bunny_Character;
      IntCharacterThirt = 12;
      }
      if (IntCharacterTheme == 13){
      PanelThirt.GetComponent<Image>().sprite = Mushroom_Character;
      IntCharacterThirt = 13;
      }
      if (IntCharacterTheme == 14){
      PanelThirt.GetComponent<Image>().sprite = IceCream_Character;
      IntCharacterThirt = 14;
      }
      if (IntCharacterTheme == 15){
      PanelThirt.GetComponent<Image>().sprite = Bear_Character;
      IntCharacterThirt = 15;
      }
      if (IntCharacterTheme == 16){
      PanelThirt.GetComponent<Image>().sprite = Flower_Character;
      IntCharacterThirt = 16;
      }
      if (IntCharacterTheme == 17){
      PanelThirt.GetComponent<Image>().sprite = JellyFish_Character;
      IntCharacterThirt = 17;
      }
      if (IntCharacterTheme == 18){
      PanelThirt.GetComponent<Image>().sprite = Flowers_Theme;
      IntCharacterThirt = 18;
      }
      if (IntCharacterTheme == 19){
      PanelThirt.GetComponent<Image>().sprite = Pyramids_Theme;
      IntCharacterThirt = 19;
      }
      if (IntCharacterTheme == 20){
      PanelThirt.GetComponent<Image>().sprite = Desert_Theme;
      IntCharacterThirt = 20;
      }
      if (IntCharacterTheme == 21){
      PanelThirt.GetComponent<Image>().sprite = Snow_Theme;
      IntCharacterThirt = 21;
      }
      if (IntCharacterTheme == 22){
      PanelThirt.GetComponent<Image>().sprite = Island_Theme;
      IntCharacterThirt = 22;
      }
      if (IntCharacterTheme == 23){
      PanelThirt.GetComponent<Image>().sprite = Volcano_Theme;
      IntCharacterThirt = 23;
      }
      if (IntCharacterTheme == 24){
      PanelThirt.GetComponent<Image>().sprite = NightSky_Theme;
      IntCharacterThirt = 24;
      }
      if (IntCharacterTheme == 25){
      PanelThirt.GetComponent<Image>().sprite = Autumn_Theme;
      IntCharacterThirt = 25;
      }
      if (IntCharacterTheme == 26){
      PanelThirt.GetComponent<Image>().sprite = Dinosaurus_Theme;
      IntCharacterThirt = 26;
      }
      if (IntCharacterTheme == 27){
      PanelThirt.GetComponent<Image>().sprite = Aquarium_Theme;
      IntCharacterThirt = 27;
      }
      if (IntCharacterTheme == 28){
      PanelThirt.GetComponent<Image>().sprite = Space_Theme;
      IntCharacterThirt = 28;
      }
      if (IntCharacterTheme == 29){
      PanelThirt.GetComponent<Image>().sprite = Rain_Theme;
      IntCharacterThirt = 29;
      }

      PlayerPrefs.SetInt("IntCharacterThirt", IntCharacterThirt); 
    }

    if (IntPanel == 4){

      if (IntFour == 0)
      {
        LastTimeFour = (ulong)DateTime.Now.Ticks;
        PlayerPrefs.SetString("FourTable", LastTimeFour.ToString());
      }

      IntFour = 1;
      PlayerPrefs.SetInt("IntFour", IntFour); 

      GameObjectFour.SetActive(true);

      if (IntCharacterTheme == 1){
      PanelFour.GetComponent<Image>().sprite = Star_Character;
      IntCharacterFour = 1;
      }
      if (IntCharacterTheme == 2){
      PanelFour.GetComponent<Image>().sprite = Cupcake_Character;
      IntCharacterFour = 2;
      }
      if (IntCharacterTheme == 3){
      PanelFour.GetComponent<Image>().sprite = Heart_Character;
      IntCharacterFour = 3;
      }
      if (IntCharacterTheme == 4){
      PanelFour.GetComponent<Image>().sprite = Ballon_Character;
      IntCharacterFour = 4;
      }
      if (IntCharacterTheme == 5){
      PanelFour.GetComponent<Image>().sprite = Crab_Character;
      IntCharacterFour = 5;
      }
      if (IntCharacterTheme == 6){
      PanelFour.GetComponent<Image>().sprite = Ghost_Character;
      IntCharacterFour = 6;
      }
      if (IntCharacterTheme == 7){
      PanelFour.GetComponent<Image>().sprite = Squid_Character;
      IntCharacterFour = 7;
      }
      if (IntCharacterTheme == 8){
      PanelFour.GetComponent<Image>().sprite = Flame_Character;
      IntCharacterFour = 8;
      }
      if (IntCharacterTheme == 9){
      PanelFour.GetComponent<Image>().sprite = Strawberry_Character;
      IntCharacterFour = 9;
      }
      if (IntCharacterTheme == 10){
      PanelFour.GetComponent<Image>().sprite = Head_Character;
      IntCharacterFour = 10;
      }
      if (IntCharacterTheme == 11){
      PanelFour.GetComponent<Image>().sprite = Slime_Character;
      IntCharacterFour = 11;
      }
      if (IntCharacterTheme == 12){
      PanelFour.GetComponent<Image>().sprite = Bunny_Character;
      IntCharacterFour = 12;
      }
      if (IntCharacterTheme == 13){
      PanelFour.GetComponent<Image>().sprite = Mushroom_Character;
      IntCharacterFour = 13;
      }
      if (IntCharacterTheme == 14){
      PanelFour.GetComponent<Image>().sprite = IceCream_Character;
      IntCharacterFour = 14;
      }
      if (IntCharacterTheme == 15){
      PanelFour.GetComponent<Image>().sprite = Bear_Character;
      IntCharacterFour = 15;
      }
      if (IntCharacterTheme == 16){
      PanelFour.GetComponent<Image>().sprite = Flower_Character;
      IntCharacterFour = 16;
      }
      if (IntCharacterTheme == 17){
      PanelFour.GetComponent<Image>().sprite = JellyFish_Character;
      IntCharacterFour = 17;
      }
      if (IntCharacterTheme == 18){
      PanelFour.GetComponent<Image>().sprite = Flowers_Theme;
      IntCharacterFour = 18;
      }
      if (IntCharacterTheme == 19){
      PanelFour.GetComponent<Image>().sprite = Pyramids_Theme;
      IntCharacterFour = 19;
      }
      if (IntCharacterTheme == 20){
      PanelFour.GetComponent<Image>().sprite = Desert_Theme;
      IntCharacterFour = 20;
      }
      if (IntCharacterTheme == 21){
      PanelFour.GetComponent<Image>().sprite = Snow_Theme;
      IntCharacterFour = 21;
      }
      if (IntCharacterTheme == 22){
      PanelFour.GetComponent<Image>().sprite = Island_Theme;
      IntCharacterFour = 22;
      }
      if (IntCharacterTheme == 23){
      PanelFour.GetComponent<Image>().sprite = Volcano_Theme;
      IntCharacterFour = 23;
      }
      if (IntCharacterTheme == 24){
      PanelFour.GetComponent<Image>().sprite = NightSky_Theme;
      IntCharacterFour = 24;
      }
      if (IntCharacterTheme == 25){
      PanelFour.GetComponent<Image>().sprite = Autumn_Theme;
      IntCharacterFour = 25;
      }
      if (IntCharacterTheme == 26){
      PanelFour.GetComponent<Image>().sprite = Dinosaurus_Theme;
      IntCharacterFour = 26;
      }
      if (IntCharacterTheme == 27){
      PanelFour.GetComponent<Image>().sprite = Aquarium_Theme;
      IntCharacterFour = 27;
      }
      if (IntCharacterTheme == 28){
      PanelFour.GetComponent<Image>().sprite = Space_Theme;
      IntCharacterFour = 28;
      }
      if (IntCharacterTheme == 29){
      PanelFour.GetComponent<Image>().sprite = Rain_Theme;
      IntCharacterFour = 29;
      }

      PlayerPrefs.SetInt("IntCharacterFour", IntCharacterFour);
    }

    if (IntPanel == 5){

      if (IntFive == 0)
      {
        LastTimeFive = (ulong)DateTime.Now.Ticks;
        PlayerPrefs.SetString("FiveTable", LastTimeFive.ToString());
      }

      IntFive = 1;
      PlayerPrefs.SetInt("IntFive", IntFive); 

      GameObjectFive.SetActive(true);

      if (IntCharacterTheme == 1){
      PanelFive.GetComponent<Image>().sprite = Star_Character;
      IntCharacterFive = 1;
      }
      if (IntCharacterTheme == 2){
      PanelFive.GetComponent<Image>().sprite = Cupcake_Character;
      IntCharacterFive = 1;
      }
      if (IntCharacterTheme == 3){
      PanelFive.GetComponent<Image>().sprite = Heart_Character;
      IntCharacterFive = 1;
      }
      if (IntCharacterTheme == 4){
      PanelFive.GetComponent<Image>().sprite = Ballon_Character;
      IntCharacterFive = 1;
      }
      if (IntCharacterTheme == 5){
      PanelFive.GetComponent<Image>().sprite = Crab_Character;
      IntCharacterFive = 1;
      }
      if (IntCharacterTheme == 6){
      PanelFive.GetComponent<Image>().sprite = Ghost_Character;
      IntCharacterFive = 1;
      }
      if (IntCharacterTheme == 7){
      PanelFive.GetComponent<Image>().sprite = Squid_Character;
      IntCharacterFive = 1;
      }
      if (IntCharacterTheme == 8){
      PanelFive.GetComponent<Image>().sprite = Flame_Character;
      IntCharacterFive = 1;
      }
      if (IntCharacterTheme == 9){
      PanelFive.GetComponent<Image>().sprite = Strawberry_Character;
      IntCharacterFive = 1;
      }
      if (IntCharacterTheme == 10){
      PanelFive.GetComponent<Image>().sprite = Head_Character;
      IntCharacterFive = 1;
      }
      if (IntCharacterTheme == 11){
      PanelFive.GetComponent<Image>().sprite = Slime_Character;
      IntCharacterFive = 1;
      }
      if (IntCharacterTheme == 12){
      PanelFive.GetComponent<Image>().sprite = Bunny_Character;
      IntCharacterFive = 1;
      }
      if (IntCharacterTheme == 13){
      PanelFive.GetComponent<Image>().sprite = Mushroom_Character;
      IntCharacterFive = 1;
      }
      if (IntCharacterTheme == 14){
      PanelFive.GetComponent<Image>().sprite = IceCream_Character;
      IntCharacterFive = 1;
      }
      if (IntCharacterTheme == 15){
      PanelFive.GetComponent<Image>().sprite = Bear_Character;
      IntCharacterFive = 1;
      }
      if (IntCharacterTheme == 16){
      PanelFive.GetComponent<Image>().sprite = Flower_Character;
      IntCharacterFive = 1;
      }
      if (IntCharacterTheme == 17){
      PanelFive.GetComponent<Image>().sprite = JellyFish_Character;
      IntCharacterFive = 1;
      }
      if (IntCharacterTheme == 18){
      PanelFive.GetComponent<Image>().sprite = Flowers_Theme;
      IntCharacterFive = 1;
      }
      if (IntCharacterTheme == 19){
      PanelFive.GetComponent<Image>().sprite = Pyramids_Theme;
      IntCharacterFive = 1;
      }
      if (IntCharacterTheme == 20){
      PanelFive.GetComponent<Image>().sprite = Desert_Theme;
      IntCharacterFive = 1;
      }
      if (IntCharacterTheme == 21){
      PanelFive.GetComponent<Image>().sprite = Snow_Theme;
      IntCharacterFive = 1;
      }
      if (IntCharacterTheme == 22){
      PanelFive.GetComponent<Image>().sprite = Island_Theme;
      IntCharacterFive = 1;
      }
      if (IntCharacterTheme == 23){
      PanelFive.GetComponent<Image>().sprite = Volcano_Theme;
      IntCharacterFive = 1;
      }
      if (IntCharacterTheme == 24){
      PanelFive.GetComponent<Image>().sprite = NightSky_Theme;
      IntCharacterFive = 1;
      }
      if (IntCharacterTheme == 25){
      PanelFive.GetComponent<Image>().sprite = Autumn_Theme;
      IntCharacterFive = 1;
      }
      if (IntCharacterTheme == 26){
      PanelFive.GetComponent<Image>().sprite = Dinosaurus_Theme;
      IntCharacterFive = 1;
      }
      if (IntCharacterTheme == 27){
      PanelFive.GetComponent<Image>().sprite = Aquarium_Theme;
      IntCharacterFive = 1;
      }
      if (IntCharacterTheme == 28){
      PanelFive.GetComponent<Image>().sprite = Space_Theme;
      IntCharacterFive = 1;
      }
      if (IntCharacterTheme == 29){
      PanelFive.GetComponent<Image>().sprite = Rain_Theme;
      IntCharacterFive = 1;
      }

      PlayerPrefs.SetInt("IntCharacterFive", IntCharacterFive); 
    }

    if (IntPanel == 6){

      if (IntSix == 0)
      {
        LastTimeSix = (ulong)DateTime.Now.Ticks;
        PlayerPrefs.SetString("SixTable", LastTimeSix.ToString());
      }

      IntSix = 1;
      PlayerPrefs.SetInt("IntSix", IntSix); 

      GameObjectSix.SetActive(true);

      if (IntCharacterTheme == 1){
      PanelSix.GetComponent<Image>().sprite = Star_Character;
      IntCharacterSix = 1;
      }
      if (IntCharacterTheme == 2){
      PanelSix.GetComponent<Image>().sprite = Cupcake_Character;
      IntCharacterSix = 2;
      }
      if (IntCharacterTheme == 3){
      PanelSix.GetComponent<Image>().sprite = Heart_Character;
      IntCharacterSix = 3;
      }
      if (IntCharacterTheme == 4){
      PanelSix.GetComponent<Image>().sprite = Ballon_Character;
      IntCharacterSix = 4;
      }
      if (IntCharacterTheme == 5){
      PanelSix.GetComponent<Image>().sprite = Crab_Character;
      IntCharacterSix = 5;
      }
      if (IntCharacterTheme == 6){
      PanelSix.GetComponent<Image>().sprite = Ghost_Character;
      IntCharacterSix = 6;
      }
      if (IntCharacterTheme == 7){
      PanelSix.GetComponent<Image>().sprite = Squid_Character;
      IntCharacterSix = 7;
      }
      if (IntCharacterTheme == 8){
      PanelSix.GetComponent<Image>().sprite = Flame_Character;
      IntCharacterSix = 8;
      }
      if (IntCharacterTheme == 9){
      PanelSix.GetComponent<Image>().sprite = Strawberry_Character;
      IntCharacterSix = 9;
      }
      if (IntCharacterTheme == 10){
      PanelSix.GetComponent<Image>().sprite = Head_Character;
      IntCharacterSix = 10;
      }
      if (IntCharacterTheme == 11){
      PanelSix.GetComponent<Image>().sprite = Slime_Character;
      IntCharacterSix = 11;
      }
      if (IntCharacterTheme == 12){
      PanelSix.GetComponent<Image>().sprite = Bunny_Character;
      IntCharacterSix = 12;
      }
      if (IntCharacterTheme == 13){
      PanelSix.GetComponent<Image>().sprite = Mushroom_Character;
      IntCharacterSix = 13;
      }
      if (IntCharacterTheme == 14){
      PanelSix.GetComponent<Image>().sprite = IceCream_Character;
      IntCharacterSix = 14;
      }
      if (IntCharacterTheme == 15){
      PanelSix.GetComponent<Image>().sprite = Bear_Character;
      IntCharacterSix = 15;
      }
      if (IntCharacterTheme == 16){
      PanelSix.GetComponent<Image>().sprite = Flower_Character;
      IntCharacterSix = 16;
      }
      if (IntCharacterTheme == 17){
      PanelSix.GetComponent<Image>().sprite = JellyFish_Character;
      IntCharacterSix = 17;
      }
      if (IntCharacterTheme == 18){
      PanelSix.GetComponent<Image>().sprite = Flowers_Theme;
      IntCharacterSix = 18;
      }
      if (IntCharacterTheme == 19){
      PanelSix.GetComponent<Image>().sprite = Pyramids_Theme;
      IntCharacterSix = 19;
      }
      if (IntCharacterTheme == 20){
      PanelSix.GetComponent<Image>().sprite = Desert_Theme;
      IntCharacterSix = 20;
      }
      if (IntCharacterTheme == 21){
      PanelSix.GetComponent<Image>().sprite = Snow_Theme;
      IntCharacterSix = 21;
      }
      if (IntCharacterTheme == 22){
      PanelSix.GetComponent<Image>().sprite = Island_Theme;
      IntCharacterSix = 22;
      }
      if (IntCharacterTheme == 23){
      PanelSix.GetComponent<Image>().sprite = Volcano_Theme;
      IntCharacterSix = 23;
      }
      if (IntCharacterTheme == 24){
      PanelSix.GetComponent<Image>().sprite = NightSky_Theme;
      IntCharacterSix = 24;
      }
      if (IntCharacterTheme == 25){
      PanelSix.GetComponent<Image>().sprite = Autumn_Theme;
      IntCharacterSix = 25;
      }
      if (IntCharacterTheme == 26){
      PanelSix.GetComponent<Image>().sprite = Dinosaurus_Theme;
      IntCharacterSix = 26;
      }
      if (IntCharacterTheme == 27){
      PanelSix.GetComponent<Image>().sprite = Aquarium_Theme;
      IntCharacterSix = 27;
      }
      if (IntCharacterTheme == 28){
      PanelSix.GetComponent<Image>().sprite = Space_Theme;
      IntCharacterSix = 28;
      }
      if (IntCharacterTheme == 29){
      PanelSix.GetComponent<Image>().sprite = Rain_Theme;
      IntCharacterSix = 29;
      }

      PlayerPrefs.SetInt("IntCharacterSix", IntCharacterSix); 
    }

    if (IntPanel == 7){

      if (IntSeven == 0)
      {
        LastTimeSeven = (ulong)DateTime.Now.Ticks;
        PlayerPrefs.SetString("SevenTable", LastTimeSeven.ToString());
      }

      IntSeven = 1;
      PlayerPrefs.SetInt("IntSeven", IntSeven); 

      GameObjectSeven.SetActive(true);

      if (IntCharacterTheme == 1){
      PanelSeven.GetComponent<Image>().sprite = Star_Character;
      IntCharacterSeven = 1;
      }
      if (IntCharacterTheme == 2){
      PanelSeven.GetComponent<Image>().sprite = Cupcake_Character;
      IntCharacterSeven = 2;
      }
      if (IntCharacterTheme == 3){
      PanelSeven.GetComponent<Image>().sprite = Heart_Character;
      IntCharacterSeven = 3;
      }
      if (IntCharacterTheme == 4){
      PanelSeven.GetComponent<Image>().sprite = Ballon_Character;
      IntCharacterSeven = 4;
      }
      if (IntCharacterTheme == 5){
      PanelSeven.GetComponent<Image>().sprite = Crab_Character;
      IntCharacterSeven = 5;
      }
      if (IntCharacterTheme == 6){
      PanelSeven.GetComponent<Image>().sprite = Ghost_Character;
      IntCharacterSeven = 6;
      }
      if (IntCharacterTheme == 7){
      PanelSeven.GetComponent<Image>().sprite = Squid_Character;
      IntCharacterSeven = 7;
      }
      if (IntCharacterTheme == 8){
      PanelSeven.GetComponent<Image>().sprite = Flame_Character;
      IntCharacterSeven = 8;
      }
      if (IntCharacterTheme == 9){
      PanelSeven.GetComponent<Image>().sprite = Strawberry_Character;
      IntCharacterSeven = 9;
      }
      if (IntCharacterTheme == 10){
      PanelSeven.GetComponent<Image>().sprite = Head_Character;
      IntCharacterSeven = 10;
      }
      if (IntCharacterTheme == 11){
      PanelSeven.GetComponent<Image>().sprite = Slime_Character;
      IntCharacterSeven = 11;
      }
      if (IntCharacterTheme == 12){
      PanelSeven.GetComponent<Image>().sprite = Bunny_Character;
      IntCharacterSeven = 12;
      }
      if (IntCharacterTheme == 13){
      PanelSeven.GetComponent<Image>().sprite = Mushroom_Character;
      IntCharacterSeven = 13;
      }
      if (IntCharacterTheme == 14){
      PanelSeven.GetComponent<Image>().sprite = IceCream_Character;
      IntCharacterSeven = 14;
      }
      if (IntCharacterTheme == 15){
      PanelSeven.GetComponent<Image>().sprite = Bear_Character;
      IntCharacterSeven = 15;
      }
      if (IntCharacterTheme == 16){
      PanelSeven.GetComponent<Image>().sprite = Flower_Character;
      IntCharacterSeven = 16;
      }
      if (IntCharacterTheme == 17){
      PanelSeven.GetComponent<Image>().sprite = JellyFish_Character;
      IntCharacterSeven = 17;
      }
      if (IntCharacterTheme == 18){
      PanelSeven.GetComponent<Image>().sprite = Flowers_Theme;
      IntCharacterSeven = 18;
      }
      if (IntCharacterTheme == 19){
      PanelSeven.GetComponent<Image>().sprite = Pyramids_Theme;
      IntCharacterSeven = 19;
      }
      if (IntCharacterTheme == 20){
      PanelSeven.GetComponent<Image>().sprite = Desert_Theme;
      IntCharacterSeven = 20;
      }
      if (IntCharacterTheme == 21){
      PanelSeven.GetComponent<Image>().sprite = Snow_Theme;
      IntCharacterSeven = 21;
      }
      if (IntCharacterTheme == 22){
      PanelSeven.GetComponent<Image>().sprite = Island_Theme;
      IntCharacterSeven = 22;
      }
      if (IntCharacterTheme == 23){
      PanelSeven.GetComponent<Image>().sprite = Volcano_Theme;
      IntCharacterSeven = 23;
      }
      if (IntCharacterTheme == 24){
      PanelSeven.GetComponent<Image>().sprite = NightSky_Theme;
      IntCharacterSeven = 24;
      }
      if (IntCharacterTheme == 25){
      PanelSeven.GetComponent<Image>().sprite = Autumn_Theme;
      IntCharacterSeven = 25;
      }
      if (IntCharacterTheme == 26){
      PanelSeven.GetComponent<Image>().sprite = Dinosaurus_Theme;
      IntCharacterSeven = 26;
      }
      if (IntCharacterTheme == 27){
      PanelSeven.GetComponent<Image>().sprite = Aquarium_Theme;
      IntCharacterSeven = 27;
      }
      if (IntCharacterTheme == 28){
      PanelSeven.GetComponent<Image>().sprite = Space_Theme;
      IntCharacterSeven = 28;
      }
      if (IntCharacterTheme == 29){
      PanelSeven.GetComponent<Image>().sprite = Rain_Theme;
      IntCharacterSeven = 29;
      }

      PlayerPrefs.SetInt("IntCharacterSeven", IntCharacterSeven); 
    }

    if (IntPanel == 8){

      if (IntEight == 0)
      {
        LastTimeEight = (ulong)DateTime.Now.Ticks;
        PlayerPrefs.SetString("EightTable", LastTimeEight.ToString());
      }

      IntEight = 1;
      PlayerPrefs.SetInt("IntEight", IntEight); 

      GameObjectEight.SetActive(true);

      if (IntCharacterTheme == 1){
      PanelEight.GetComponent<Image>().sprite = Star_Character;
      IntCharacterEight = 1;
      }
      if (IntCharacterTheme == 2){
      PanelEight.GetComponent<Image>().sprite = Cupcake_Character;
      IntCharacterEight = 2;
      }
      if (IntCharacterTheme == 3){
      PanelEight.GetComponent<Image>().sprite = Heart_Character;
      IntCharacterEight = 3;
      }
      if (IntCharacterTheme == 4){
      PanelEight.GetComponent<Image>().sprite = Ballon_Character;
      IntCharacterEight = 4;
      }
      if (IntCharacterTheme == 5){
      PanelEight.GetComponent<Image>().sprite = Crab_Character;
      IntCharacterEight = 5;
      }
      if (IntCharacterTheme == 6){
      PanelEight.GetComponent<Image>().sprite = Ghost_Character;
      IntCharacterEight = 6;
      }
      if (IntCharacterTheme == 7){
      PanelEight.GetComponent<Image>().sprite = Squid_Character;
      IntCharacterEight = 7;
      }
      if (IntCharacterTheme == 8){
      PanelEight.GetComponent<Image>().sprite = Flame_Character;
      IntCharacterEight = 8;
      }
      if (IntCharacterTheme == 9){
      PanelEight.GetComponent<Image>().sprite = Strawberry_Character;
      IntCharacterEight = 9;
      }
      if (IntCharacterTheme == 10){
      PanelEight.GetComponent<Image>().sprite = Head_Character;
      IntCharacterEight = 10;
      }
      if (IntCharacterTheme == 11){
      PanelEight.GetComponent<Image>().sprite = Slime_Character;
      IntCharacterEight = 11;
      }
      if (IntCharacterTheme == 12){
      PanelEight.GetComponent<Image>().sprite = Bunny_Character;
      IntCharacterEight = 12;
      }
      if (IntCharacterTheme == 13){
      PanelEight.GetComponent<Image>().sprite = Mushroom_Character;
      IntCharacterEight = 13;
      }
      if (IntCharacterTheme == 14){
      PanelEight.GetComponent<Image>().sprite = IceCream_Character;
      IntCharacterEight = 14;
      }
      if (IntCharacterTheme == 15){
      PanelEight.GetComponent<Image>().sprite = Bear_Character;
      IntCharacterEight = 15;
      }
      if (IntCharacterTheme == 16){
      PanelEight.GetComponent<Image>().sprite = Flower_Character;
      IntCharacterEight = 16;
      }
      if (IntCharacterTheme == 17){
      PanelEight.GetComponent<Image>().sprite = JellyFish_Character;
      IntCharacterEight = 17;
      }
      if (IntCharacterTheme == 18){
      PanelEight.GetComponent<Image>().sprite = Flowers_Theme;
      IntCharacterEight = 18;
      }
      if (IntCharacterTheme == 19){
      PanelEight.GetComponent<Image>().sprite = Pyramids_Theme;
      IntCharacterEight = 19;
      }
      if (IntCharacterTheme == 20){
      PanelEight.GetComponent<Image>().sprite = Desert_Theme;
      IntCharacterEight = 20;
      }
      if (IntCharacterTheme == 21){
      PanelEight.GetComponent<Image>().sprite = Snow_Theme;
      IntCharacterEight = 21;
      }
      if (IntCharacterTheme == 22){
      PanelEight.GetComponent<Image>().sprite = Island_Theme;
      IntCharacterEight = 22;
      }
      if (IntCharacterTheme == 23){
      PanelEight.GetComponent<Image>().sprite = Volcano_Theme;
      IntCharacterEight = 23;
      }
      if (IntCharacterTheme == 24){
      PanelEight.GetComponent<Image>().sprite = NightSky_Theme;
      IntCharacterEight = 24;
      }
      if (IntCharacterTheme == 25){
      PanelEight.GetComponent<Image>().sprite = Autumn_Theme;
      IntCharacterEight = 25;
      }
      if (IntCharacterTheme == 26){
      PanelEight.GetComponent<Image>().sprite = Dinosaurus_Theme;
      IntCharacterEight = 26;
      }
      if (IntCharacterTheme == 27){
      PanelEight.GetComponent<Image>().sprite = Aquarium_Theme;
      IntCharacterEight = 27;
      }
      if (IntCharacterTheme == 28){
      PanelEight.GetComponent<Image>().sprite = Space_Theme;
      IntCharacterEight = 28;
      }
      if (IntCharacterTheme == 29){
      PanelEight.GetComponent<Image>().sprite = Rain_Theme;
      IntCharacterEight = 29;
      }

      PlayerPrefs.SetInt("IntCharacterEight", IntCharacterEight); 
    }

    if (IntPanel == 9){

      if (IntNine == 0)
      {
        LastTimeNine = (ulong)DateTime.Now.Ticks;
        PlayerPrefs.SetString("NineTable", LastTimeNine.ToString());
      }

      IntNine = 1;
      PlayerPrefs.SetInt("IntNine", IntNine); 

      GameObjectNine.SetActive(true);

      if (IntCharacterTheme == 1){
      PanelNine.GetComponent<Image>().sprite = Star_Character;
      IntCharacterNine = 1;
      }
      if (IntCharacterTheme == 2){
      PanelNine.GetComponent<Image>().sprite = Cupcake_Character;
      IntCharacterNine = 2;
      }
      if (IntCharacterTheme == 3){
      PanelNine.GetComponent<Image>().sprite = Heart_Character;
      IntCharacterNine = 3;
      }
      if (IntCharacterTheme == 4){
      PanelNine.GetComponent<Image>().sprite = Ballon_Character;
      IntCharacterNine = 4;
      }
      if (IntCharacterTheme == 5){
      PanelNine.GetComponent<Image>().sprite = Crab_Character;
      IntCharacterNine = 5;
      }
      if (IntCharacterTheme == 6){
      PanelNine.GetComponent<Image>().sprite = Ghost_Character;
      IntCharacterNine = 6;
      }
      if (IntCharacterTheme == 7){
      PanelNine.GetComponent<Image>().sprite = Squid_Character;
      IntCharacterNine = 7;
      }
      if (IntCharacterTheme == 8){
      PanelNine.GetComponent<Image>().sprite = Flame_Character;
      IntCharacterNine = 8;
      }
      if (IntCharacterTheme == 9){
      PanelNine.GetComponent<Image>().sprite = Strawberry_Character;
      IntCharacterNine = 9;
      }
      if (IntCharacterTheme == 10){
      PanelNine.GetComponent<Image>().sprite = Head_Character;
      IntCharacterNine = 10;
      }
      if (IntCharacterTheme == 11){
      PanelNine.GetComponent<Image>().sprite = Slime_Character;
      IntCharacterNine = 11;
      }
      if (IntCharacterTheme == 12){
      PanelNine.GetComponent<Image>().sprite = Bunny_Character;
      IntCharacterNine = 12;
      }
      if (IntCharacterTheme == 13){
      PanelNine.GetComponent<Image>().sprite = Mushroom_Character;
      IntCharacterNine = 13;
      }
      if (IntCharacterTheme == 14){
      PanelNine.GetComponent<Image>().sprite = IceCream_Character;
      IntCharacterNine = 14;
      }
      if (IntCharacterTheme == 15){
      PanelNine.GetComponent<Image>().sprite = Bear_Character;
      IntCharacterNine = 15;
      }
      if (IntCharacterTheme == 16){
      PanelNine.GetComponent<Image>().sprite = Flower_Character;
      IntCharacterNine = 16;
      }
      if (IntCharacterTheme == 17){
      PanelNine.GetComponent<Image>().sprite = JellyFish_Character;
      IntCharacterNine = 17;
      }
      if (IntCharacterTheme == 18){
      PanelNine.GetComponent<Image>().sprite = Flowers_Theme;
      IntCharacterNine = 18;
      }
      if (IntCharacterTheme == 19){
      PanelNine.GetComponent<Image>().sprite = Pyramids_Theme;
      IntCharacterNine = 19;
      }
      if (IntCharacterTheme == 20){
      PanelNine.GetComponent<Image>().sprite = Desert_Theme;
      IntCharacterNine = 20;
      }
      if (IntCharacterTheme == 21){
      PanelNine.GetComponent<Image>().sprite = Snow_Theme;
      IntCharacterNine = 21;
      }
      if (IntCharacterTheme == 22){
      PanelNine.GetComponent<Image>().sprite = Island_Theme;
      IntCharacterNine = 22;
      }
      if (IntCharacterTheme == 23){
      PanelNine.GetComponent<Image>().sprite = Volcano_Theme;
      IntCharacterNine = 23;
      }
      if (IntCharacterTheme == 24){
      PanelNine.GetComponent<Image>().sprite = NightSky_Theme;
      IntCharacterNine = 24;
      }
      if (IntCharacterTheme == 25){
      PanelNine.GetComponent<Image>().sprite = Autumn_Theme;
      IntCharacterNine = 25;
      }
      if (IntCharacterTheme == 26){
      PanelNine.GetComponent<Image>().sprite = Dinosaurus_Theme;
      IntCharacterNine = 26;
      }
      if (IntCharacterTheme == 27){
      PanelNine.GetComponent<Image>().sprite = Aquarium_Theme;
      IntCharacterNine = 27;
      }
      if (IntCharacterTheme == 28){
      PanelNine.GetComponent<Image>().sprite = Space_Theme;
      IntCharacterNine = 28;
      }
      if (IntCharacterTheme == 29){
      PanelNine.GetComponent<Image>().sprite = Rain_Theme;
      IntCharacterNine = 29;
      }

      PlayerPrefs.SetInt("IntCharacterNine", IntCharacterNine); 
    }

    if (IntPanel == 10){

      if (IntTen == 0)
      {
        LastTimeTen = (ulong)DateTime.Now.Ticks;
        PlayerPrefs.SetString("TenTable", LastTimeTen.ToString());
      }

      IntTen = 1;
      PlayerPrefs.SetInt("IntTen", IntTen); 

      GameObjectTen.SetActive(true);

      if (IntCharacterTheme == 1){
      PanelTen.GetComponent<Image>().sprite = Star_Character;
      IntCharacterTen = 1;
      }
      if (IntCharacterTheme == 2){
      PanelTen.GetComponent<Image>().sprite = Cupcake_Character;
      IntCharacterTen = 2;
      }
      if (IntCharacterTheme == 3){
      PanelTen.GetComponent<Image>().sprite = Heart_Character;
      IntCharacterTen = 3;
      }
      if (IntCharacterTheme == 4){
      PanelTen.GetComponent<Image>().sprite = Ballon_Character;
      IntCharacterTen = 4;
      }
      if (IntCharacterTheme == 5){
      PanelTen.GetComponent<Image>().sprite = Crab_Character;
      IntCharacterTen = 5;
      }
      if (IntCharacterTheme == 6){
      PanelTen.GetComponent<Image>().sprite = Ghost_Character;
      IntCharacterTen = 6;
      }
      if (IntCharacterTheme == 7){
      PanelTen.GetComponent<Image>().sprite = Squid_Character;
      IntCharacterTen = 7;
      }
      if (IntCharacterTheme == 8){
      PanelTen.GetComponent<Image>().sprite = Flame_Character;
      IntCharacterTen = 8;
      }
      if (IntCharacterTheme == 9){
      PanelTen.GetComponent<Image>().sprite = Strawberry_Character;
      IntCharacterTen = 9;
      }
      if (IntCharacterTheme == 10){
      PanelTen.GetComponent<Image>().sprite = Head_Character;
      IntCharacterTen = 10;
      }
      if (IntCharacterTheme == 11){
      PanelTen.GetComponent<Image>().sprite = Slime_Character;
      IntCharacterTen = 11;
      }
      if (IntCharacterTheme == 12){
      PanelTen.GetComponent<Image>().sprite = Bunny_Character;
      IntCharacterTen = 12;
      }
      if (IntCharacterTheme == 13){
      PanelTen.GetComponent<Image>().sprite = Mushroom_Character;
      IntCharacterTen = 13;
      }
      if (IntCharacterTheme == 14){
      PanelTen.GetComponent<Image>().sprite = IceCream_Character;
      IntCharacterTen = 14;
      }
      if (IntCharacterTheme == 15){
      PanelTen.GetComponent<Image>().sprite = Bear_Character;
      IntCharacterTen = 15;
      }
      if (IntCharacterTheme == 16){
      PanelTen.GetComponent<Image>().sprite = Flower_Character;
      IntCharacterTen = 16;
      }
      if (IntCharacterTheme == 17){
      PanelTen.GetComponent<Image>().sprite = JellyFish_Character;
      IntCharacterTen = 17;
      }
      if (IntCharacterTheme == 18){
      PanelTen.GetComponent<Image>().sprite = Flowers_Theme;
      IntCharacterTen = 18;
      }
      if (IntCharacterTheme == 19){
      PanelTen.GetComponent<Image>().sprite = Pyramids_Theme;
      IntCharacterTen = 19;
      }
      if (IntCharacterTheme == 20){
      PanelTen.GetComponent<Image>().sprite = Desert_Theme;
      IntCharacterTen = 20;
      }
      if (IntCharacterTheme == 21){
      PanelTen.GetComponent<Image>().sprite = Snow_Theme;
      IntCharacterTen = 21;
      }
      if (IntCharacterTheme == 22){
      PanelTen.GetComponent<Image>().sprite = Island_Theme;
      IntCharacterTen = 22;
      }
      if (IntCharacterTheme == 23){
      PanelTen.GetComponent<Image>().sprite = Volcano_Theme;
      IntCharacterTen = 23;
      }
      if (IntCharacterTheme == 24){
      PanelTen.GetComponent<Image>().sprite = NightSky_Theme;
      IntCharacterTen = 24;
      }
      if (IntCharacterTheme == 25){
      PanelTen.GetComponent<Image>().sprite = Autumn_Theme;
      IntCharacterTen = 25;
      }
      if (IntCharacterTheme == 26){
      PanelTen.GetComponent<Image>().sprite = Dinosaurus_Theme;
      IntCharacterTen = 26;
      }
      if (IntCharacterTheme == 27){
      PanelTen.GetComponent<Image>().sprite = Aquarium_Theme;
      IntCharacterTen = 27;
      }
      if (IntCharacterTheme == 28){
      PanelTen.GetComponent<Image>().sprite = Space_Theme;
      IntCharacterTen = 28;
      }
      if (IntCharacterTheme == 29){
      PanelTen.GetComponent<Image>().sprite = Rain_Theme;
      IntCharacterTen = 29;
      }

      PlayerPrefs.SetInt("IntCharacterTen", IntCharacterTen); 
    }

    if (IntPanel == 11){

      if (IntEleven == 0)
      {
        LastTimeEleven = (ulong)DateTime.Now.Ticks;
        PlayerPrefs.SetString("ElevenTable", LastTimeEleven.ToString());
      }

      IntEleven = 1;
      PlayerPrefs.SetInt("IntEleven", IntEleven); 

      GameObjectEleven.SetActive(true);

      if (IntCharacterTheme == 1){
      PanelEleven.GetComponent<Image>().sprite = Star_Character;
      IntCharacterEleven = 1;
      }
      if (IntCharacterTheme == 2){
      PanelEleven.GetComponent<Image>().sprite = Cupcake_Character;
      IntCharacterEleven = 2;
      }
      if (IntCharacterTheme == 3){
      PanelEleven.GetComponent<Image>().sprite = Heart_Character;
      IntCharacterEleven = 3;
      }
      if (IntCharacterTheme == 4){
      PanelEleven.GetComponent<Image>().sprite = Ballon_Character;
      IntCharacterEleven = 4;
      }
      if (IntCharacterTheme == 5){
      PanelEleven.GetComponent<Image>().sprite = Crab_Character;
      IntCharacterEleven = 5;
      }
      if (IntCharacterTheme == 6){
      PanelEleven.GetComponent<Image>().sprite = Ghost_Character;
      IntCharacterEleven = 6;
      }
      if (IntCharacterTheme == 7){
      PanelEleven.GetComponent<Image>().sprite = Squid_Character;
      IntCharacterEleven = 7;
      }
      if (IntCharacterTheme == 8){
      PanelEleven.GetComponent<Image>().sprite = Flame_Character;
      IntCharacterEleven = 8;
      }
      if (IntCharacterTheme == 9){
      PanelEleven.GetComponent<Image>().sprite = Strawberry_Character;
      IntCharacterEleven = 9;
      }
      if (IntCharacterTheme == 10){
      PanelEleven.GetComponent<Image>().sprite = Head_Character;
      IntCharacterEleven = 10;
      }
      if (IntCharacterTheme == 11){
      PanelEleven.GetComponent<Image>().sprite = Slime_Character;
      IntCharacterEleven = 11;
      }
      if (IntCharacterTheme == 12){
      PanelEleven.GetComponent<Image>().sprite = Bunny_Character;
      IntCharacterEleven = 12;
      }
      if (IntCharacterTheme == 13){
      PanelEleven.GetComponent<Image>().sprite = Mushroom_Character;
      IntCharacterEleven = 13;
      }
      if (IntCharacterTheme == 14){
      PanelEleven.GetComponent<Image>().sprite = IceCream_Character;
      IntCharacterEleven = 14;
      }
      if (IntCharacterTheme == 15){
      PanelEleven.GetComponent<Image>().sprite = Bear_Character;
      IntCharacterEleven = 15;
      }
      if (IntCharacterTheme == 16){
      PanelEleven.GetComponent<Image>().sprite = Flower_Character;
      IntCharacterEleven = 16;
      }
      if (IntCharacterTheme == 17){
      PanelEleven.GetComponent<Image>().sprite = JellyFish_Character;
      IntCharacterEleven = 17;
      }
      if (IntCharacterTheme == 18){
      PanelEleven.GetComponent<Image>().sprite = Flowers_Theme;
      IntCharacterEleven = 18;
      }
      if (IntCharacterTheme == 19){
      PanelEleven.GetComponent<Image>().sprite = Pyramids_Theme;
      IntCharacterEleven = 19;
      }
      if (IntCharacterTheme == 20){
      PanelEleven.GetComponent<Image>().sprite = Desert_Theme;
      IntCharacterEleven = 20;
      }
      if (IntCharacterTheme == 21){
      PanelEleven.GetComponent<Image>().sprite = Snow_Theme;
      IntCharacterEleven = 21;
      }
      if (IntCharacterTheme == 22){
      PanelEleven.GetComponent<Image>().sprite = Island_Theme;
      IntCharacterEleven = 22;
      }
      if (IntCharacterTheme == 23){
      PanelEleven.GetComponent<Image>().sprite = Volcano_Theme;
      IntCharacterEleven = 23;
      }
      if (IntCharacterTheme == 24){
      PanelEleven.GetComponent<Image>().sprite = NightSky_Theme;
      IntCharacterEleven = 24;
      }
      if (IntCharacterTheme == 25){
      PanelEleven.GetComponent<Image>().sprite = Autumn_Theme;
      IntCharacterEleven = 25;
      }
      if (IntCharacterTheme == 26){
      PanelEleven.GetComponent<Image>().sprite = Dinosaurus_Theme;
      IntCharacterEleven = 26;
      }
      if (IntCharacterTheme == 27){
      PanelEleven.GetComponent<Image>().sprite = Aquarium_Theme;
      IntCharacterEleven = 27;
      }
      if (IntCharacterTheme == 28){
      PanelEleven.GetComponent<Image>().sprite = Space_Theme;
      IntCharacterEleven = 28;
      }
      if (IntCharacterTheme == 29){
      PanelEleven.GetComponent<Image>().sprite = Rain_Theme;
      IntCharacterEleven = 29;
      }

      PlayerPrefs.SetInt("IntCharacterEleven", IntCharacterEleven); 
    }

    if (IntPanel == 12){

      if (IntTwelve == 0)
      {
        LastTimeTwelve = (ulong)DateTime.Now.Ticks;
        PlayerPrefs.SetString("TwelveTable", LastTimeTwelve.ToString());
      }

      IntTwelve = 1;
      PlayerPrefs.SetInt("IntTwelve", IntTwelve); 

      GameObjectTwelve.SetActive(true);

      if (IntCharacterTheme == 1){
      PanelTwelve.GetComponent<Image>().sprite = Star_Character;
      IntCharacterTwelve = 1;
      }
      if (IntCharacterTheme == 2){
      PanelTwelve.GetComponent<Image>().sprite = Cupcake_Character;
      IntCharacterTwelve = 2;
      }
      if (IntCharacterTheme == 3){
      PanelTwelve.GetComponent<Image>().sprite = Heart_Character;
      IntCharacterTwelve = 3;
      }
      if (IntCharacterTheme == 4){
      PanelTwelve.GetComponent<Image>().sprite = Ballon_Character;
      IntCharacterTwelve = 4;
      }
      if (IntCharacterTheme == 5){
      PanelTwelve.GetComponent<Image>().sprite = Crab_Character;
      IntCharacterTwelve = 5;
      }
      if (IntCharacterTheme == 6){
      PanelTwelve.GetComponent<Image>().sprite = Ghost_Character;
      IntCharacterTwelve = 6;
      }
      if (IntCharacterTheme == 7){
      PanelTwelve.GetComponent<Image>().sprite = Squid_Character;
      IntCharacterTwelve = 7;
      }
      if (IntCharacterTheme == 8){
      PanelTwelve.GetComponent<Image>().sprite = Flame_Character;
      IntCharacterTwelve = 8;
      }
      if (IntCharacterTheme == 9){
      PanelTwelve.GetComponent<Image>().sprite = Strawberry_Character;
      IntCharacterTwelve = 9;
      }
      if (IntCharacterTheme == 10){
      PanelTwelve.GetComponent<Image>().sprite = Head_Character;
      IntCharacterTwelve = 10;
      }
      if (IntCharacterTheme == 11){
      PanelTwelve.GetComponent<Image>().sprite = Slime_Character;
      IntCharacterTwelve = 11;
      }
      if (IntCharacterTheme == 12){
      PanelTwelve.GetComponent<Image>().sprite = Bunny_Character;
      IntCharacterTwelve = 12;
      }
      if (IntCharacterTheme == 13){
      PanelTwelve.GetComponent<Image>().sprite = Mushroom_Character;
      IntCharacterTwelve = 13;
      }
      if (IntCharacterTheme == 14){
      PanelTwelve.GetComponent<Image>().sprite = IceCream_Character;
      IntCharacterTwelve = 14;
      }
      if (IntCharacterTheme == 15){
      PanelTwelve.GetComponent<Image>().sprite = Bear_Character;
      IntCharacterTwelve = 15;
      }
      if (IntCharacterTheme == 16){
      PanelTwelve.GetComponent<Image>().sprite = Flower_Character;
      IntCharacterTwelve = 16;
      }
      if (IntCharacterTheme == 17){
      PanelTwelve.GetComponent<Image>().sprite = JellyFish_Character;
      IntCharacterTwelve = 17;
      }
      if (IntCharacterTheme == 18){
      PanelTwelve.GetComponent<Image>().sprite = Flowers_Theme;
      IntCharacterTwelve = 18;
      }
      if (IntCharacterTheme == 19){
      PanelTwelve.GetComponent<Image>().sprite = Pyramids_Theme;
      IntCharacterTwelve = 19;
      }
      if (IntCharacterTheme == 20){
      PanelTwelve.GetComponent<Image>().sprite = Desert_Theme;
      IntCharacterTwelve = 20;
      }
      if (IntCharacterTheme == 21){
      PanelTwelve.GetComponent<Image>().sprite = Snow_Theme;
      IntCharacterTwelve = 21;
      }
      if (IntCharacterTheme == 22){
      PanelTwelve.GetComponent<Image>().sprite = Island_Theme;
      IntCharacterTwelve = 22;
      }
      if (IntCharacterTheme == 23){
      PanelTwelve.GetComponent<Image>().sprite = Volcano_Theme;
      IntCharacterTwelve = 23;
      }
      if (IntCharacterTheme == 24){
      PanelTwelve.GetComponent<Image>().sprite = NightSky_Theme;
      IntCharacterTwelve = 24;
      }
      if (IntCharacterTheme == 25){
      PanelTwelve.GetComponent<Image>().sprite = Autumn_Theme;
      IntCharacterTwelve = 25;
      }
      if (IntCharacterTheme == 26){
      PanelTwelve.GetComponent<Image>().sprite = Dinosaurus_Theme;
      IntCharacterTwelve = 26;
      }
      if (IntCharacterTheme == 27){
      PanelTwelve.GetComponent<Image>().sprite = Aquarium_Theme;
      IntCharacterTwelve = 27;
      }
      if (IntCharacterTheme == 28){
      PanelTwelve.GetComponent<Image>().sprite = Space_Theme;
      IntCharacterTwelve = 28;
      }
      if (IntCharacterTheme == 29){
      PanelTwelve.GetComponent<Image>().sprite = Rain_Theme;
      IntCharacterTwelve = 29;
      }

      PlayerPrefs.SetInt("IntCharacterTwelve", IntCharacterTwelve);
    }

    if (IntPanel == 13){

      if (IntThreeteen == 0)
      {
        LastTimeThreeteen = (ulong)DateTime.Now.Ticks;
        PlayerPrefs.SetString("ThirteenTable", LastTimeThreeteen.ToString());
      }

      IntThreeteen = 1;
      PlayerPrefs.SetInt("IntThreeteen", IntThreeteen); 

      GameObjectThreeteen.SetActive(true);

      if (IntCharacterTheme == 1){
      PanelThreeteen.GetComponent<Image>().sprite = Star_Character;
      IntCharacterThirteen = 1;
      }
      if (IntCharacterTheme == 2){
      PanelThreeteen.GetComponent<Image>().sprite = Cupcake_Character;
      IntCharacterThirteen = 2;
      }
      if (IntCharacterTheme == 3){
      PanelThreeteen.GetComponent<Image>().sprite = Heart_Character;
      IntCharacterThirteen = 3;
      }
      if (IntCharacterTheme == 4){
      PanelThreeteen.GetComponent<Image>().sprite = Ballon_Character;
      IntCharacterThirteen = 4;
      }
      if (IntCharacterTheme == 5){
      PanelThreeteen.GetComponent<Image>().sprite = Crab_Character;
      IntCharacterThirteen = 5;
      }
      if (IntCharacterTheme == 6){
      PanelThreeteen.GetComponent<Image>().sprite = Ghost_Character;
      IntCharacterThirteen = 6;
      }
      if (IntCharacterTheme == 7){
      PanelThreeteen.GetComponent<Image>().sprite = Squid_Character;
      IntCharacterThirteen = 7;
      }
      if (IntCharacterTheme == 8){
      PanelThreeteen.GetComponent<Image>().sprite = Flame_Character;
      IntCharacterThirteen = 8;
      }
      if (IntCharacterTheme == 9){
      PanelThreeteen.GetComponent<Image>().sprite = Strawberry_Character;
      IntCharacterThirteen = 9;
      }
      if (IntCharacterTheme == 10){
      PanelThreeteen.GetComponent<Image>().sprite = Head_Character;
      IntCharacterThirteen = 10;
      }
      if (IntCharacterTheme == 11){
      PanelThreeteen.GetComponent<Image>().sprite = Slime_Character;
      IntCharacterThirteen = 11;
      }
      if (IntCharacterTheme == 12){
      PanelThreeteen.GetComponent<Image>().sprite = Bunny_Character;
      IntCharacterThirteen = 12;
      }
      if (IntCharacterTheme == 13){
      PanelThreeteen.GetComponent<Image>().sprite = Mushroom_Character;
      IntCharacterThirteen = 13;
      }
      if (IntCharacterTheme == 14){
      PanelThreeteen.GetComponent<Image>().sprite = IceCream_Character;
      IntCharacterThirteen = 14;
      }
      if (IntCharacterTheme == 15){
      PanelThreeteen.GetComponent<Image>().sprite = Bear_Character;
      IntCharacterThirteen = 15;
      }
      if (IntCharacterTheme == 16){
      PanelThreeteen.GetComponent<Image>().sprite = Flower_Character;
      IntCharacterThirteen = 16;
      }
      if (IntCharacterTheme == 17){
      PanelThreeteen.GetComponent<Image>().sprite = JellyFish_Character;
      IntCharacterThirteen = 17;
      }
      if (IntCharacterTheme == 18){
      PanelThreeteen.GetComponent<Image>().sprite = Flowers_Theme;
      IntCharacterThirteen = 18;
      }
      if (IntCharacterTheme == 19){
      PanelThreeteen.GetComponent<Image>().sprite = Pyramids_Theme;
      IntCharacterThirteen = 19;
      }
      if (IntCharacterTheme == 20){
      PanelThreeteen.GetComponent<Image>().sprite = Desert_Theme;
      IntCharacterThirteen = 20;
      }
      if (IntCharacterTheme == 21){
      PanelThreeteen.GetComponent<Image>().sprite = Snow_Theme;
      IntCharacterThirteen = 21;
      }
      if (IntCharacterTheme == 22){
      PanelThreeteen.GetComponent<Image>().sprite = Island_Theme;
      IntCharacterThirteen = 22;
      }
      if (IntCharacterTheme == 23){
      PanelThreeteen.GetComponent<Image>().sprite = Volcano_Theme;
      IntCharacterThirteen = 23;
      }
      if (IntCharacterTheme == 24){
      PanelThreeteen.GetComponent<Image>().sprite = NightSky_Theme;
      IntCharacterThirteen = 24;
      }
      if (IntCharacterTheme == 25){
      PanelThreeteen.GetComponent<Image>().sprite = Autumn_Theme;
      IntCharacterThirteen = 25;
      }
      if (IntCharacterTheme == 26){
      PanelThreeteen.GetComponent<Image>().sprite = Dinosaurus_Theme;
      IntCharacterThirteen = 26;
      }
      if (IntCharacterTheme == 27){
      PanelThreeteen.GetComponent<Image>().sprite = Aquarium_Theme;
      IntCharacterThirteen = 27;
      }
      if (IntCharacterTheme == 28){
      PanelThreeteen.GetComponent<Image>().sprite = Space_Theme;
      IntCharacterThirteen = 28;
      }
      if (IntCharacterTheme == 29){
      PanelThreeteen.GetComponent<Image>().sprite = Rain_Theme;
      IntCharacterThirteen = 29;
      }

      PlayerPrefs.SetInt("IntCharacterThirteen", IntCharacterThirteen); 
    }

    if (IntPanel == 14){

      if (IntFourteen == 0)
      {
        LastTimeFourteen = (ulong)DateTime.Now.Ticks;
        PlayerPrefs.SetString("FourteenTable", LastTimeFourteen.ToString());
      }

      IntFourteen = 1;
      PlayerPrefs.SetInt("IntFourteen", IntFourteen); 

      GameObjectFourteen.SetActive(true);

      if (IntCharacterTheme == 1){
      PanelFourteen.GetComponent<Image>().sprite = Star_Character;
      IntCharacterFourteen = 1;
      }
      if (IntCharacterTheme == 2){
      PanelFourteen.GetComponent<Image>().sprite = Cupcake_Character;
      IntCharacterFourteen = 2;
      }
      if (IntCharacterTheme == 3){
      PanelFourteen.GetComponent<Image>().sprite = Heart_Character;
      IntCharacterFourteen = 3;
      }
      if (IntCharacterTheme == 4){
      PanelFourteen.GetComponent<Image>().sprite = Ballon_Character;
      IntCharacterFourteen = 4;
      }
      if (IntCharacterTheme == 5){
      PanelFourteen.GetComponent<Image>().sprite = Crab_Character;
      IntCharacterFourteen = 5;
      }
      if (IntCharacterTheme == 6){
      PanelFourteen.GetComponent<Image>().sprite = Ghost_Character;
      IntCharacterFourteen = 6;
      }
      if (IntCharacterTheme == 7){
      PanelFourteen.GetComponent<Image>().sprite = Squid_Character;
      IntCharacterFourteen = 7;
      }
      if (IntCharacterTheme == 8){
      PanelFourteen.GetComponent<Image>().sprite = Flame_Character;
      IntCharacterFourteen = 8;
      }
      if (IntCharacterTheme == 9){
      PanelFourteen.GetComponent<Image>().sprite = Strawberry_Character;
      IntCharacterFourteen = 9;
      }
      if (IntCharacterTheme == 10){
      PanelFourteen.GetComponent<Image>().sprite = Head_Character;
      IntCharacterFourteen = 10;
      }
      if (IntCharacterTheme == 11){
      PanelFourteen.GetComponent<Image>().sprite = Slime_Character;
      IntCharacterFourteen = 11;
      }
      if (IntCharacterTheme == 12){
      PanelFourteen.GetComponent<Image>().sprite = Bunny_Character;
      IntCharacterFourteen = 12;
      }
      if (IntCharacterTheme == 13){
      PanelFourteen.GetComponent<Image>().sprite = Mushroom_Character;
      IntCharacterFourteen = 13;
      }
      if (IntCharacterTheme == 14){
      PanelFourteen.GetComponent<Image>().sprite = IceCream_Character;
      IntCharacterFourteen = 14;
      }
      if (IntCharacterTheme == 15){
      PanelFourteen.GetComponent<Image>().sprite = Bear_Character;
      IntCharacterFourteen = 15;
      }
      if (IntCharacterTheme == 16){
      PanelFourteen.GetComponent<Image>().sprite = Flower_Character;
      IntCharacterFourteen = 16;
      }
      if (IntCharacterTheme == 17){
      PanelFourteen.GetComponent<Image>().sprite = JellyFish_Character;
      IntCharacterFourteen = 17;
      }
      if (IntCharacterTheme == 18){
      PanelFourteen.GetComponent<Image>().sprite = Flowers_Theme;
      IntCharacterFourteen = 18;
      }
      if (IntCharacterTheme == 19){
      PanelFourteen.GetComponent<Image>().sprite = Pyramids_Theme;
      IntCharacterFourteen = 19;
      }
      if (IntCharacterTheme == 20){
      PanelFourteen.GetComponent<Image>().sprite = Desert_Theme;
      IntCharacterFourteen = 20;
      }
      if (IntCharacterTheme == 21){
      PanelFourteen.GetComponent<Image>().sprite = Snow_Theme;
      IntCharacterFourteen = 21;
      }
      if (IntCharacterTheme == 22){
      PanelFourteen.GetComponent<Image>().sprite = Island_Theme;
      IntCharacterFourteen = 22;
      }
      if (IntCharacterTheme == 23){
      PanelFourteen.GetComponent<Image>().sprite = Volcano_Theme;
      IntCharacterFourteen = 23;
      }
      if (IntCharacterTheme == 24){
      PanelFourteen.GetComponent<Image>().sprite = NightSky_Theme;
      IntCharacterFourteen = 24;
      }
      if (IntCharacterTheme == 25){
      PanelFourteen.GetComponent<Image>().sprite = Autumn_Theme;
      IntCharacterFourteen = 25;
      }
      if (IntCharacterTheme == 26){
      PanelFourteen.GetComponent<Image>().sprite = Dinosaurus_Theme;
      IntCharacterFourteen = 26;
      }
      if (IntCharacterTheme == 27){
      PanelFourteen.GetComponent<Image>().sprite = Aquarium_Theme;
      IntCharacterFourteen = 27;
      }
      if (IntCharacterTheme == 28){
      PanelFourteen.GetComponent<Image>().sprite = Space_Theme;
      IntCharacterFourteen = 28;
      }
      if (IntCharacterTheme == 29){
      PanelFourteen.GetComponent<Image>().sprite = Rain_Theme;
      IntCharacterFourteen = 29;
      }

      PlayerPrefs.SetInt("IntCharacterFourteen", IntCharacterFourteen); 
    }

    if (IntPanel == 15){

      if (IntFiveteen == 0)
      {
        LastTimeFiveteen = (ulong)DateTime.Now.Ticks;
        PlayerPrefs.SetString("FifteenTable", LastTimeFiveteen.ToString());
      }

      IntFiveteen = 1;
      PlayerPrefs.SetInt("IntFiveteen", IntFiveteen); 

      GameObjectFiveteen.SetActive(true);

      if (IntCharacterTheme == 1){
      PanelFiveteen.GetComponent<Image>().sprite = Star_Character;
      IntCharacterFifteen = 1;
      }
      if (IntCharacterTheme == 2){
      PanelFiveteen.GetComponent<Image>().sprite = Cupcake_Character;
      IntCharacterFifteen = 2;
      }
      if (IntCharacterTheme == 3){
      PanelFiveteen.GetComponent<Image>().sprite = Heart_Character;
      IntCharacterFifteen = 3;
      }
      if (IntCharacterTheme == 4){
      PanelFiveteen.GetComponent<Image>().sprite = Ballon_Character;
      IntCharacterFifteen = 4;
      }
      if (IntCharacterTheme == 5){
      PanelFiveteen.GetComponent<Image>().sprite = Crab_Character;
      IntCharacterFifteen = 5;
      }
      if (IntCharacterTheme == 6){
      PanelFiveteen.GetComponent<Image>().sprite = Ghost_Character;
      IntCharacterFifteen = 6;
      }
      if (IntCharacterTheme == 7){
      PanelFiveteen.GetComponent<Image>().sprite = Squid_Character;
      IntCharacterFifteen = 7;
      }
      if (IntCharacterTheme == 8){
      PanelFiveteen.GetComponent<Image>().sprite = Flame_Character;
      IntCharacterFifteen = 8;
      }
      if (IntCharacterTheme == 9){
      PanelFiveteen.GetComponent<Image>().sprite = Strawberry_Character;
      IntCharacterFifteen = 9;
      }
      if (IntCharacterTheme == 10){
      PanelFiveteen.GetComponent<Image>().sprite = Head_Character;
      IntCharacterFifteen = 10;
      }
      if (IntCharacterTheme == 11){
      PanelFiveteen.GetComponent<Image>().sprite = Slime_Character;
      IntCharacterFifteen = 11;
      }
      if (IntCharacterTheme == 12){
      PanelFiveteen.GetComponent<Image>().sprite = Bunny_Character;
      IntCharacterFifteen = 12;
      }
      if (IntCharacterTheme == 13){
      PanelFiveteen.GetComponent<Image>().sprite = Mushroom_Character;
      IntCharacterFifteen = 13;
      }
      if (IntCharacterTheme == 14){
      PanelFiveteen.GetComponent<Image>().sprite = IceCream_Character;
      IntCharacterFifteen = 14;
      }
      if (IntCharacterTheme == 15){
      PanelFiveteen.GetComponent<Image>().sprite = Bear_Character;
      IntCharacterFifteen = 15;
      }
      if (IntCharacterTheme == 16){
      PanelFiveteen.GetComponent<Image>().sprite = Flower_Character;
      IntCharacterFifteen = 16;
      }
      if (IntCharacterTheme == 17){
      PanelFiveteen.GetComponent<Image>().sprite = JellyFish_Character;
      IntCharacterFifteen = 17;
      }
      if (IntCharacterTheme == 18){
      PanelFiveteen.GetComponent<Image>().sprite = Flowers_Theme;
      IntCharacterFifteen = 18;
      }
      if (IntCharacterTheme == 19){
      PanelFiveteen.GetComponent<Image>().sprite = Pyramids_Theme;
      IntCharacterFifteen = 19;
      }
      if (IntCharacterTheme == 20){
      PanelFiveteen.GetComponent<Image>().sprite = Desert_Theme;
      IntCharacterFifteen = 20;
      }
      if (IntCharacterTheme == 21){
      PanelFiveteen.GetComponent<Image>().sprite = Snow_Theme;
      IntCharacterFifteen = 21;
      }
      if (IntCharacterTheme == 22){
      PanelFiveteen.GetComponent<Image>().sprite = Island_Theme;
      IntCharacterFifteen = 22;
      }
      if (IntCharacterTheme == 23){
      PanelFiveteen.GetComponent<Image>().sprite = Volcano_Theme;
      IntCharacterFifteen = 23;
      }
      if (IntCharacterTheme == 24){
      PanelFiveteen.GetComponent<Image>().sprite = NightSky_Theme;
      IntCharacterFifteen = 24;
      }
      if (IntCharacterTheme == 25){
      PanelFiveteen.GetComponent<Image>().sprite = Autumn_Theme;
      IntCharacterFifteen = 25;
      }
      if (IntCharacterTheme == 26){
      PanelFiveteen.GetComponent<Image>().sprite = Dinosaurus_Theme;
      IntCharacterFifteen = 26;
      }
      if (IntCharacterTheme == 27){
      PanelFiveteen.GetComponent<Image>().sprite = Aquarium_Theme;
      IntCharacterFifteen = 27;
      }
      if (IntCharacterTheme == 28){
      PanelFiveteen.GetComponent<Image>().sprite = Space_Theme;
      IntCharacterFifteen = 28;
      }
      if (IntCharacterTheme == 29){
      PanelFiveteen.GetComponent<Image>().sprite = Rain_Theme;
      IntCharacterFifteen = 29;
      }

      PlayerPrefs.SetInt("IntCharacterFifteen", IntCharacterFifteen); 
    }
}

private void Update ()
{
    if (IntFirst == 1){
    ulong Biff_First = ((ulong)DateTime.Now.Ticks - LastTimeFirst);
    ulong M_First = Biff_First / TimeSpan.TicksPerMillisecond;
    float SecondsLeftFirst = (float)(WaitMsFirst - M_First) / 1000.0f;

    string StringFirst = "";
    // HOURS
    StringFirst += ((int)SecondsLeftFirst / 3600).ToString() + ":";
    SecondsLeftFirst -= ((int)SecondsLeftFirst / 3600) * 3600;
    //MINUTES
    StringFirst += ((int)SecondsLeftFirst / 60).ToString("00") + ":";
    //SECONDS
    StringFirst += (SecondsLeftFirst % 60).ToString("00");
    TextFirst.text = StringFirst;

        if (SecondsLeftFirst < 0)
        {
            ObjectFirst.SetActive(false);

            IntPanelSpecial -= 1;
            PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial);

            if (IntPanelSpecial <= 0)
            {
                IntPanel = 0;
                PlayerPrefs.SetInt("IntPanel", IntPanel);
            }

            IntFirst = 0;
            PlayerPrefs.SetInt("IntFirst", IntFirst);

            if (PanelFirst.GetComponent<Image>().sprite == Star_Character) {
            ScriptCharacter.TimerBonusThemeStarLeft();
            }
            if (PanelFirst.GetComponent<Image>().sprite == Cupcake_Character) {
            ScriptCharacter.TimerBonusThemeCupCakeLeft();
            }
            if (PanelFirst.GetComponent<Image>().sprite == Heart_Character) {
            ScriptCharacter.TimerBonusThemeHeartLeft();
            }
            if (PanelFirst.GetComponent<Image>().sprite == Ballon_Character) {
            ScriptCharacter.TimerBonusThemeCrabLeft();
            }
            if (PanelFirst.GetComponent<Image>().sprite == Crab_Character) {
            ScriptCharacter.TimerBonusThemeBalloonLeft();
            }
            if (PanelFirst.GetComponent<Image>().sprite == Ghost_Character) {
            ScriptCharacter.TimerBonusThemeGhostLeft();
            }
            if (PanelFirst.GetComponent<Image>().sprite == Squid_Character) {
            ScriptCharacter.TimerBonusThemeSquidLeft();
            }
            if (PanelFirst.GetComponent<Image>().sprite == Flame_Character) {
            ScriptCharacter.TimerBonusThemeFlameLeft();
            }
            if (PanelFirst.GetComponent<Image>().sprite == Strawberry_Character) {
            ScriptCharacter.TimerBonusThemeStrawberryLeft();
            }
            if (PanelFirst.GetComponent<Image>().sprite == Head_Character) {
            ScriptCharacter.TimerBonusThemeHeadLeft();
            }
            if (PanelFirst.GetComponent<Image>().sprite == Slime_Character) {
            ScriptCharacter.TimerBonusThemeSlimeLeft();
            }
            if (PanelFirst.GetComponent<Image>().sprite == Bunny_Character) {
            ScriptCharacter.TimerBonusThemeBunnyLeft();
            }
            if (PanelFirst.GetComponent<Image>().sprite == Mushroom_Character) {
            ScriptCharacter.TimerBonusThemeMushroomLeft();
            }
            if (PanelFirst.GetComponent<Image>().sprite == IceCream_Character) {
            ScriptCharacter.TimerBonusThemeIceCreamLeft();
            }
            if (PanelFirst.GetComponent<Image>().sprite == Bear_Character) {
            ScriptCharacter.TimerBonusThemeBearLeft();
            }
            if (PanelFirst.GetComponent<Image>().sprite == Flower_Character) {
            ScriptCharacter.TimerBonusThemeFlowerLeft();
            }
            if (PanelFirst.GetComponent<Image>().sprite == JellyFish_Character) {
            ScriptCharacter.TimerBonusThemeJellyFishLeft();
            }
            if (PanelFirst.GetComponent<Image>().sprite == Flowers_Theme) {
            ScriptTheme.TimerBonusThemeFlowerLeft();
            }
            if (PanelFirst.GetComponent<Image>().sprite == Pyramids_Theme) {
            ScriptTheme.TimerBonusThemePyramidsLeft();
            }
            if (PanelFirst.GetComponent<Image>().sprite == Desert_Theme) {
            ScriptTheme.TimerBonusThemeDesertLeft();
            }
            if (PanelFirst.GetComponent<Image>().sprite == Snow_Theme) {
            ScriptTheme.TimerBonusThemeSnowLeft();
            }
            if (PanelFirst.GetComponent<Image>().sprite == Island_Theme) {
            ScriptTheme.TimerBonusThemeIslandLeft();
            }
            if (PanelFirst.GetComponent<Image>().sprite == Volcano_Theme) {
            ScriptTheme.TimerBonusThemeVolcanoLeft();
            }
            if (PanelFirst.GetComponent<Image>().sprite == NightSky_Theme) {
            ScriptTheme.TimerBonusThemeNightSkyLeft();
            }
            if (PanelFirst.GetComponent<Image>().sprite == Autumn_Theme) {
            ScriptTheme.TimerBonusThemeAutumnLeft();
            }
            if (PanelFirst.GetComponent<Image>().sprite == Dinosaurus_Theme) {
            ScriptTheme.TimerBonusThemeDinosaurusLeft();
            }
            if (PanelFirst.GetComponent<Image>().sprite == Aquarium_Theme) {
            ScriptTheme.TimerBonusThemeAquariumLeft();
            }
            if (PanelFirst.GetComponent<Image>().sprite == Space_Theme) {
            ScriptTheme.TimerBonusThemeSpaceLeft();
            }
            if (PanelFirst.GetComponent<Image>().sprite == Rain_Theme) {
            ScriptTheme.TimerBonusThemeRainLeft();
            }

            PanelFirst.GetComponent<Image>().sprite = Clasic_Sprite;
        }
    }

    if (IntSecond == 1){
    ulong Biff_Second = ((ulong)DateTime.Now.Ticks - LastTimeSecond);
    ulong M_Second = Biff_Second / TimeSpan.TicksPerMillisecond;
    float SecondsLeftSecond = (float)(WaitMsSecond - M_Second) / 1000.0f;

    string StringSecond = "";
    // HOURS
    StringSecond += ((int)SecondsLeftSecond / 3600).ToString() + ":";
    SecondsLeftSecond -= ((int)SecondsLeftSecond / 3600) * 3600;
    //MINUTES
    StringSecond += ((int)SecondsLeftSecond / 60).ToString("00") + ":";
    //SECONDS
    StringSecond += (SecondsLeftSecond % 60).ToString("00");
    TextSecond.text = StringSecond;

        if (SecondsLeftSecond < 0)
        {
            ObjectSecond.SetActive(false);

            IntPanelSpecial -= 1;
            PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial);

            if (IntPanelSpecial <= 0)
            {
              IntPanel = 0;
              PlayerPrefs.SetInt("IntPanel", IntPanel);
            }

            IntSecond = 0;
            PlayerPrefs.SetInt("IntSecond", IntSecond); 

            if (PanelSecond.GetComponent<Image>().sprite == Star_Character) {
            ScriptCharacter.TimerBonusThemeStarLeft();
            }
            if (PanelSecond.GetComponent<Image>().sprite == Cupcake_Character) {
            ScriptCharacter.TimerBonusThemeCupCakeLeft();
            }
            if (PanelSecond.GetComponent<Image>().sprite == Heart_Character) {
            ScriptCharacter.TimerBonusThemeHeartLeft();
            }
            if (PanelSecond.GetComponent<Image>().sprite == Ballon_Character) {
            ScriptCharacter.TimerBonusThemeCrabLeft();
            }
            if (PanelSecond.GetComponent<Image>().sprite == Crab_Character) {
            ScriptCharacter.TimerBonusThemeBalloonLeft();
            }
            if (PanelSecond.GetComponent<Image>().sprite == Ghost_Character) {
            ScriptCharacter.TimerBonusThemeGhostLeft();
            }
            if (PanelSecond.GetComponent<Image>().sprite == Squid_Character) {
            ScriptCharacter.TimerBonusThemeSquidLeft();
            }
            if (PanelSecond.GetComponent<Image>().sprite == Flame_Character) {
            ScriptCharacter.TimerBonusThemeFlameLeft();
            }
            if (PanelSecond.GetComponent<Image>().sprite == Strawberry_Character) {
            ScriptCharacter.TimerBonusThemeStrawberryLeft();
            }
            if (PanelSecond.GetComponent<Image>().sprite == Head_Character) {
            ScriptCharacter.TimerBonusThemeHeadLeft();
            }
            if (PanelSecond.GetComponent<Image>().sprite == Slime_Character) {
            ScriptCharacter.TimerBonusThemeSlimeLeft();
            }
            if (PanelSecond.GetComponent<Image>().sprite == Bunny_Character) {
            ScriptCharacter.TimerBonusThemeBunnyLeft();
            }
            if (PanelSecond.GetComponent<Image>().sprite == Mushroom_Character) {
            ScriptCharacter.TimerBonusThemeMushroomLeft();
            }
            if (PanelSecond.GetComponent<Image>().sprite == IceCream_Character) {
            ScriptCharacter.TimerBonusThemeIceCreamLeft();
            }
            if (PanelSecond.GetComponent<Image>().sprite == Bear_Character) {
            ScriptCharacter.TimerBonusThemeBearLeft();
            }
            if (PanelSecond.GetComponent<Image>().sprite == Flower_Character) {
            ScriptCharacter.TimerBonusThemeFlowerLeft();
            }
            if (PanelSecond.GetComponent<Image>().sprite == JellyFish_Character) {
            ScriptCharacter.TimerBonusThemeJellyFishLeft();
            }
            if (PanelSecond.GetComponent<Image>().sprite == Flowers_Theme) {
            ScriptTheme.TimerBonusThemeFlowerLeft();
            }
            if (PanelSecond.GetComponent<Image>().sprite == Pyramids_Theme) {
            ScriptTheme.TimerBonusThemePyramidsLeft();
            }
            if (PanelSecond.GetComponent<Image>().sprite == Desert_Theme) {
            ScriptTheme.TimerBonusThemeDesertLeft();
            }
            if (PanelSecond.GetComponent<Image>().sprite == Snow_Theme) {
            ScriptTheme.TimerBonusThemeSnowLeft();
            }
            if (PanelSecond.GetComponent<Image>().sprite == Island_Theme) {
            ScriptTheme.TimerBonusThemeIslandLeft();
            }
            if (PanelSecond.GetComponent<Image>().sprite == Volcano_Theme) {
            ScriptTheme.TimerBonusThemeVolcanoLeft();
            }
            if (PanelSecond.GetComponent<Image>().sprite == NightSky_Theme) {
            ScriptTheme.TimerBonusThemeNightSkyLeft();
            }
            if (PanelSecond.GetComponent<Image>().sprite == Autumn_Theme) {
            ScriptTheme.TimerBonusThemeAutumnLeft();
            }
            if (PanelSecond.GetComponent<Image>().sprite == Dinosaurus_Theme) {
            ScriptTheme.TimerBonusThemeDinosaurusLeft();
            }
            if (PanelSecond.GetComponent<Image>().sprite == Aquarium_Theme) {
            ScriptTheme.TimerBonusThemeAquariumLeft();
            }
            if (PanelSecond.GetComponent<Image>().sprite == Space_Theme) {
            ScriptTheme.TimerBonusThemeSpaceLeft();
            }
            if (PanelSecond.GetComponent<Image>().sprite == Rain_Theme) {
            ScriptTheme.TimerBonusThemeRainLeft();
            }

            PanelSecond.GetComponent<Image>().sprite = Clasic_Sprite;
        }
    }

    if (IntThirt == 1){
    ulong Biff_Thirt = ((ulong)DateTime.Now.Ticks - LastTimeThirt);
    ulong M_Thirt = Biff_Thirt / TimeSpan.TicksPerMillisecond;
    float SecondsLeftThirt = (float)(WaitMsThirt - M_Thirt) / 1000.0f;

    string StringThirt = "";
    // HOURS
    StringThirt += ((int)SecondsLeftThirt / 3600).ToString() + ":";
    SecondsLeftThirt -= ((int)SecondsLeftThirt / 3600) * 3600;
    //MINUTES
    StringThirt += ((int)SecondsLeftThirt / 60).ToString("00") + ":";
    //SECONDS
    StringThirt += (SecondsLeftThirt % 60).ToString("00");
    TextThirt.text = StringThirt;

        if (SecondsLeftThirt < 0)
        {
            ObjectThirt.SetActive(false);

            IntPanelSpecial -= 1;
            PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial);

            if (IntPanelSpecial <= 0)
            {
              IntPanel = 0;
              PlayerPrefs.SetInt("IntPanel", IntPanel);
            }

            IntThirt = 0;
            PlayerPrefs.SetInt("IntThirt", IntThirt); 

            if (PanelThirt.GetComponent<Image>().sprite == Star_Character) {
            ScriptCharacter.TimerBonusThemeStarLeft();
            }
            if (PanelThirt.GetComponent<Image>().sprite == Cupcake_Character) {
            ScriptCharacter.TimerBonusThemeCupCakeLeft();
            }
            if (PanelThirt.GetComponent<Image>().sprite == Heart_Character) {
            ScriptCharacter.TimerBonusThemeHeartLeft();
            }
            if (PanelThirt.GetComponent<Image>().sprite == Ballon_Character) {
            ScriptCharacter.TimerBonusThemeCrabLeft();
            }
            if (PanelThirt.GetComponent<Image>().sprite == Crab_Character) {
            ScriptCharacter.TimerBonusThemeBalloonLeft();
            }
            if (PanelThirt.GetComponent<Image>().sprite == Ghost_Character) {
            ScriptCharacter.TimerBonusThemeGhostLeft();
            }
            if (PanelThirt.GetComponent<Image>().sprite == Squid_Character) {
            ScriptCharacter.TimerBonusThemeSquidLeft();
            }
            if (PanelThirt.GetComponent<Image>().sprite == Flame_Character) {
            ScriptCharacter.TimerBonusThemeFlameLeft();
            }
            if (PanelThirt.GetComponent<Image>().sprite == Strawberry_Character) {
            ScriptCharacter.TimerBonusThemeStrawberryLeft();
            }
            if (PanelThirt.GetComponent<Image>().sprite == Head_Character) {
            ScriptCharacter.TimerBonusThemeHeadLeft();
            }
            if (PanelThirt.GetComponent<Image>().sprite == Slime_Character) {
            ScriptCharacter.TimerBonusThemeSlimeLeft();
            }
            if (PanelThirt.GetComponent<Image>().sprite == Bunny_Character) {
            ScriptCharacter.TimerBonusThemeBunnyLeft();
            }
            if (PanelThirt.GetComponent<Image>().sprite == Mushroom_Character) {
            ScriptCharacter.TimerBonusThemeMushroomLeft();
            }
            if (PanelThirt.GetComponent<Image>().sprite == IceCream_Character) {
            ScriptCharacter.TimerBonusThemeIceCreamLeft();
            }
            if (PanelThirt.GetComponent<Image>().sprite == Bear_Character) {
            ScriptCharacter.TimerBonusThemeBearLeft();
            }
            if (PanelThirt.GetComponent<Image>().sprite == Flower_Character) {
            ScriptCharacter.TimerBonusThemeFlowerLeft();
            }
            if (PanelThirt.GetComponent<Image>().sprite == JellyFish_Character) {
            ScriptCharacter.TimerBonusThemeJellyFishLeft();
            }
            if (PanelThirt.GetComponent<Image>().sprite == Flowers_Theme) {
            ScriptTheme.TimerBonusThemeFlowerLeft();
            }
            if (PanelThirt.GetComponent<Image>().sprite == Pyramids_Theme) {
            ScriptTheme.TimerBonusThemePyramidsLeft();
            }
            if (PanelThirt.GetComponent<Image>().sprite == Desert_Theme) {
            ScriptTheme.TimerBonusThemeDesertLeft();
            }
            if (PanelThirt.GetComponent<Image>().sprite == Snow_Theme) {
            ScriptTheme.TimerBonusThemeSnowLeft();
            }
            if (PanelThirt.GetComponent<Image>().sprite == Island_Theme) {
            ScriptTheme.TimerBonusThemeIslandLeft();
            }
            if (PanelThirt.GetComponent<Image>().sprite == Volcano_Theme) {
            ScriptTheme.TimerBonusThemeVolcanoLeft();
            }
            if (PanelThirt.GetComponent<Image>().sprite == NightSky_Theme) {
            ScriptTheme.TimerBonusThemeNightSkyLeft();
            }
            if (PanelThirt.GetComponent<Image>().sprite == Autumn_Theme) {
            ScriptTheme.TimerBonusThemeAutumnLeft();
            }
            if (PanelThirt.GetComponent<Image>().sprite == Dinosaurus_Theme) {
            ScriptTheme.TimerBonusThemeDinosaurusLeft();
            }
            if (PanelThirt.GetComponent<Image>().sprite == Aquarium_Theme) {
            ScriptTheme.TimerBonusThemeAquariumLeft();
            }
            if (PanelThirt.GetComponent<Image>().sprite == Space_Theme) {
            ScriptTheme.TimerBonusThemeSpaceLeft();
            }
            if (PanelThirt.GetComponent<Image>().sprite == Rain_Theme) {
            ScriptTheme.TimerBonusThemeRainLeft();
            }

            PanelThirt.GetComponent<Image>().sprite = Clasic_Sprite;
        }
    }

    if (IntFour == 1){
    ulong Biff_Four = ((ulong)DateTime.Now.Ticks - LastTimeFour);
    ulong M_Four = Biff_Four / TimeSpan.TicksPerMillisecond;
    float SecondsLeftFour = (float)(WaitMsFour - M_Four) / 1000.0f;

    string StringFour = "";
    // HOURS
    StringFour += ((int)SecondsLeftFour / 3600).ToString() + ":";
    SecondsLeftFour -= ((int)SecondsLeftFour / 3600) * 3600;
    //MINUTES
    StringFour += ((int)SecondsLeftFour / 60).ToString("00") + ":";
    //SECONDS
    StringFour += (SecondsLeftFour % 60).ToString("00");
    TextFour.text = StringFour;

        if (SecondsLeftFour < 0)
        {
            ObjectFour.SetActive(false);

            IntPanelSpecial -= 1;
            PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial);

            if (IntPanelSpecial <= 0)
            {
              IntPanel = 0;
              PlayerPrefs.SetInt("IntPanel", IntPanel);
            }

            IntFour = 0;
            PlayerPrefs.SetInt("IntFour", IntFour); 

            if (PanelFour.GetComponent<Image>().sprite == Star_Character) {
            ScriptCharacter.TimerBonusThemeStarLeft();
            }
            if (PanelFour.GetComponent<Image>().sprite == Cupcake_Character) {
            ScriptCharacter.TimerBonusThemeCupCakeLeft();
            }
            if (PanelFour.GetComponent<Image>().sprite == Heart_Character) {
            ScriptCharacter.TimerBonusThemeHeartLeft();
            }
            if (PanelFour.GetComponent<Image>().sprite == Ballon_Character) {
            ScriptCharacter.TimerBonusThemeCrabLeft();
            }
            if (PanelFour.GetComponent<Image>().sprite == Crab_Character) {
            ScriptCharacter.TimerBonusThemeBalloonLeft();
            }
            if (PanelFour.GetComponent<Image>().sprite == Ghost_Character) {
            ScriptCharacter.TimerBonusThemeGhostLeft();
            }
            if (PanelFour.GetComponent<Image>().sprite == Squid_Character) {
            ScriptCharacter.TimerBonusThemeSquidLeft();
            }
            if (PanelFour.GetComponent<Image>().sprite == Flame_Character) {
            ScriptCharacter.TimerBonusThemeFlameLeft();
            }
            if (PanelFour.GetComponent<Image>().sprite == Strawberry_Character) {
            ScriptCharacter.TimerBonusThemeStrawberryLeft();
            }
            if (PanelFour.GetComponent<Image>().sprite == Head_Character) {
            ScriptCharacter.TimerBonusThemeHeadLeft();
            }
            if (PanelFour.GetComponent<Image>().sprite == Slime_Character) {
            ScriptCharacter.TimerBonusThemeSlimeLeft();
            }
            if (PanelFour.GetComponent<Image>().sprite == Bunny_Character) {
            ScriptCharacter.TimerBonusThemeBunnyLeft();
            }
            if (PanelFour.GetComponent<Image>().sprite == Mushroom_Character) {
            ScriptCharacter.TimerBonusThemeMushroomLeft();
            }
            if (PanelFour.GetComponent<Image>().sprite == IceCream_Character) {
            ScriptCharacter.TimerBonusThemeIceCreamLeft();
            }
            if (PanelFour.GetComponent<Image>().sprite == Bear_Character) {
            ScriptCharacter.TimerBonusThemeBearLeft();
            }
            if (PanelFour.GetComponent<Image>().sprite == Flower_Character) {
            ScriptCharacter.TimerBonusThemeFlowerLeft();
            }
            if (PanelFour.GetComponent<Image>().sprite == JellyFish_Character) {
            ScriptCharacter.TimerBonusThemeJellyFishLeft();
            }
            if (PanelFour.GetComponent<Image>().sprite == Flowers_Theme) {
            ScriptTheme.TimerBonusThemeFlowerLeft();
            }
            if (PanelFour.GetComponent<Image>().sprite == Pyramids_Theme) {
            ScriptTheme.TimerBonusThemePyramidsLeft();
            }
            if (PanelFour.GetComponent<Image>().sprite == Desert_Theme) {
            ScriptTheme.TimerBonusThemeDesertLeft();
            }
            if (PanelFour.GetComponent<Image>().sprite == Snow_Theme) {
            ScriptTheme.TimerBonusThemeSnowLeft();
            }
            if (PanelFour.GetComponent<Image>().sprite == Island_Theme) {
            ScriptTheme.TimerBonusThemeIslandLeft();
            }
            if (PanelFour.GetComponent<Image>().sprite == Volcano_Theme) {
            ScriptTheme.TimerBonusThemeVolcanoLeft();
            }
            if (PanelFour.GetComponent<Image>().sprite == NightSky_Theme) {
            ScriptTheme.TimerBonusThemeNightSkyLeft();
            }
            if (PanelFour.GetComponent<Image>().sprite == Autumn_Theme) {
            ScriptTheme.TimerBonusThemeAutumnLeft();
            }
            if (PanelFour.GetComponent<Image>().sprite == Dinosaurus_Theme) {
            ScriptTheme.TimerBonusThemeDinosaurusLeft();
            }
            if (PanelFour.GetComponent<Image>().sprite == Aquarium_Theme) {
            ScriptTheme.TimerBonusThemeAquariumLeft();
            }
            if (PanelFour.GetComponent<Image>().sprite == Space_Theme) {
            ScriptTheme.TimerBonusThemeSpaceLeft();
            }
            if (PanelFour.GetComponent<Image>().sprite == Rain_Theme) {
            ScriptTheme.TimerBonusThemeRainLeft();
            }

            PanelFour.GetComponent<Image>().sprite = Clasic_Sprite;
        }
    }

    if (IntFive == 1){
    ulong Biff_Five = ((ulong)DateTime.Now.Ticks - LastTimeFive);
    ulong M_Five = Biff_Five / TimeSpan.TicksPerMillisecond;
    float SecondsLeftFive = (float)(WaitMsFive - M_Five) / 1000.0f;

    string StringFive = "";
    // HOURS
    StringFive += ((int)SecondsLeftFive / 3600).ToString() + ":";
    SecondsLeftFive -= ((int)SecondsLeftFive / 3600) * 3600;
    //MINUTES
    StringFive += ((int)SecondsLeftFive / 60).ToString("00") + ":";
    //SECONDS
    StringFive += (SecondsLeftFive % 60).ToString("00");
    TextFive.text = StringFive;

        if (SecondsLeftFive < 0)
        {
            ObjectFive.SetActive(false);

            IntPanelSpecial -= 1;
            PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial);

            if (IntPanelSpecial <= 0)
            {
              IntPanel = 0;
              PlayerPrefs.SetInt("IntPanel", IntPanel);
            }

            IntFive = 0;
            PlayerPrefs.SetInt("IntFive", IntFive); 

            if (PanelFive.GetComponent<Image>().sprite == Star_Character) {
            ScriptCharacter.TimerBonusThemeStarLeft();
            }
            if (PanelFive.GetComponent<Image>().sprite == Cupcake_Character) {
            ScriptCharacter.TimerBonusThemeCupCakeLeft();
            }
            if (PanelFive.GetComponent<Image>().sprite == Heart_Character) {
            ScriptCharacter.TimerBonusThemeHeartLeft();
            }
            if (PanelFive.GetComponent<Image>().sprite == Ballon_Character) {
            ScriptCharacter.TimerBonusThemeCrabLeft();
            }
            if (PanelFive.GetComponent<Image>().sprite == Crab_Character) {
            ScriptCharacter.TimerBonusThemeBalloonLeft();
            }
            if (PanelFive.GetComponent<Image>().sprite == Ghost_Character) {
            ScriptCharacter.TimerBonusThemeGhostLeft();
            }
            if (PanelFive.GetComponent<Image>().sprite == Squid_Character) {
            ScriptCharacter.TimerBonusThemeSquidLeft();
            }
            if (PanelFive.GetComponent<Image>().sprite == Flame_Character) {
            ScriptCharacter.TimerBonusThemeFlameLeft();
            }
            if (PanelFive.GetComponent<Image>().sprite == Strawberry_Character) {
            ScriptCharacter.TimerBonusThemeStrawberryLeft();
            }
            if (PanelFive.GetComponent<Image>().sprite == Head_Character) {
            ScriptCharacter.TimerBonusThemeHeadLeft();
            }
            if (PanelFive.GetComponent<Image>().sprite == Slime_Character) {
            ScriptCharacter.TimerBonusThemeSlimeLeft();
            }
            if (PanelFive.GetComponent<Image>().sprite == Bunny_Character) {
            ScriptCharacter.TimerBonusThemeBunnyLeft();
            }
            if (PanelFive.GetComponent<Image>().sprite == Mushroom_Character) {
            ScriptCharacter.TimerBonusThemeMushroomLeft();
            }
            if (PanelFive.GetComponent<Image>().sprite == IceCream_Character) {
            ScriptCharacter.TimerBonusThemeIceCreamLeft();
            }
            if (PanelFive.GetComponent<Image>().sprite == Bear_Character) {
            ScriptCharacter.TimerBonusThemeBearLeft();
            }
            if (PanelFive.GetComponent<Image>().sprite == Flower_Character) {
            ScriptCharacter.TimerBonusThemeFlowerLeft();
            }
            if (PanelFive.GetComponent<Image>().sprite == JellyFish_Character) {
            ScriptCharacter.TimerBonusThemeJellyFishLeft();
            }
            if (PanelFive.GetComponent<Image>().sprite == Flowers_Theme) {
            ScriptTheme.TimerBonusThemeFlowerLeft();
            }
            if (PanelFive.GetComponent<Image>().sprite == Pyramids_Theme) {
            ScriptTheme.TimerBonusThemePyramidsLeft();
            }
            if (PanelFive.GetComponent<Image>().sprite == Desert_Theme) {
            ScriptTheme.TimerBonusThemeDesertLeft();
            }
            if (PanelFive.GetComponent<Image>().sprite == Snow_Theme) {
            ScriptTheme.TimerBonusThemeSnowLeft();
            }
            if (PanelFive.GetComponent<Image>().sprite == Island_Theme) {
            ScriptTheme.TimerBonusThemeIslandLeft();
            }
            if (PanelFive.GetComponent<Image>().sprite == Volcano_Theme) {
            ScriptTheme.TimerBonusThemeVolcanoLeft();
            }
            if (PanelFive.GetComponent<Image>().sprite == NightSky_Theme) {
            ScriptTheme.TimerBonusThemeNightSkyLeft();
            }
            if (PanelFive.GetComponent<Image>().sprite == Autumn_Theme) {
            ScriptTheme.TimerBonusThemeAutumnLeft();
            }
            if (PanelFive.GetComponent<Image>().sprite == Dinosaurus_Theme) {
            ScriptTheme.TimerBonusThemeDinosaurusLeft();
            }
            if (PanelFive.GetComponent<Image>().sprite == Aquarium_Theme) {
            ScriptTheme.TimerBonusThemeAquariumLeft();
            }
            if (PanelFive.GetComponent<Image>().sprite == Space_Theme) {
            ScriptTheme.TimerBonusThemeSpaceLeft();
            }
            if (PanelFive.GetComponent<Image>().sprite == Rain_Theme) {
            ScriptTheme.TimerBonusThemeRainLeft();
            }

            PanelFive.GetComponent<Image>().sprite = Clasic_Sprite;
        }
    }

    if (IntSix == 1){
    ulong Biff_Six = ((ulong)DateTime.Now.Ticks - LastTimeSix);
    ulong M_Six = Biff_Six / TimeSpan.TicksPerMillisecond;
    float SecondsLeftSix = (float)(WaitMsSix - M_Six) / 1000.0f;

    string StringSix = "";
    // HOURS
    StringSix += ((int)SecondsLeftSix / 3600).ToString() + ":";
    SecondsLeftSix -= ((int)SecondsLeftSix / 3600) * 3600;
    //MINUTES
    StringSix += ((int)SecondsLeftSix / 60).ToString("00") + ":";
    //SECONDS
    StringSix += (SecondsLeftSix % 60).ToString("00");
    TextSix.text = StringSix;

        if (SecondsLeftSix < 0)
        {
            ObjectSix.SetActive(false);

            IntPanelSpecial -= 1;
            PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial);

            if (IntPanelSpecial <= 0)
            {
              IntPanel = 0;
              PlayerPrefs.SetInt("IntPanel", IntPanel);
            }

            IntSix = 0;
            PlayerPrefs.SetInt("IntSix", IntSix); 

            if (PanelSix.GetComponent<Image>().sprite == Star_Character) {
            ScriptCharacter.TimerBonusThemeStarLeft();
            }
            if (PanelSix.GetComponent<Image>().sprite == Cupcake_Character) {
            ScriptCharacter.TimerBonusThemeCupCakeLeft();
            }
            if (PanelSix.GetComponent<Image>().sprite == Heart_Character) {
            ScriptCharacter.TimerBonusThemeHeartLeft();
            }
            if (PanelSix.GetComponent<Image>().sprite == Ballon_Character) {
            ScriptCharacter.TimerBonusThemeCrabLeft();
            }
            if (PanelSix.GetComponent<Image>().sprite == Crab_Character) {
            ScriptCharacter.TimerBonusThemeBalloonLeft();
            }
            if (PanelSix.GetComponent<Image>().sprite == Ghost_Character) {
            ScriptCharacter.TimerBonusThemeGhostLeft();
            }
            if (PanelSix.GetComponent<Image>().sprite == Squid_Character) {
            ScriptCharacter.TimerBonusThemeSquidLeft();
            }
            if (PanelSix.GetComponent<Image>().sprite == Flame_Character) {
            ScriptCharacter.TimerBonusThemeFlameLeft();
            }
            if (PanelSix.GetComponent<Image>().sprite == Strawberry_Character) {
            ScriptCharacter.TimerBonusThemeStrawberryLeft();
            }
            if (PanelSix.GetComponent<Image>().sprite == Head_Character) {
            ScriptCharacter.TimerBonusThemeHeadLeft();
            }
            if (PanelSix.GetComponent<Image>().sprite == Slime_Character) {
            ScriptCharacter.TimerBonusThemeSlimeLeft();
            }
            if (PanelSix.GetComponent<Image>().sprite == Bunny_Character) {
            ScriptCharacter.TimerBonusThemeBunnyLeft();
            }
            if (PanelSix.GetComponent<Image>().sprite == Mushroom_Character) {
            ScriptCharacter.TimerBonusThemeMushroomLeft();
            }
            if (PanelSix.GetComponent<Image>().sprite == IceCream_Character) {
            ScriptCharacter.TimerBonusThemeIceCreamLeft();
            }
            if (PanelSix.GetComponent<Image>().sprite == Bear_Character) {
            ScriptCharacter.TimerBonusThemeBearLeft();
            }
            if (PanelSix.GetComponent<Image>().sprite == Flower_Character) {
            ScriptCharacter.TimerBonusThemeFlowerLeft();
            }
            if (PanelSix.GetComponent<Image>().sprite == JellyFish_Character) {
            ScriptCharacter.TimerBonusThemeJellyFishLeft();
            }
            if (PanelSix.GetComponent<Image>().sprite == Flowers_Theme) {
            ScriptTheme.TimerBonusThemeFlowerLeft();
            }
            if (PanelSix.GetComponent<Image>().sprite == Pyramids_Theme) {
            ScriptTheme.TimerBonusThemePyramidsLeft();
            }
            if (PanelSix.GetComponent<Image>().sprite == Desert_Theme) {
            ScriptTheme.TimerBonusThemeDesertLeft();
            }
            if (PanelSix.GetComponent<Image>().sprite == Snow_Theme) {
            ScriptTheme.TimerBonusThemeSnowLeft();
            }
            if (PanelSix.GetComponent<Image>().sprite == Island_Theme) {
            ScriptTheme.TimerBonusThemeIslandLeft();
            }
            if (PanelSix.GetComponent<Image>().sprite == Volcano_Theme) {
            ScriptTheme.TimerBonusThemeVolcanoLeft();
            }
            if (PanelSix.GetComponent<Image>().sprite == NightSky_Theme) {
            ScriptTheme.TimerBonusThemeNightSkyLeft();
            }
            if (PanelSix.GetComponent<Image>().sprite == Autumn_Theme) {
            ScriptTheme.TimerBonusThemeAutumnLeft();
            }
            if (PanelSix.GetComponent<Image>().sprite == Dinosaurus_Theme) {
            ScriptTheme.TimerBonusThemeDinosaurusLeft();
            }
            if (PanelSix.GetComponent<Image>().sprite == Aquarium_Theme) {
            ScriptTheme.TimerBonusThemeAquariumLeft();
            }
            if (PanelSix.GetComponent<Image>().sprite == Space_Theme) {
            ScriptTheme.TimerBonusThemeSpaceLeft();
            }
            if (PanelSix.GetComponent<Image>().sprite == Rain_Theme) {
            ScriptTheme.TimerBonusThemeRainLeft();
            }

            PanelSix.GetComponent<Image>().sprite = Clasic_Sprite;
        }
    }

    if (IntSeven == 1){
    ulong Biff_Seven = ((ulong)DateTime.Now.Ticks - LastTimeSeven);
    ulong M_Seven = Biff_Seven / TimeSpan.TicksPerMillisecond;
    float SecondsLeftSeven = (float)(WaitMsSeven - M_Seven) / 1000.0f;

    string StringSeven = "";
    // HOURS
    StringSeven += ((int)SecondsLeftSeven / 3600).ToString() + ":";
    SecondsLeftSeven -= ((int)SecondsLeftSeven / 3600) * 3600;
    //MINUTES
    StringSeven += ((int)SecondsLeftSeven / 60).ToString("00") + ":";
    //SECONDS
    StringSeven += (SecondsLeftSeven % 60).ToString("00");
    TextSeven.text = StringSeven;

        if (SecondsLeftSeven < 0)
        {
            ObjectSeven.SetActive(false);

            IntPanelSpecial -= 1;
            PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial);

            if (IntPanelSpecial <= 0)
            {
              IntPanel = 0;
              PlayerPrefs.SetInt("IntPanel", IntPanel);
            }

            IntSeven = 0;
            PlayerPrefs.SetInt("IntSeven", IntSeven); 

            if (PanelSeven.GetComponent<Image>().sprite == Star_Character) {
            ScriptCharacter.TimerBonusThemeStarLeft();
            }
            if (PanelSeven.GetComponent<Image>().sprite == Cupcake_Character) {
            ScriptCharacter.TimerBonusThemeCupCakeLeft();
            }
            if (PanelSeven.GetComponent<Image>().sprite == Heart_Character) {
            ScriptCharacter.TimerBonusThemeHeartLeft();
            }
            if (PanelSeven.GetComponent<Image>().sprite == Ballon_Character) {
            ScriptCharacter.TimerBonusThemeCrabLeft();
            }
            if (PanelSeven.GetComponent<Image>().sprite == Crab_Character) {
            ScriptCharacter.TimerBonusThemeBalloonLeft();
            }
            if (PanelSeven.GetComponent<Image>().sprite == Ghost_Character) {
            ScriptCharacter.TimerBonusThemeGhostLeft();
            }
            if (PanelSeven.GetComponent<Image>().sprite == Squid_Character) {
            ScriptCharacter.TimerBonusThemeSquidLeft();
            }
            if (PanelSeven.GetComponent<Image>().sprite == Flame_Character) {
            ScriptCharacter.TimerBonusThemeFlameLeft();
            }
            if (PanelSeven.GetComponent<Image>().sprite == Strawberry_Character) {
            ScriptCharacter.TimerBonusThemeStrawberryLeft();
            }
            if (PanelSeven.GetComponent<Image>().sprite == Head_Character) {
            ScriptCharacter.TimerBonusThemeHeadLeft();
            }
            if (PanelSeven.GetComponent<Image>().sprite == Slime_Character) {
            ScriptCharacter.TimerBonusThemeSlimeLeft();
            }
            if (PanelSeven.GetComponent<Image>().sprite == Bunny_Character) {
            ScriptCharacter.TimerBonusThemeBunnyLeft();
            }
            if (PanelSeven.GetComponent<Image>().sprite == Mushroom_Character) {
            ScriptCharacter.TimerBonusThemeMushroomLeft();
            }
            if (PanelSeven.GetComponent<Image>().sprite == IceCream_Character) {
            ScriptCharacter.TimerBonusThemeIceCreamLeft();
            }
            if (PanelSeven.GetComponent<Image>().sprite == Bear_Character) {
            ScriptCharacter.TimerBonusThemeBearLeft();
            }
            if (PanelSeven.GetComponent<Image>().sprite == Flower_Character) {
            ScriptCharacter.TimerBonusThemeFlowerLeft();
            }
            if (PanelSeven.GetComponent<Image>().sprite == JellyFish_Character) {
            ScriptCharacter.TimerBonusThemeJellyFishLeft();
            }
            if (PanelSeven.GetComponent<Image>().sprite == Flowers_Theme) {
            ScriptTheme.TimerBonusThemeFlowerLeft();
            }
            if (PanelSeven.GetComponent<Image>().sprite == Pyramids_Theme) {
            ScriptTheme.TimerBonusThemePyramidsLeft();
            }
            if (PanelSeven.GetComponent<Image>().sprite == Desert_Theme) {
            ScriptTheme.TimerBonusThemeDesertLeft();
            }
            if (PanelSeven.GetComponent<Image>().sprite == Snow_Theme) {
            ScriptTheme.TimerBonusThemeSnowLeft();
            }
            if (PanelSeven.GetComponent<Image>().sprite == Island_Theme) {
            ScriptTheme.TimerBonusThemeIslandLeft();
            }
            if (PanelSeven.GetComponent<Image>().sprite == Volcano_Theme) {
            ScriptTheme.TimerBonusThemeVolcanoLeft();
            }
            if (PanelSeven.GetComponent<Image>().sprite == NightSky_Theme) {
            ScriptTheme.TimerBonusThemeNightSkyLeft();
            }
            if (PanelSeven.GetComponent<Image>().sprite == Autumn_Theme) {
            ScriptTheme.TimerBonusThemeAutumnLeft();
            }
            if (PanelSeven.GetComponent<Image>().sprite == Dinosaurus_Theme) {
            ScriptTheme.TimerBonusThemeDinosaurusLeft();
            }
            if (PanelSeven.GetComponent<Image>().sprite == Aquarium_Theme) {
            ScriptTheme.TimerBonusThemeAquariumLeft();
            }
            if (PanelSeven.GetComponent<Image>().sprite == Space_Theme) {
            ScriptTheme.TimerBonusThemeSpaceLeft();
            }
            if (PanelSeven.GetComponent<Image>().sprite == Rain_Theme) {
            ScriptTheme.TimerBonusThemeRainLeft();
            }

            PanelSeven.GetComponent<Image>().sprite = Clasic_Sprite;
        }
    }

    if (IntEight == 1){
    ulong Biff_Eight = ((ulong)DateTime.Now.Ticks - LastTimeEight);
    ulong M_Eight = Biff_Eight / TimeSpan.TicksPerMillisecond;
    float SecondsLeftEight = (float)(WaitMsEight - M_Eight) / 1000.0f;

    string StringEight = "";
    // HOURS
    StringEight += ((int)SecondsLeftEight / 3600).ToString() + ":";
    SecondsLeftEight -= ((int)SecondsLeftEight / 3600) * 3600;
    //MINUTES
    StringEight += ((int)SecondsLeftEight / 60).ToString("00") + ":";
    //SECONDS
    StringEight += (SecondsLeftEight % 60).ToString("00");
    TextEight.text = StringEight;

        if (SecondsLeftEight < 0)
        {
            ObjectEight.SetActive(false);

            IntPanelSpecial -= 1;
            PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial);

            if (IntPanelSpecial <= 0)
            {
              IntPanel = 0;
              PlayerPrefs.SetInt("IntPanel", IntPanel);
            }

            IntEight = 0;
            PlayerPrefs.SetInt("IntEight", IntEight); 

            if (PanelEight.GetComponent<Image>().sprite == Star_Character) {
            ScriptCharacter.TimerBonusThemeStarLeft();
            }
            if (PanelEight.GetComponent<Image>().sprite == Cupcake_Character) {
            ScriptCharacter.TimerBonusThemeCupCakeLeft();
            }
            if (PanelEight.GetComponent<Image>().sprite == Heart_Character) {
            ScriptCharacter.TimerBonusThemeHeartLeft();
            }
            if (PanelEight.GetComponent<Image>().sprite == Ballon_Character) {
            ScriptCharacter.TimerBonusThemeCrabLeft();
            }
            if (PanelEight.GetComponent<Image>().sprite == Crab_Character) {
            ScriptCharacter.TimerBonusThemeBalloonLeft();
            }
            if (PanelEight.GetComponent<Image>().sprite == Ghost_Character) {
            ScriptCharacter.TimerBonusThemeGhostLeft();
            }
            if (PanelEight.GetComponent<Image>().sprite == Squid_Character) {
            ScriptCharacter.TimerBonusThemeSquidLeft();
            }
            if (PanelEight.GetComponent<Image>().sprite == Flame_Character) {
            ScriptCharacter.TimerBonusThemeFlameLeft();
            }
            if (PanelEight.GetComponent<Image>().sprite == Strawberry_Character) {
            ScriptCharacter.TimerBonusThemeStrawberryLeft();
            }
            if (PanelEight.GetComponent<Image>().sprite == Head_Character) {
            ScriptCharacter.TimerBonusThemeHeadLeft();
            }
            if (PanelEight.GetComponent<Image>().sprite == Slime_Character) {
            ScriptCharacter.TimerBonusThemeSlimeLeft();
            }
            if (PanelEight.GetComponent<Image>().sprite == Bunny_Character) {
            ScriptCharacter.TimerBonusThemeBunnyLeft();
            }
            if (PanelEight.GetComponent<Image>().sprite == Mushroom_Character) {
            ScriptCharacter.TimerBonusThemeMushroomLeft();
            }
            if (PanelEight.GetComponent<Image>().sprite == IceCream_Character) {
            ScriptCharacter.TimerBonusThemeIceCreamLeft();
            }
            if (PanelEight.GetComponent<Image>().sprite == Bear_Character) {
            ScriptCharacter.TimerBonusThemeBearLeft();
            }
            if (PanelEight.GetComponent<Image>().sprite == Flower_Character) {
            ScriptCharacter.TimerBonusThemeFlowerLeft();
            }
            if (PanelEight.GetComponent<Image>().sprite == JellyFish_Character) {
            ScriptCharacter.TimerBonusThemeJellyFishLeft();
            }
            if (PanelEight.GetComponent<Image>().sprite == Flowers_Theme) {
            ScriptTheme.TimerBonusThemeFlowerLeft();
            }
            if (PanelEight.GetComponent<Image>().sprite == Pyramids_Theme) {
            ScriptTheme.TimerBonusThemePyramidsLeft();
            }
            if (PanelEight.GetComponent<Image>().sprite == Desert_Theme) {
            ScriptTheme.TimerBonusThemeDesertLeft();
            }
            if (PanelEight.GetComponent<Image>().sprite == Snow_Theme) {
            ScriptTheme.TimerBonusThemeSnowLeft();
            }
            if (PanelEight.GetComponent<Image>().sprite == Island_Theme) {
            ScriptTheme.TimerBonusThemeIslandLeft();
            }
            if (PanelEight.GetComponent<Image>().sprite == Volcano_Theme) {
            ScriptTheme.TimerBonusThemeVolcanoLeft();
            }
            if (PanelEight.GetComponent<Image>().sprite == NightSky_Theme) {
            ScriptTheme.TimerBonusThemeNightSkyLeft();
            }
            if (PanelEight.GetComponent<Image>().sprite == Autumn_Theme) {
            ScriptTheme.TimerBonusThemeAutumnLeft();
            }
            if (PanelEight.GetComponent<Image>().sprite == Dinosaurus_Theme) {
            ScriptTheme.TimerBonusThemeDinosaurusLeft();
            }
            if (PanelEight.GetComponent<Image>().sprite == Aquarium_Theme) {
            ScriptTheme.TimerBonusThemeAquariumLeft();
            }
            if (PanelEight.GetComponent<Image>().sprite == Space_Theme) {
            ScriptTheme.TimerBonusThemeSpaceLeft();
            }
            if (PanelEight.GetComponent<Image>().sprite == Rain_Theme) {
            ScriptTheme.TimerBonusThemeRainLeft();
            }

            PanelEight.GetComponent<Image>().sprite = Clasic_Sprite;
        }
    }

    if (IntNine == 1){
    ulong Biff_Nine = ((ulong)DateTime.Now.Ticks - LastTimeNine);
    ulong M_Nine = Biff_Nine / TimeSpan.TicksPerMillisecond;
    float SecondsLeftNine = (float)(WaitMsNine - M_Nine) / 1000.0f;

    string StringNine = "";
    // HOURS
    StringNine += ((int)SecondsLeftNine / 3600).ToString() + ":";
    SecondsLeftNine -= ((int)SecondsLeftNine / 3600) * 3600;
    //MINUTES
    StringNine += ((int)SecondsLeftNine / 60).ToString("00") + ":";
    //SECONDS
    StringNine += (SecondsLeftNine % 60).ToString("00");
    TextNine.text = StringNine;

        if (SecondsLeftNine < 0)
        {
            ObjectNine.SetActive(false);

            IntPanelSpecial -= 1;
            PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial);

            if (IntPanelSpecial <= 0)
            {
              IntPanel = 0;
              PlayerPrefs.SetInt("IntPanel", IntPanel);
            }

            IntNine = 0;
            PlayerPrefs.SetInt("IntNine", IntNine); 

            if (PanelNine.GetComponent<Image>().sprite == Star_Character) {
            ScriptCharacter.TimerBonusThemeStarLeft();
            }
            if (PanelNine.GetComponent<Image>().sprite == Cupcake_Character) {
            ScriptCharacter.TimerBonusThemeCupCakeLeft();
            }
            if (PanelNine.GetComponent<Image>().sprite == Heart_Character) {
            ScriptCharacter.TimerBonusThemeHeartLeft();
            }
            if (PanelNine.GetComponent<Image>().sprite == Ballon_Character) {
            ScriptCharacter.TimerBonusThemeCrabLeft();
            }
            if (PanelNine.GetComponent<Image>().sprite == Crab_Character) {
            ScriptCharacter.TimerBonusThemeBalloonLeft();
            }
            if (PanelNine.GetComponent<Image>().sprite == Ghost_Character) {
            ScriptCharacter.TimerBonusThemeGhostLeft();
            }
            if (PanelNine.GetComponent<Image>().sprite == Squid_Character) {
            ScriptCharacter.TimerBonusThemeSquidLeft();
            }
            if (PanelNine.GetComponent<Image>().sprite == Flame_Character) {
            ScriptCharacter.TimerBonusThemeFlameLeft();
            }
            if (PanelNine.GetComponent<Image>().sprite == Strawberry_Character) {
            ScriptCharacter.TimerBonusThemeStrawberryLeft();
            }
            if (PanelNine.GetComponent<Image>().sprite == Head_Character) {
            ScriptCharacter.TimerBonusThemeHeadLeft();
            }
            if (PanelNine.GetComponent<Image>().sprite == Slime_Character) {
            ScriptCharacter.TimerBonusThemeSlimeLeft();
            }
            if (PanelNine.GetComponent<Image>().sprite == Bunny_Character) {
            ScriptCharacter.TimerBonusThemeBunnyLeft();
            }
            if (PanelNine.GetComponent<Image>().sprite == Mushroom_Character) {
            ScriptCharacter.TimerBonusThemeMushroomLeft();
            }
            if (PanelNine.GetComponent<Image>().sprite == IceCream_Character) {
            ScriptCharacter.TimerBonusThemeIceCreamLeft();
            }
            if (PanelNine.GetComponent<Image>().sprite == Bear_Character) {
            ScriptCharacter.TimerBonusThemeBearLeft();
            }
            if (PanelNine.GetComponent<Image>().sprite == Flower_Character) {
            ScriptCharacter.TimerBonusThemeFlowerLeft();
            }
            if (PanelNine.GetComponent<Image>().sprite == JellyFish_Character) {
            ScriptCharacter.TimerBonusThemeJellyFishLeft();
            }
            if (PanelNine.GetComponent<Image>().sprite == Flowers_Theme) {
            ScriptTheme.TimerBonusThemeFlowerLeft();
            }
            if (PanelNine.GetComponent<Image>().sprite == Pyramids_Theme) {
            ScriptTheme.TimerBonusThemePyramidsLeft();
            }
            if (PanelNine.GetComponent<Image>().sprite == Desert_Theme) {
            ScriptTheme.TimerBonusThemeDesertLeft();
            }
            if (PanelNine.GetComponent<Image>().sprite == Snow_Theme) {
            ScriptTheme.TimerBonusThemeSnowLeft();
            }
            if (PanelNine.GetComponent<Image>().sprite == Island_Theme) {
            ScriptTheme.TimerBonusThemeIslandLeft();
            }
            if (PanelNine.GetComponent<Image>().sprite == Volcano_Theme) {
            ScriptTheme.TimerBonusThemeVolcanoLeft();
            }
            if (PanelNine.GetComponent<Image>().sprite == NightSky_Theme) {
            ScriptTheme.TimerBonusThemeNightSkyLeft();
            }
            if (PanelNine.GetComponent<Image>().sprite == Autumn_Theme) {
            ScriptTheme.TimerBonusThemeAutumnLeft();
            }
            if (PanelNine.GetComponent<Image>().sprite == Dinosaurus_Theme) {
            ScriptTheme.TimerBonusThemeDinosaurusLeft();
            }
            if (PanelNine.GetComponent<Image>().sprite == Aquarium_Theme) {
            ScriptTheme.TimerBonusThemeAquariumLeft();
            }
            if (PanelNine.GetComponent<Image>().sprite == Space_Theme) {
            ScriptTheme.TimerBonusThemeSpaceLeft();
            }
            if (PanelNine.GetComponent<Image>().sprite == Rain_Theme) {
            ScriptTheme.TimerBonusThemeRainLeft();
            }

            PanelNine.GetComponent<Image>().sprite = Clasic_Sprite;
        }
    }

    if (IntTen == 1){
    ulong Biff_Ten = ((ulong)DateTime.Now.Ticks - LastTimeTen);
    ulong M_Ten = Biff_Ten / TimeSpan.TicksPerMillisecond;
    float SecondsLeftTen = (float)(WaitMsTen - M_Ten) / 1000.0f;

    string StringTen = "";
    // HOURS
    StringTen += ((int)SecondsLeftTen / 3600).ToString() + ":";
    SecondsLeftTen -= ((int)SecondsLeftTen / 3600) * 3600;
    //MINUTES
    StringTen += ((int)SecondsLeftTen / 60).ToString("00") + ":";
    //SECONDS
    StringTen += (SecondsLeftTen % 60).ToString("00");
    TextTen.text = StringTen;

        if (SecondsLeftTen < 0)
        {
            ObjectTen.SetActive(false);

            IntPanelSpecial -= 1;
            PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial);

            if (IntPanelSpecial <= 0)
            {
              IntPanel = 0;
              PlayerPrefs.SetInt("IntPanel", IntPanel);
            }

            IntTen = 0;
            PlayerPrefs.SetInt("IntTen", IntTen); 

            if (PanelTen.GetComponent<Image>().sprite == Star_Character) {
            ScriptCharacter.TimerBonusThemeStarLeft();
            }
            if (PanelTen.GetComponent<Image>().sprite == Cupcake_Character) {
            ScriptCharacter.TimerBonusThemeCupCakeLeft();
            }
            if (PanelTen.GetComponent<Image>().sprite == Heart_Character) {
            ScriptCharacter.TimerBonusThemeHeartLeft();
            }
            if (PanelTen.GetComponent<Image>().sprite == Ballon_Character) {
            ScriptCharacter.TimerBonusThemeCrabLeft();
            }
            if (PanelTen.GetComponent<Image>().sprite == Crab_Character) {
            ScriptCharacter.TimerBonusThemeBalloonLeft();
            }
            if (PanelTen.GetComponent<Image>().sprite == Ghost_Character) {
            ScriptCharacter.TimerBonusThemeGhostLeft();
            }
            if (PanelTen.GetComponent<Image>().sprite == Squid_Character) {
            ScriptCharacter.TimerBonusThemeSquidLeft();
            }
            if (PanelTen.GetComponent<Image>().sprite == Flame_Character) {
            ScriptCharacter.TimerBonusThemeFlameLeft();
            }
            if (PanelTen.GetComponent<Image>().sprite == Strawberry_Character) {
            ScriptCharacter.TimerBonusThemeStrawberryLeft();
            }
            if (PanelTen.GetComponent<Image>().sprite == Head_Character) {
            ScriptCharacter.TimerBonusThemeHeadLeft();
            }
            if (PanelTen.GetComponent<Image>().sprite == Slime_Character) {
            ScriptCharacter.TimerBonusThemeSlimeLeft();
            }
            if (PanelTen.GetComponent<Image>().sprite == Bunny_Character) {
            ScriptCharacter.TimerBonusThemeBunnyLeft();
            }
            if (PanelTen.GetComponent<Image>().sprite == Mushroom_Character) {
            ScriptCharacter.TimerBonusThemeMushroomLeft();
            }
            if (PanelTen.GetComponent<Image>().sprite == IceCream_Character) {
            ScriptCharacter.TimerBonusThemeIceCreamLeft();
            }
            if (PanelTen.GetComponent<Image>().sprite == Bear_Character) {
            ScriptCharacter.TimerBonusThemeBearLeft();
            }
            if (PanelTen.GetComponent<Image>().sprite == Flower_Character) {
            ScriptCharacter.TimerBonusThemeFlowerLeft();
            }
            if (PanelTen.GetComponent<Image>().sprite == JellyFish_Character) {
            ScriptCharacter.TimerBonusThemeJellyFishLeft();
            }
            if (PanelTen.GetComponent<Image>().sprite == Flowers_Theme) {
            ScriptTheme.TimerBonusThemeFlowerLeft();
            }
            if (PanelTen.GetComponent<Image>().sprite == Pyramids_Theme) {
            ScriptTheme.TimerBonusThemePyramidsLeft();
            }
            if (PanelTen.GetComponent<Image>().sprite == Desert_Theme) {
            ScriptTheme.TimerBonusThemeDesertLeft();
            }
            if (PanelTen.GetComponent<Image>().sprite == Snow_Theme) {
            ScriptTheme.TimerBonusThemeSnowLeft();
            }
            if (PanelTen.GetComponent<Image>().sprite == Island_Theme) {
            ScriptTheme.TimerBonusThemeIslandLeft();
            }
            if (PanelTen.GetComponent<Image>().sprite == Volcano_Theme) {
            ScriptTheme.TimerBonusThemeVolcanoLeft();
            }
            if (PanelTen.GetComponent<Image>().sprite == NightSky_Theme) {
            ScriptTheme.TimerBonusThemeNightSkyLeft();
            }
            if (PanelTen.GetComponent<Image>().sprite == Autumn_Theme) {
            ScriptTheme.TimerBonusThemeAutumnLeft();
            }
            if (PanelTen.GetComponent<Image>().sprite == Dinosaurus_Theme) {
            ScriptTheme.TimerBonusThemeDinosaurusLeft();
            }
            if (PanelTen.GetComponent<Image>().sprite == Aquarium_Theme) {
            ScriptTheme.TimerBonusThemeAquariumLeft();
            }
            if (PanelTen.GetComponent<Image>().sprite == Space_Theme) {
            ScriptTheme.TimerBonusThemeSpaceLeft();
            }
            if (PanelTen.GetComponent<Image>().sprite == Rain_Theme) {
            ScriptTheme.TimerBonusThemeRainLeft();
            }

            PanelTen.GetComponent<Image>().sprite = Clasic_Sprite;
        }
    }

    if (IntEleven == 1){
    ulong Biff_Eleven = ((ulong)DateTime.Now.Ticks - LastTimeEleven);
    ulong M_Eleven = Biff_Eleven / TimeSpan.TicksPerMillisecond;
    float SecondsLeftEleven = (float)(WaitMsEleven - M_Eleven) / 1000.0f;

    string StringEleven = "";
    // HOURS
    StringEleven += ((int)SecondsLeftEleven / 3600).ToString() + ":";
    SecondsLeftEleven -= ((int)SecondsLeftEleven / 3600) * 3600;
    //MINUTES
    StringEleven += ((int)SecondsLeftEleven / 60).ToString("00") + ":";
    //SECONDS
    StringEleven += (SecondsLeftEleven % 60).ToString("00");
    TextEleven.text = StringEleven;

        if (SecondsLeftEleven < 0)
        {
            ObjectEleven.SetActive(false);

            IntPanelSpecial -= 1;
            PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial);

            if (IntPanelSpecial <= 0)
            {
              IntPanel = 0;
              PlayerPrefs.SetInt("IntPanel", IntPanel);
            }

            IntEleven = 0;
            PlayerPrefs.SetInt("IntEleven", IntEleven); 

            if (PanelEleven.GetComponent<Image>().sprite == Star_Character) {
            ScriptCharacter.TimerBonusThemeStarLeft();
            }
            if (PanelEleven.GetComponent<Image>().sprite == Cupcake_Character) {
            ScriptCharacter.TimerBonusThemeCupCakeLeft();
            }
            if (PanelEleven.GetComponent<Image>().sprite == Heart_Character) {
            ScriptCharacter.TimerBonusThemeHeartLeft();
            }
            if (PanelEleven.GetComponent<Image>().sprite == Ballon_Character) {
            ScriptCharacter.TimerBonusThemeCrabLeft();
            }
            if (PanelEleven.GetComponent<Image>().sprite == Crab_Character) {
            ScriptCharacter.TimerBonusThemeBalloonLeft();
            }
            if (PanelEleven.GetComponent<Image>().sprite == Ghost_Character) {
            ScriptCharacter.TimerBonusThemeGhostLeft();
            }
            if (PanelEleven.GetComponent<Image>().sprite == Squid_Character) {
            ScriptCharacter.TimerBonusThemeSquidLeft();
            }
            if (PanelEleven.GetComponent<Image>().sprite == Flame_Character) {
            ScriptCharacter.TimerBonusThemeFlameLeft();
            }
            if (PanelEleven.GetComponent<Image>().sprite == Strawberry_Character) {
            ScriptCharacter.TimerBonusThemeStrawberryLeft();
            }
            if (PanelEleven.GetComponent<Image>().sprite == Head_Character) {
            ScriptCharacter.TimerBonusThemeHeadLeft();
            }
            if (PanelEleven.GetComponent<Image>().sprite == Slime_Character) {
            ScriptCharacter.TimerBonusThemeSlimeLeft();
            }
            if (PanelEleven.GetComponent<Image>().sprite == Bunny_Character) {
            ScriptCharacter.TimerBonusThemeBunnyLeft();
            }
            if (PanelEleven.GetComponent<Image>().sprite == Mushroom_Character) {
            ScriptCharacter.TimerBonusThemeMushroomLeft();
            }
            if (PanelEleven.GetComponent<Image>().sprite == IceCream_Character) {
            ScriptCharacter.TimerBonusThemeIceCreamLeft();
            }
            if (PanelEleven.GetComponent<Image>().sprite == Bear_Character) {
            ScriptCharacter.TimerBonusThemeBearLeft();
            }
            if (PanelEleven.GetComponent<Image>().sprite == Flower_Character) {
            ScriptCharacter.TimerBonusThemeFlowerLeft();
            }
            if (PanelEleven.GetComponent<Image>().sprite == JellyFish_Character) {
            ScriptCharacter.TimerBonusThemeJellyFishLeft();
            }
            if (PanelEleven.GetComponent<Image>().sprite == Flowers_Theme) {
            ScriptTheme.TimerBonusThemeFlowerLeft();
            }
            if (PanelEleven.GetComponent<Image>().sprite == Pyramids_Theme) {
            ScriptTheme.TimerBonusThemePyramidsLeft();
            }
            if (PanelEleven.GetComponent<Image>().sprite == Desert_Theme) {
            ScriptTheme.TimerBonusThemeDesertLeft();
            }
            if (PanelEleven.GetComponent<Image>().sprite == Snow_Theme) {
            ScriptTheme.TimerBonusThemeSnowLeft();
            }
            if (PanelEleven.GetComponent<Image>().sprite == Island_Theme) {
            ScriptTheme.TimerBonusThemeIslandLeft();
            }
            if (PanelEleven.GetComponent<Image>().sprite == Volcano_Theme) {
            ScriptTheme.TimerBonusThemeVolcanoLeft();
            }
            if (PanelEleven.GetComponent<Image>().sprite == NightSky_Theme) {
            ScriptTheme.TimerBonusThemeNightSkyLeft();
            }
            if (PanelEleven.GetComponent<Image>().sprite == Autumn_Theme) {
            ScriptTheme.TimerBonusThemeAutumnLeft();
            }
            if (PanelEleven.GetComponent<Image>().sprite == Dinosaurus_Theme) {
            ScriptTheme.TimerBonusThemeDinosaurusLeft();
            }
            if (PanelEleven.GetComponent<Image>().sprite == Aquarium_Theme) {
            ScriptTheme.TimerBonusThemeAquariumLeft();
            }
            if (PanelEleven.GetComponent<Image>().sprite == Space_Theme) {
            ScriptTheme.TimerBonusThemeSpaceLeft();
            }
            if (PanelEleven.GetComponent<Image>().sprite == Rain_Theme) {
            ScriptTheme.TimerBonusThemeRainLeft();
            }

            PanelEleven.GetComponent<Image>().sprite = Clasic_Sprite;
        }
    }

    if (IntTwelve == 1){
    ulong Biff_Twelve = ((ulong)DateTime.Now.Ticks - LastTimeTwelve);
    ulong M_Twelve = Biff_Twelve / TimeSpan.TicksPerMillisecond;
    float SecondsLeftTwelve = (float)(WaitMsTwelve - M_Twelve) / 1000.0f;

    string StringTwelve = "";
    // HOURS
    StringTwelve += ((int)SecondsLeftTwelve / 3600).ToString() + ":";
    SecondsLeftTwelve -= ((int)SecondsLeftTwelve / 3600) * 3600;
    //MINUTES
    StringTwelve += ((int)SecondsLeftTwelve / 60).ToString("00") + ":";
    //SECONDS
    StringTwelve += (SecondsLeftTwelve % 60).ToString("00");
    TextTwelve.text = StringTwelve;

        if (SecondsLeftTwelve < 0)
        {
            ObjectTwelve.SetActive(false);

            IntPanelSpecial -= 1;
            PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial);

            if (IntPanelSpecial <= 0)
            {
              IntPanel = 0;
              PlayerPrefs.SetInt("IntPanel", IntPanel);
            }

            IntTwelve = 0;
            PlayerPrefs.SetInt("IntTwelve", IntTwelve); 

            if (PanelTwelve.GetComponent<Image>().sprite == Star_Character) {
            ScriptCharacter.TimerBonusThemeStarLeft();
            }
            if (PanelTwelve.GetComponent<Image>().sprite == Cupcake_Character) {
            ScriptCharacter.TimerBonusThemeCupCakeLeft();
            }
            if (PanelTwelve.GetComponent<Image>().sprite == Heart_Character) {
            ScriptCharacter.TimerBonusThemeHeartLeft();
            }
            if (PanelTwelve.GetComponent<Image>().sprite == Ballon_Character) {
            ScriptCharacter.TimerBonusThemeCrabLeft();
            }
            if (PanelTwelve.GetComponent<Image>().sprite == Crab_Character) {
            ScriptCharacter.TimerBonusThemeBalloonLeft();
            }
            if (PanelTwelve.GetComponent<Image>().sprite == Ghost_Character) {
            ScriptCharacter.TimerBonusThemeGhostLeft();
            }
            if (PanelTwelve.GetComponent<Image>().sprite == Squid_Character) {
            ScriptCharacter.TimerBonusThemeSquidLeft();
            }
            if (PanelTwelve.GetComponent<Image>().sprite == Flame_Character) {
            ScriptCharacter.TimerBonusThemeFlameLeft();
            }
            if (PanelTwelve.GetComponent<Image>().sprite == Strawberry_Character) {
            ScriptCharacter.TimerBonusThemeStrawberryLeft();
            }
            if (PanelTwelve.GetComponent<Image>().sprite == Head_Character) {
            ScriptCharacter.TimerBonusThemeHeadLeft();
            }
            if (PanelTwelve.GetComponent<Image>().sprite == Slime_Character) {
            ScriptCharacter.TimerBonusThemeSlimeLeft();
            }
            if (PanelTwelve.GetComponent<Image>().sprite == Bunny_Character) {
            ScriptCharacter.TimerBonusThemeBunnyLeft();
            }
            if (PanelTwelve.GetComponent<Image>().sprite == Mushroom_Character) {
            ScriptCharacter.TimerBonusThemeMushroomLeft();
            }
            if (PanelTwelve.GetComponent<Image>().sprite == IceCream_Character) {
            ScriptCharacter.TimerBonusThemeIceCreamLeft();
            }
            if (PanelTwelve.GetComponent<Image>().sprite == Bear_Character) {
            ScriptCharacter.TimerBonusThemeBearLeft();
            }
            if (PanelTwelve.GetComponent<Image>().sprite == Flower_Character) {
            ScriptCharacter.TimerBonusThemeFlowerLeft();
            }
            if (PanelTwelve.GetComponent<Image>().sprite == JellyFish_Character) {
            ScriptCharacter.TimerBonusThemeJellyFishLeft();
            }
            if (PanelTwelve.GetComponent<Image>().sprite == Flowers_Theme) {
            ScriptTheme.TimerBonusThemeFlowerLeft();
            }
            if (PanelTwelve.GetComponent<Image>().sprite == Pyramids_Theme) {
            ScriptTheme.TimerBonusThemePyramidsLeft();
            }
            if (PanelTwelve.GetComponent<Image>().sprite == Desert_Theme) {
            ScriptTheme.TimerBonusThemeDesertLeft();
            }
            if (PanelTwelve.GetComponent<Image>().sprite == Snow_Theme) {
            ScriptTheme.TimerBonusThemeSnowLeft();
            }
            if (PanelTwelve.GetComponent<Image>().sprite == Island_Theme) {
            ScriptTheme.TimerBonusThemeIslandLeft();
            }
            if (PanelTwelve.GetComponent<Image>().sprite == Volcano_Theme) {
            ScriptTheme.TimerBonusThemeVolcanoLeft();
            }
            if (PanelTwelve.GetComponent<Image>().sprite == NightSky_Theme) {
            ScriptTheme.TimerBonusThemeNightSkyLeft();
            }
            if (PanelTwelve.GetComponent<Image>().sprite == Autumn_Theme) {
            ScriptTheme.TimerBonusThemeAutumnLeft();
            }
            if (PanelTwelve.GetComponent<Image>().sprite == Dinosaurus_Theme) {
            ScriptTheme.TimerBonusThemeDinosaurusLeft();
            }
            if (PanelTwelve.GetComponent<Image>().sprite == Aquarium_Theme) {
            ScriptTheme.TimerBonusThemeAquariumLeft();
            }
            if (PanelTwelve.GetComponent<Image>().sprite == Space_Theme) {
            ScriptTheme.TimerBonusThemeSpaceLeft();
            }
            if (PanelTwelve.GetComponent<Image>().sprite == Rain_Theme) {
            ScriptTheme.TimerBonusThemeRainLeft();
            }

            PanelTwelve.GetComponent<Image>().sprite = Clasic_Sprite;
        }
    }

    if (IntThreeteen == 1){
    ulong Biff_Threeteen = ((ulong)DateTime.Now.Ticks - LastTimeThreeteen);
    ulong M_Threeteen = Biff_Threeteen / TimeSpan.TicksPerMillisecond;
    float SecondsLeftThreeteen = (float)(WaitMsThreeteen - M_Threeteen) / 1000.0f;

    string StringThreeteen = "";
    // HOURS
    StringThreeteen += ((int)SecondsLeftThreeteen / 3600).ToString() + ":";
    SecondsLeftThreeteen -= ((int)SecondsLeftThreeteen / 3600) * 3600;
    //MINUTES
    StringThreeteen += ((int)SecondsLeftThreeteen / 60).ToString("00") + ":";
    //SECONDS
    StringThreeteen += (SecondsLeftThreeteen % 60).ToString("00");
    TextThreeteen.text = StringThreeteen;

        if (SecondsLeftThreeteen < 0)
        {
            ObjectThreeteen.SetActive(false);

            IntPanelSpecial -= 1;
            PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial);

            if (IntPanelSpecial <= 0)
            {
              IntPanel = 0;
              PlayerPrefs.SetInt("IntPanel", IntPanel);
            }

            IntThreeteen = 0;
            PlayerPrefs.SetInt("IntThreeteen", IntThreeteen); 

            if (PanelThreeteen.GetComponent<Image>().sprite == Star_Character) {
            ScriptCharacter.TimerBonusThemeStarLeft();
            }
            if (PanelThreeteen.GetComponent<Image>().sprite == Cupcake_Character) {
            ScriptCharacter.TimerBonusThemeCupCakeLeft();
            }
            if (PanelThreeteen.GetComponent<Image>().sprite == Heart_Character) {
            ScriptCharacter.TimerBonusThemeHeartLeft();
            }
            if (PanelThreeteen.GetComponent<Image>().sprite == Ballon_Character) {
            ScriptCharacter.TimerBonusThemeCrabLeft();
            }
            if (PanelThreeteen.GetComponent<Image>().sprite == Crab_Character) {
            ScriptCharacter.TimerBonusThemeBalloonLeft();
            }
            if (PanelThreeteen.GetComponent<Image>().sprite == Ghost_Character) {
            ScriptCharacter.TimerBonusThemeGhostLeft();
            }
            if (PanelThreeteen.GetComponent<Image>().sprite == Squid_Character) {
            ScriptCharacter.TimerBonusThemeSquidLeft();
            }
            if (PanelThreeteen.GetComponent<Image>().sprite == Flame_Character) {
            ScriptCharacter.TimerBonusThemeFlameLeft();
            }
            if (PanelThreeteen.GetComponent<Image>().sprite == Strawberry_Character) {
            ScriptCharacter.TimerBonusThemeStrawberryLeft();
            }
            if (PanelThreeteen.GetComponent<Image>().sprite == Head_Character) {
            ScriptCharacter.TimerBonusThemeHeadLeft();
            }
            if (PanelThreeteen.GetComponent<Image>().sprite == Slime_Character) {
            ScriptCharacter.TimerBonusThemeSlimeLeft();
            }
            if (PanelThreeteen.GetComponent<Image>().sprite == Bunny_Character) {
            ScriptCharacter.TimerBonusThemeBunnyLeft();
            }
            if (PanelThreeteen.GetComponent<Image>().sprite == Mushroom_Character) {
            ScriptCharacter.TimerBonusThemeMushroomLeft();
            }
            if (PanelThreeteen.GetComponent<Image>().sprite == IceCream_Character) {
            ScriptCharacter.TimerBonusThemeIceCreamLeft();
            }
            if (PanelThreeteen.GetComponent<Image>().sprite == Bear_Character) {
            ScriptCharacter.TimerBonusThemeBearLeft();
            }
            if (PanelThreeteen.GetComponent<Image>().sprite == Flower_Character) {
            ScriptCharacter.TimerBonusThemeFlowerLeft();
            }
            if (PanelThreeteen.GetComponent<Image>().sprite == JellyFish_Character) {
            ScriptCharacter.TimerBonusThemeJellyFishLeft();
            }
            if (PanelThreeteen.GetComponent<Image>().sprite == Flowers_Theme) {
            ScriptTheme.TimerBonusThemeFlowerLeft();
            }
            if (PanelThreeteen.GetComponent<Image>().sprite == Pyramids_Theme) {
            ScriptTheme.TimerBonusThemePyramidsLeft();
            }
            if (PanelThreeteen.GetComponent<Image>().sprite == Desert_Theme) {
            ScriptTheme.TimerBonusThemeDesertLeft();
            }
            if (PanelThreeteen.GetComponent<Image>().sprite == Snow_Theme) {
            ScriptTheme.TimerBonusThemeSnowLeft();
            }
            if (PanelThreeteen.GetComponent<Image>().sprite == Island_Theme) {
            ScriptTheme.TimerBonusThemeIslandLeft();
            }
            if (PanelThreeteen.GetComponent<Image>().sprite == Volcano_Theme) {
            ScriptTheme.TimerBonusThemeVolcanoLeft();
            }
            if (PanelThreeteen.GetComponent<Image>().sprite == NightSky_Theme) {
            ScriptTheme.TimerBonusThemeNightSkyLeft();
            }
            if (PanelThreeteen.GetComponent<Image>().sprite == Autumn_Theme) {
            ScriptTheme.TimerBonusThemeAutumnLeft();
            }
            if (PanelThreeteen.GetComponent<Image>().sprite == Dinosaurus_Theme) {
            ScriptTheme.TimerBonusThemeDinosaurusLeft();
            }
            if (PanelThreeteen.GetComponent<Image>().sprite == Aquarium_Theme) {
            ScriptTheme.TimerBonusThemeAquariumLeft();
            }
            if (PanelThreeteen.GetComponent<Image>().sprite == Space_Theme) {
            ScriptTheme.TimerBonusThemeSpaceLeft();
            }
            if (PanelThreeteen.GetComponent<Image>().sprite == Rain_Theme) {
            ScriptTheme.TimerBonusThemeRainLeft();
            }

            PanelThreeteen.GetComponent<Image>().sprite = Clasic_Sprite;
        }
    }

    if (IntFourteen == 1){
    ulong Biff_Fourteen = ((ulong)DateTime.Now.Ticks - LastTimeFourteen);
    ulong M_Fourteen = Biff_Fourteen / TimeSpan.TicksPerMillisecond;
    float SecondsLeftFourteen = (float)(WaitMsFourteen - M_Fourteen) / 1000.0f;

    string StringFourteen = "";
    // HOURS
    StringFourteen += ((int)SecondsLeftFourteen / 3600).ToString() + ":";
    SecondsLeftFourteen -= ((int)SecondsLeftFourteen / 3600) * 3600;
    //MINUTES
    StringFourteen += ((int)SecondsLeftFourteen / 60).ToString("00") + ":";
    //SECONDS
    StringFourteen += (SecondsLeftFourteen % 60).ToString("00");
    TextFourteen.text = StringFourteen;

        if (SecondsLeftFourteen < 0)
        {
            ObjectFourteen.SetActive(false);

            IntPanelSpecial -= 1;
            PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial);

            if (IntPanelSpecial <= 0)
            {
              IntPanel = 0;
              PlayerPrefs.SetInt("IntPanel", IntPanel);
            }

            IntFourteen = 0;
            PlayerPrefs.SetInt("IntFourteen", IntFourteen); 

            if (PanelFourteen.GetComponent<Image>().sprite == Star_Character) {
            ScriptCharacter.TimerBonusThemeStarLeft();
            }
            if (PanelFourteen.GetComponent<Image>().sprite == Cupcake_Character) {
            ScriptCharacter.TimerBonusThemeCupCakeLeft();
            }
            if (PanelFourteen.GetComponent<Image>().sprite == Heart_Character) {
            ScriptCharacter.TimerBonusThemeHeartLeft();
            }
            if (PanelFourteen.GetComponent<Image>().sprite == Ballon_Character) {
            ScriptCharacter.TimerBonusThemeCrabLeft();
            }
            if (PanelFourteen.GetComponent<Image>().sprite == Crab_Character) {
            ScriptCharacter.TimerBonusThemeBalloonLeft();
            }
            if (PanelFourteen.GetComponent<Image>().sprite == Ghost_Character) {
            ScriptCharacter.TimerBonusThemeGhostLeft();
            }
            if (PanelFourteen.GetComponent<Image>().sprite == Squid_Character) {
            ScriptCharacter.TimerBonusThemeSquidLeft();
            }
            if (PanelFourteen.GetComponent<Image>().sprite == Flame_Character) {
            ScriptCharacter.TimerBonusThemeFlameLeft();
            }
            if (PanelFourteen.GetComponent<Image>().sprite == Strawberry_Character) {
            ScriptCharacter.TimerBonusThemeStrawberryLeft();
            }
            if (PanelFourteen.GetComponent<Image>().sprite == Head_Character) {
            ScriptCharacter.TimerBonusThemeHeadLeft();
            }
            if (PanelFourteen.GetComponent<Image>().sprite == Slime_Character) {
            ScriptCharacter.TimerBonusThemeSlimeLeft();
            }
            if (PanelFourteen.GetComponent<Image>().sprite == Bunny_Character) {
            ScriptCharacter.TimerBonusThemeBunnyLeft();
            }
            if (PanelFourteen.GetComponent<Image>().sprite == Mushroom_Character) {
            ScriptCharacter.TimerBonusThemeMushroomLeft();
            }
            if (PanelFourteen.GetComponent<Image>().sprite == IceCream_Character) {
            ScriptCharacter.TimerBonusThemeIceCreamLeft();
            }
            if (PanelFourteen.GetComponent<Image>().sprite == Bear_Character) {
            ScriptCharacter.TimerBonusThemeBearLeft();
            }
            if (PanelFourteen.GetComponent<Image>().sprite == Flower_Character) {
            ScriptCharacter.TimerBonusThemeFlowerLeft();
            }
            if (PanelFourteen.GetComponent<Image>().sprite == JellyFish_Character) {
            ScriptCharacter.TimerBonusThemeJellyFishLeft();
            }
            if (PanelFourteen.GetComponent<Image>().sprite == Flowers_Theme) {
            ScriptTheme.TimerBonusThemeFlowerLeft();
            }
            if (PanelFourteen.GetComponent<Image>().sprite == Pyramids_Theme) {
            ScriptTheme.TimerBonusThemePyramidsLeft();
            }
            if (PanelFourteen.GetComponent<Image>().sprite == Desert_Theme) {
            ScriptTheme.TimerBonusThemeDesertLeft();
            }
            if (PanelFourteen.GetComponent<Image>().sprite == Snow_Theme) {
            ScriptTheme.TimerBonusThemeSnowLeft();
            }
            if (PanelFourteen.GetComponent<Image>().sprite == Island_Theme) {
            ScriptTheme.TimerBonusThemeIslandLeft();
            }
            if (PanelFourteen.GetComponent<Image>().sprite == Volcano_Theme) {
            ScriptTheme.TimerBonusThemeVolcanoLeft();
            }
            if (PanelFourteen.GetComponent<Image>().sprite == NightSky_Theme) {
            ScriptTheme.TimerBonusThemeNightSkyLeft();
            }
            if (PanelFourteen.GetComponent<Image>().sprite == Autumn_Theme) {
            ScriptTheme.TimerBonusThemeAutumnLeft();
            }
            if (PanelFourteen.GetComponent<Image>().sprite == Dinosaurus_Theme) {
            ScriptTheme.TimerBonusThemeDinosaurusLeft();
            }
            if (PanelFourteen.GetComponent<Image>().sprite == Aquarium_Theme) {
            ScriptTheme.TimerBonusThemeAquariumLeft();
            }
            if (PanelFourteen.GetComponent<Image>().sprite == Space_Theme) {
            ScriptTheme.TimerBonusThemeSpaceLeft();
            }
            if (PanelFourteen.GetComponent<Image>().sprite == Rain_Theme) {
            ScriptTheme.TimerBonusThemeRainLeft();
            }

            PanelFourteen.GetComponent<Image>().sprite = Clasic_Sprite;
        }
    }

    if (IntFiveteen == 1){
    ulong Biff_Fiveteen = ((ulong)DateTime.Now.Ticks - LastTimeFiveteen);
    ulong M_Fiveteen = Biff_Fiveteen / TimeSpan.TicksPerMillisecond;
    float SecondsLeftFiveteen = (float)(WaitMsFiveteen - M_Fiveteen) / 1000.0f;

    string StringFiveteen = "";
    // HOURS
    StringFiveteen += ((int)SecondsLeftFiveteen / 3600).ToString() + ":";
    SecondsLeftFiveteen -= ((int)SecondsLeftFiveteen / 3600) * 3600;
    //MINUTES
    StringFiveteen += ((int)SecondsLeftFiveteen / 60).ToString("00") + ":";
    //SECONDS
    StringFiveteen += (SecondsLeftFiveteen % 60).ToString("00");
    TextFiveteen.text = StringFiveteen;

        if (SecondsLeftFiveteen < 0)
        {
            ObjectFiveteen.SetActive(false);

            IntPanelSpecial -= 1;
            PlayerPrefs.SetInt("IntPanelSpecial", IntPanelSpecial);

            if (IntPanelSpecial <= 0)
            {
              IntPanel = 0;
              PlayerPrefs.SetInt("IntPanel", IntPanel);
            }

            IntFiveteen = 0;
            PlayerPrefs.SetInt("IntFiveteen", IntFiveteen); 

            if (PanelFiveteen.GetComponent<Image>().sprite == Star_Character) {
            ScriptCharacter.TimerBonusThemeStarLeft();
            }
            if (PanelFiveteen.GetComponent<Image>().sprite == Cupcake_Character) {
            ScriptCharacter.TimerBonusThemeCupCakeLeft();
            }
            if (PanelFiveteen.GetComponent<Image>().sprite == Heart_Character) {
            ScriptCharacter.TimerBonusThemeHeartLeft();
            }
            if (PanelFiveteen.GetComponent<Image>().sprite == Ballon_Character) {
            ScriptCharacter.TimerBonusThemeCrabLeft();
            }
            if (PanelFiveteen.GetComponent<Image>().sprite == Crab_Character) {
            ScriptCharacter.TimerBonusThemeBalloonLeft();
            }
            if (PanelFiveteen.GetComponent<Image>().sprite == Ghost_Character) {
            ScriptCharacter.TimerBonusThemeGhostLeft();
            }
            if (PanelFiveteen.GetComponent<Image>().sprite == Squid_Character) {
            ScriptCharacter.TimerBonusThemeSquidLeft();
            }
            if (PanelFiveteen.GetComponent<Image>().sprite == Flame_Character) {
            ScriptCharacter.TimerBonusThemeFlameLeft();
            }
            if (PanelFiveteen.GetComponent<Image>().sprite == Strawberry_Character) {
            ScriptCharacter.TimerBonusThemeStrawberryLeft();
            }
            if (PanelFiveteen.GetComponent<Image>().sprite == Head_Character) {
            ScriptCharacter.TimerBonusThemeHeadLeft();
            }
            if (PanelFiveteen.GetComponent<Image>().sprite == Slime_Character) {
            ScriptCharacter.TimerBonusThemeSlimeLeft();
            }
            if (PanelFiveteen.GetComponent<Image>().sprite == Bunny_Character) {
            ScriptCharacter.TimerBonusThemeBunnyLeft();
            }
            if (PanelFiveteen.GetComponent<Image>().sprite == Mushroom_Character) {
            ScriptCharacter.TimerBonusThemeMushroomLeft();
            }
            if (PanelFiveteen.GetComponent<Image>().sprite == IceCream_Character) {
            ScriptCharacter.TimerBonusThemeIceCreamLeft();
            }
            if (PanelFiveteen.GetComponent<Image>().sprite == Bear_Character) {
            ScriptCharacter.TimerBonusThemeBearLeft();
            }
            if (PanelFiveteen.GetComponent<Image>().sprite == Flower_Character) {
            ScriptCharacter.TimerBonusThemeFlowerLeft();
            }
            if (PanelFiveteen.GetComponent<Image>().sprite == JellyFish_Character) {
            ScriptCharacter.TimerBonusThemeJellyFishLeft();
            }
            if (PanelFiveteen.GetComponent<Image>().sprite == Flowers_Theme) {
            ScriptTheme.TimerBonusThemeFlowerLeft();
            }
            if (PanelFiveteen.GetComponent<Image>().sprite == Pyramids_Theme) {
            ScriptTheme.TimerBonusThemePyramidsLeft();
            }
            if (PanelFiveteen.GetComponent<Image>().sprite == Desert_Theme) {
            ScriptTheme.TimerBonusThemeDesertLeft();
            }
            if (PanelFiveteen.GetComponent<Image>().sprite == Snow_Theme) {
            ScriptTheme.TimerBonusThemeSnowLeft();
            }
            if (PanelFiveteen.GetComponent<Image>().sprite == Island_Theme) {
            ScriptTheme.TimerBonusThemeIslandLeft();
            }
            if (PanelFiveteen.GetComponent<Image>().sprite == Volcano_Theme) {
            ScriptTheme.TimerBonusThemeVolcanoLeft();
            }
            if (PanelFiveteen.GetComponent<Image>().sprite == NightSky_Theme) {
            ScriptTheme.TimerBonusThemeNightSkyLeft();
            }
            if (PanelFiveteen.GetComponent<Image>().sprite == Autumn_Theme) {
            ScriptTheme.TimerBonusThemeAutumnLeft();
            }
            if (PanelFiveteen.GetComponent<Image>().sprite == Dinosaurus_Theme) {
            ScriptTheme.TimerBonusThemeDinosaurusLeft();
            }
            if (PanelFiveteen.GetComponent<Image>().sprite == Aquarium_Theme) {
            ScriptTheme.TimerBonusThemeAquariumLeft();
            }
            if (PanelFiveteen.GetComponent<Image>().sprite == Space_Theme) {
            ScriptTheme.TimerBonusThemeSpaceLeft();
            }
            if (PanelFiveteen.GetComponent<Image>().sprite == Rain_Theme) {
            ScriptTheme.TimerBonusThemeRainLeft();
            }

            PanelFiveteen.GetComponent<Image>().sprite = Clasic_Sprite;
        }
    }
}
}