using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ManageAudioGameplay : MonoBehaviour
{
    [Header("Music And Sound Images")]
    public int IntMusic;

    public Image musicOn;
    public Image musicOff;
    public Image soundOn;
    public Image soundOff;

    [Header("Audio Sources")]
    public AudioSource[] musicAudioSources;
    public AudioSource[] soundAudioSources;

    private void Start()
    {
		IntMusic = PlayerPrefs.GetInt("IntMusic");

		if (IntMusic == 1)
		{
			TurnOffMusic();
		}
		if (PlayerPrefs.GetString("Sound") == "Off")
        {
        	TurnOffSound();
        }

		if (IntMusic == 0)
		{
			TurnOnMusic();
		}
        if (PlayerPrefs.GetString("Sound") == "On")
        {
        	TurnOnSound();
        }
    }

    // --- ON
    public void TurnOnSound()
    {
		//turn On the sound
		PlayerPrefs.SetString("Sound", "On");
		soundOn.gameObject.SetActive(true);
		soundOff.gameObject.SetActive(false);
		TurnOnSoundAudios();
	}
	public void TurnOnMusic()
    {
		//turn On the sound
		musicOn.gameObject.SetActive(true);
		musicOff.gameObject.SetActive(false);
		IntMusic = 0;
		PlayerPrefs.SetInt("IntMusic",IntMusic);

		TurnOnMusicAudios();
	}

	private void TurnOnSoundAudios()
	{
		for (int i = 0; i < soundAudioSources.Length; i++)
		{
			soundAudioSources[i].volume = 1f;
		}
	}

	private void TurnOnMusicAudios()
	{
		for (int i = 0; i < musicAudioSources.Length; i++)
		{
			musicAudioSources[i].volume = 1f;
		}
	}

	// --- OFF
	public void TurnOffSound()
	{
		//turn Of the sound
		PlayerPrefs.SetString("Sound", "Off");
		soundOn.gameObject.SetActive(false);
		soundOff.gameObject.SetActive(true);
		TurnOffSoundAudios();
	}
	public void TurnOffMusic()
	{
		//turn Off the sound
		musicOn.gameObject.SetActive(false);
		musicOff.gameObject.SetActive(true);
		IntMusic = 1;
		PlayerPrefs.SetInt("IntMusic",IntMusic);

		TurnOffMusicAudios();
	}

	private void TurnOffSoundAudios()
	{
		for (int i = 0; i < soundAudioSources.Length; i++)
		{
			soundAudioSources[i].volume = 0f;
		}
	}

	private void TurnOffMusicAudios()
	{
		for (int i = 0; i < musicAudioSources.Length; i++)
		{
			musicAudioSources[i].volume = 0f;
		}
	}

	public void SettingsBtnClick(GameObject panel)
	{
		if (!panel.activeInHierarchy)
		{
			panel.SetActive(true);
		}
		else
		{
			panel.SetActive(false);
		}
	}
}
