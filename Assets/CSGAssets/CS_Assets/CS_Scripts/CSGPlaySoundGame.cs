using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DigitalRuby.SoundManagerNamespace
{
public class CSGPlaySoundGame : MonoBehaviour
{
	[Space]
	public AudioSource[] Sound;
	public int Gold_sound;
	public int ColorBall_sound;

	private void Start ()
	{
		Gold_sound = 0;
		PlayerPrefs.SetInt("Gold_sound",Gold_sound);

		ColorBall_sound = 0;
		PlayerPrefs.SetInt("ColorBall_sound",ColorBall_sound);		
	}

	private void PlaySound(int index)
    {
        Sound[index].PlayOneShotSoundManaged(Sound[index].clip);
    }

	void Update ()
	{
		ColorBall_sound = PlayerPrefs.GetInt("ColorBall_sound");
		Gold_sound = PlayerPrefs.GetInt("Gold_sound");
		if (Gold_sound >= 1)
		{
			PlaySound(0);
			Gold_sound = 0;
			PlayerPrefs.SetInt("Gold_sound",Gold_sound);
		}

		if (ColorBall_sound >= 1)
		{
			PlaySound(1);
			ColorBall_sound = 0;
			PlayerPrefs.SetInt("ColorBall_sound",ColorBall_sound);
		}
	}
}
}