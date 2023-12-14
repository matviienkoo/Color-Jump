using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBarMove : MonoBehaviour
{
    [SerializeField] bool isGoingRight;
    [SerializeField] float speed;
    [SerializeField] float maxPosRight, maxPosLeft;
    private Vector2 originPos;
    // Start is called before the first frame update
    void Start()
    {
        originPos = this.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGoingRight)
            MoveRight();
        else
            MoveLeft();
    }
    private void MoveRight()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        if (transform.localPosition.x >= maxPosRight)
            transform.localPosition = originPos;

    }
    private void MoveLeft()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.localPosition.x <= maxPosLeft)
            transform.localPosition = originPos;
    }
}