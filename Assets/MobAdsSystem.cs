using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class MobAdsSystem : MonoBehaviour
{
    void Awake()
    {
        MobileAds.Initialize(initStatus => { });
    }
}
