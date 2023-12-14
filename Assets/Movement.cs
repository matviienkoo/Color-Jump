using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private bool goingRight;
    [SerializeField] float speed;
    void Start()
    {
        if (transform.position.x < 0)
            goingRight = true;
        else if(transform.position.x > 0)
            goingRight = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!goingRight)
            MoveLeft();

        if(goingRight)
            MoveRight();
    }
    private void MoveRight()
    {
        this.transform.Translate(Vector2.right * speed * Time.deltaTime);
        if (!GetComponent<Renderer>().isVisible)
            Destroy(this.gameObject);
    }
    private void MoveLeft()
    {
        this.transform.Translate(Vector2.left * -speed * Time.deltaTime);
        if (!GetComponent<Renderer>().isVisible)
            Destroy(this.gameObject);
    }
}
