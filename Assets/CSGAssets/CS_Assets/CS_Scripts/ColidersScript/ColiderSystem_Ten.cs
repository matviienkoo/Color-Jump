using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColiderSystem_Ten : MonoBehaviour
{   
    public int CS_System;

    void OnTriggerEnter2D(Collider2D other)
    {
        if( other.tag == "Player" )
        {
        CS_System = 10;
        PlayerPrefs.SetInt ("CS_System", CS_System);
        }
    }   
}
