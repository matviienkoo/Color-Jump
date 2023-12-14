using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadingScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { 
        var username = PlayerPrefs.GetString("USERNAME", "");

        if(Application.internetReachability == NetworkReachability.NotReachable)
        {
            Invoke(nameof(LoadMenu), 3f);
        }

        else

        if(username != string.Empty)
        {
            PlayfabManager.Instance.LoginByUsername(username, (isSuccess) => {
                if (isSuccess)
                {
                    PlayfabManager.IsLogined = true;
                }
                Invoke(nameof(LoadMenu), 3f);
            });
        }
        else
        {
            Invoke(nameof(LoadMenu), 3f);
        }
    }

    private void LoadMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
