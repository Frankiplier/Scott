using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller_left_and_right : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        
        movement = new Vector2(moveX, 0f);
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(movement.x * moveSpeed, rb.velocity.y);
    }
}