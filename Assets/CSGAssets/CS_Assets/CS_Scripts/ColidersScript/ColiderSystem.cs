using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColiderSystem : MonoBehaviour
{   
    private int CS_System;
    public int ObjectNumber;

    void OnTriggerEnter2D(Collider2D other)
    {
        if( other.tag == "Player" )
        {
            CS_System = ObjectNumber;
            PlayerPrefs.SetInt ("CS_System", CS_System);
        }
    }   
}
