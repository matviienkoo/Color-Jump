using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectsProbability : MonoBehaviour
{   
    [Header("Probability objects")]
    public GameObject FirstObject;
    public GameObject SecondObject;

    private void Start ()
    {
        int IntRandom = Random.Range(0, 101);

        if (IntRandom < 10){
        FirstObject.SetActive(true);
        }

        if (IntRandom >= 10){
        SecondObject.SetActive(true);
        }
    }
}
