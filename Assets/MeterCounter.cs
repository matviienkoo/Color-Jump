using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MeterCounter : MonoBehaviour
{
    private Transform player;
    private TextMeshProUGUI meterText;
    public TextMeshProUGUI meterText_GameOver;

    public int intPos;
    public int intSave;
    public int ResumeInt;
    public int MilesRemove;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        meterText = GetComponentInChildren<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {   
        ResumeInt = PlayerPrefs.GetInt("ResumeInt");
        MilesRemove = PlayerPrefs.GetInt("MilesRemove");
        // distance
        if (player != null)
            AddDistance();

    }
    private void AddDistance()
    {
        if (ResumeInt == 0){
        intPos = (int)player.position.y + 3;
        intSave = (int)player.position.y + 3;
        }
        if (ResumeInt == 1){
        intPos = (int)player.position.y + MilesRemove + 3;
        }

        meterText.text = intPos.ToString();
        meterText_GameOver.text = intPos.ToString();

        PlayerPrefs.SetInt("intPos",intPos);
        PlayerPrefs.SetInt("intSave",intSave);
    }
}
