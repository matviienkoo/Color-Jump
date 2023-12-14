using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Resolutions_Script : MonoBehaviour
{
    // Shop Resolution
    public GameObject New_Graphicg;
    public GameObject Old_Graphicg;

    public int width;
    public int height; 

    void Start()
    {
        Resolution currentMonitorResolution;

        currentMonitorResolution = Screen.currentResolution;
 
        width = currentMonitorResolution.width;
        height = currentMonitorResolution.height;

        if (width >= 1000)
        {
            New_Graphicg.SetActive(true);
            Old_Graphicg.SetActive(false);
        }

        if (width < 1000)
        {
            New_Graphicg.SetActive(false);
            Old_Graphicg.SetActive(true);
        }
    }
}