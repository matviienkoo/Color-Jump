using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationTrigger : MonoBehaviour
{
    public AudioSource HoleSound;
    public Animation HoleAnim;
    public bool UseAnimation;

    void OnTriggerEnter2D(Collider2D other){
    if (other.gameObject.CompareTag("Player")){
        if (UseAnimation == false){
        UseAnimation = true;
        if (PlayerPrefs.GetString("Sound") == "On"){
            HoleSound.Play();
        }   
            HoleAnim.Play();
        }
    }
    }
}
