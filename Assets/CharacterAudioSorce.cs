using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterAudioSorce : MonoBehaviour
{
    public int CharacterInt;
    private float timer;
    public AudioSource JumpSound;

    private void Update ()
    {
        if (CharacterInt < 3)
        timer += Time.deltaTime;
        if (timer >= 0.7)
        {
            JumpSound.Play();
            CharacterInt += 1;
            timer = 0;
        }
    }
}
