using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoleTrigger : MonoBehaviour
{
    public GameObject Platform;
    public bool UsePlatform;
    private int IntPlatform;

    void OnTriggerEnter2D(Collider2D other){
    if (other.gameObject.CompareTag("Player")){
        if (UsePlatform == false){
        Platform.SetActive(true);
        UsePlatform = true;
        IntPlatform = 1;
        PlayerPrefs.SetInt("IntPlatform", IntPlatform);
        }
    }
    }
}
