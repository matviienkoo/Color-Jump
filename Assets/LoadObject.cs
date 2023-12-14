using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadObject : MonoBehaviour
{
    private void Awake ()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
