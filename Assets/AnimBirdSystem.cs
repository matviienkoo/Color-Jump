using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimBirdSystem : MonoBehaviour
{   

public Animation AnimBird;
public int int_dead;

public string ChangeAnimation;

public float TimerChoice;
public float TimerSystem;

private void Start ()
{
    TimerChoice = 6;
}

private void Update ()
{
int_dead = PlayerPrefs.GetInt("int_dead");

    // Spawn Night Sky Bird
    if (int_dead == 0)
    {
        TimerSystem += Time.deltaTime;
        if (TimerSystem >= TimerChoice)
        {
            int num = Random.Range(0, 2);

            if (num == 0)
            {
                TimerChoice = 16;
                ChangeAnimation = "Night Bird 1";
                AnimBird.Play("Night Bird 1");
            }
            if (num == 1)
            {
                TimerChoice = 16;
                ChangeAnimation = "Night Bird 2";
                AnimBird.Play("Night Bird 2");
            }

            TimerSystem = 0;
        }
    }

}
}
