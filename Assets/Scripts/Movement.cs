using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Joystick joystick;
    float horizontalMove = 0f;
    Rigidbody2D rb;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = joystick.Horizontal;
        rb.AddForce(new Vector2(horizontalMove * 3, 0));

    }
}
