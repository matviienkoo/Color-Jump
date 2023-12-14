using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
using TMPro;

public class MenuNavigation : MonoBehaviour
{
    public int IntMusic;

    public List<GameObject> MenuObjects;
    public TextMeshProUGUI LeaderBoardText;
    public GameObject userNameUI;
    public GameObject ratedUI;
    public GameObject statsUI;

    [Header("Main Panels")]
    public GameObject shopUI;
    public GameObject themeUI;
    public GameObject charactersUI;
    public GameObject moregamesUI;

    [Header("Music System")]
    public GameObject GameMusic;

    public Image MusicUI;
    public Sprite OnMusic;
    public Sprite OffMusic;

    [Header("Load System")]
    public GameObject LoaderUI;
    public Slider progressSlider;

    [Header("Stats")]
    public int Gold;
    public int Gems;
    public int Mils;
    public TextMeshProUGUI gemsText;
    public TextMeshProUGUI goldText;
    public TextMeshProUGUI milsText;

    private void Start()
    {
        IntMusic = PlayerPrefs.GetInt("IntMusic");
        if (IntMusic == 1)
        {
            // Off music
            GameMusic.SetActive(false);
            MusicUI.sprite = OffMusic;
        }

        if (IntMusic == 0)
        {
            // On music
            GameMusic.SetActive(true);
            MusicUI.sprite = OnMusic;
            IntMusic = 0;
        }
        
        userNameUI.SetActive(!PlayfabManager.IsLogined);
        LeaderTextSystem();
    }

    public void LeaderTextSystem ()
    {
        PlayfabManager.Instance.GetMonthlyLeaderBoardData((data) =>
        {
            LeaderBoardText.text = "Congratulations " + data[0].PlayerName + " you are on the first place in the leaderboard";
        });
    }

    // -- Play Button
    public void LoadScene(int index)
    {
        StartCoroutine(LoadScene_Coroutine(index));
    }

    public IEnumerator LoadScene_Coroutine(int index)
    {
        progressSlider.value = 0;
        LoaderUI.SetActive(true);
 
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(2);
        asyncOperation.allowSceneActivation = false;
        float progress = 0;
 
        while (!asyncOperation.isDone)
        {
            progress = Mathf.MoveTowards(progress, asyncOperation.progress, Time.deltaTime);
            progressSlider.value = progress;
            if (progress >= 0.9f)
            {
                progressSlider.value = 1;
                asyncOperation.allowSceneActivation = true;
            }
            yield return null;
        }
    }

    // -- Main Buttons
    public void OpenShop()
    {   
        Closed();
        shopUI.SetActive(true);
    }

    public void OpenTheme()
    {   
        Closed();
        themeUI.SetActive(true);
    }

    public void OpenCharacters()
    {   
        Closed();
        charactersUI.SetActive(true);
    }

    public void OpenMoreGames()
    {   
        Closed();
        moregamesUI.SetActive(true);
    }

    public void Closed()
    {   
        for(int x = 0;x < MenuObjects.Count;x++){
        MenuObjects[x].SetActive(false);
        }
    }

    // -- Other Buttons
    public void ButtonStats()
    {
        var userTex = statsUI.transform.GetChild(0).GetChild(0);
        userTex.GetComponent<Text>().text = PlayerPrefs.GetString("USERNAME", "");

        Gold = PlayerPrefs.GetInt("Gold");
        goldText.text = Gold.ToString();
        
        Gems = PlayerPrefs.GetInt("Gems");
        gemsText.text = Gems.ToString();

        Mils = PlayerPrefs.GetInt("MilesAnalitics");
        milsText.text = Mils.ToString();

        statsUI.SetActive(true);
    }

    public void ButtonMusic()
    {
        IntMusic += 1;

        if (IntMusic == 1)
        {
            // Off music
            GameMusic.SetActive(false);
            MusicUI.sprite = OffMusic;
        }
        if (IntMusic == 2)
        {
            // On music
            GameMusic.SetActive(true);
            MusicUI.sprite = OnMusic;
            IntMusic = 0;
        }

        PlayerPrefs.SetInt("IntMusic",IntMusic);
    }

    public void ButtonLink()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.MDgraphicLab.SpaceBlast&hl=ro&gl=US"); 
    }

    public void ButtonRate()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.MdGame.ColorJump&hl=ro&gl=US"); 
        StartCoroutine ("IEnumeratorRate");
    }

    IEnumerator IEnumeratorRate ()
    {
        yield return new WaitForSeconds(1f);
        ratedUI.SetActive(true);
    }

    public void ButtonShare ()
    {
        StartCoroutine ("TakeScreenShotAndShare");
    }

    IEnumerator TakeScreenShotAndShare ()
    {
        yield return new WaitForEndOfFrame ();

        Texture2D tx = new Texture2D (Screen.width, Screen.height, TextureFormat.RGB24, false);
        tx.ReadPixels (new Rect (0, 0, Screen.width, Screen.height), 0, 0);
        tx.Apply ();

        string path = Path.Combine (Application.temporaryCachePath, "sharedImage.png");//image name
        File.WriteAllBytes (path, tx.EncodeToPNG ());

        Destroy (tx); //to avoid memory leaks

        new NativeShare ()
        .SetSubject ("Color Jump")
        .SetText ("https://play.google.com/store/apps/details?id=com.MdGame.ColorJump")
        .Share ();
    }
}
