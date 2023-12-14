using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DigitalRuby.SoundManagerNamespace
{
public class CSGPlaySound : MonoBehaviour
{	
	public AudioSource[] Sound;

	private void PlaySound(int index)
    {
        Sound[index].PlayOneShotSoundManaged(Sound[index].clip);
    }

	public void Clasic_Sound ()
	{
		PlaySound(0);
	}

	public void Button_Sound ()
	{
		PlaySound(1);
	}

	public void Unlock_Sound ()
	{
		PlaySound(2);
	}

	public void Gems_Sound ()
	{
		PlaySound(3);
	}
	public void Gold_Sound ()
	{
		PlaySound(4);
	}
	public void Eror_Sound ()
	{
		PlaySound(5);
	}
	public void Select_Sound ()
	{
		PlaySound(6);
	}
	public void Scroll_Sound ()
	{
		PlaySound(7);
	}

	public void DeletSave ()
	{
		PlayerPrefs.DeleteAll();
	}
}
}