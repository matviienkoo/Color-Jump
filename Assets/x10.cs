using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class x10 : MonoBehaviour
{   
    public int Ten_Gold_Animation;
    public Animation Anim;

    private void Update ()
    {
        Ten_Gold_Animation = PlayerPrefs.GetInt("Ten_Gold_Animation");
        if (Ten_Gold_Animation >= 1)
        {
            Anim.Play();
            Ten_Gold_Animation = 0;
            PlayerPrefs.SetInt("Ten_Gold_Animation",Ten_Gold_Animation);
        }
    }
}
