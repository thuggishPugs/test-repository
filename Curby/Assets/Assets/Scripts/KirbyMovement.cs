using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KirbyMovement : MonoBehaviour
{
    public KirbyMovement()
    { }
        Rigidbody2D rb;
        
        private int moveValue;
    private float velocity;
    private bool isFacingRight;
    private bool isFacingLeft;
    // Start is called before the first frame update
    }
    void Awake()
    {
        rb = gameObject.AddComponent<Rigidbody2D>();
    }
    void Start()
    {
        velocity = new Vector2(1.75f, 1.1f);
        transform.position = new Vector3(-2.0f, -2.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {

        float hValue = Input.GetAxis("Horizontal");
        Debug.Log(hValue);
        //transform.Translate(new Vector3(hValue,0,0));
        if ((isFacingLeft && moveValue > 0) ||

        (!isFacingLeft && moveValue < 0))
        {
            Flip();
        }

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
    }

    void Flip()
    {
        isFacingLeft = !isFacingLeft;
        Vector3 scaleFactor = transform.localScale;
        scaleFactor.x *= -1;
        // or can use scaleFactor.x = -scaleFactor.x;
        transform.localScale = scaleFactor;
    }


