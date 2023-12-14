using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteAnimator : MonoBehaviour
{
    [SerializeField] Sprite[] frameArray;
    [SerializeField] float framerate;
    private int currentFrame;
    private float timer;
    private SpriteRenderer sr;

    private void Awake()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= framerate)
        {
            timer -= framerate;
            currentFrame = (currentFrame + 1) % frameArray.Length;
            sr.sprite = frameArray[currentFrame];
        }
    }
}
