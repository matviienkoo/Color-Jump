using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinsCounter : MonoBehaviour
{
    private TextMeshProUGUI coinsText;
    // Start is called before the first frame update
    void Start()
    {
        coinsText = GetComponentInChildren<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        coinsText.text = CurrenciesManager.myInstance.GetCoins().ToString();   
    }
}
