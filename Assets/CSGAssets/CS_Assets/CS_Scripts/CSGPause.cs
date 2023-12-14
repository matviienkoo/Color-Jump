using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CSGPause:MonoBehaviour 
{
	[Header("Pause System")]
	public GameObject PauseObjectON;
	public GameObject PauseObjectOFF;
	public bool pauseOnStart = true;

	internal float prevTimeScale = 1;
	private int int_pause;

	public void Pause()
	{
		if ( prevTimeScale != 0 ) prevTimeScale = Time.timeScale;
		Time.timeScale = 0;
		AudioListener.pause = true;

		// Pause the game
		PauseObjectON.SetActive(false);
		PauseObjectOFF.SetActive(true);

		int_pause = 1;
		PlayerPrefs.SetInt("int_pause",int_pause);
	}

	public void Resume()
	{
		Time.timeScale = prevTimeScale;
		AudioListener.pause = false;

		// Return to the previous game speed
		PauseObjectON.SetActive(true);
		PauseObjectOFF.SetActive(false);

		int_pause = 0;
		PlayerPrefs.SetInt("int_pause",int_pause);
	}
}

