using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageAnimator : MonoBehaviour
{
    [SerializeField] Sprite[] frameArray;
    [SerializeField] float framerate;
    private int currentFrame;
    private float timer;
    private Image image;

    private void Awake()
    {
        image = gameObject.GetComponent<Image>();
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if(timer >= framerate)
        {
            timer -= framerate;
            currentFrame = (currentFrame + 1) % frameArray.Length;
            image.sprite = frameArray[currentFrame];
        }
    }
}
