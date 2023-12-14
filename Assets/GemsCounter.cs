using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GemsCounter : MonoBehaviour
{
    private TextMeshProUGUI gemsText;
    // Start is called before the first frame update
    void Start()
    {
        gemsText = GetComponentInChildren<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        gemsText.text = CurrenciesManager.myInstance.GetGems().ToString();
    }
}
