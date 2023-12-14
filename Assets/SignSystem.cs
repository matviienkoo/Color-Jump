using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;


public class SignSystem : MonoBehaviour
{
   // private const float AuthenticationWaitTimeSeconds = 10;

   // void Awake()
   // {
   //     GameObject[] objs = GameObject.FindGameObjectsWithTag("SignSystem");
   //     DontDestroyOnLoad(this.gameObject);
   // }

   // void Start () 
   // {

   //// PlayGamesPlatform.DebugLogEnabled = true;
   //// PlayGamesPlatform.Activate();
   // Social.localUser.Authenticate((bool success) => {
   // if (success) Debug.Log("Good Authetincation");
   // else StartCoroutine(WaitForAuthenticationCoroutine());
   // });

   // }

   // private IEnumerator WaitForAuthenticationCoroutine()
   // {
   //     var startTime = Time.realtimeSinceStartup;

   //     while (!Social.localUser.authenticated)
   //     {
   //         if (Time.realtimeSinceStartup - startTime > AuthenticationWaitTimeSeconds)
   //         {
   //             // X seconds have passed and we are still not authenticated, time to give up.
   //             break;
   //         }

   //         yield return null;
   //     }

   //     if (Social.localUser.authenticated)
   //     {
   //         Debug.Log("Good Authetincation");
   //     }
   //     else
   //     {
   //         Debug.Log("Bad Authetincation");
   //     }
   // }
}
