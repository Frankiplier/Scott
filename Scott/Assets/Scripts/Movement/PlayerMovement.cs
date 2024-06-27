using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;

    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;

    private Rigidbody2D rb;
    private Vector2 movement;
    private bool isGrounded;
    private float originalHeight;
    private float direction = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        originalHeight = transform.localScale.y;
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        direction = Input.GetAxis("Horizontal");

        animator.SetFloat("Speed", Mathf.Abs(rb.velocity.x));

        // ify na sterowanie postacia lewo-prawo
        if (direction < 0)  
        {
            rb.velocity = new Vector2(direction * moveSpeed, rb.velocity.y);
            transform.localScale = new Vector2(-0.3f, 0.3f);
        }
        else if (direction > 0)
        {
            rb.velocity = new Vector2(direction * moveSpeed, rb.velocity.y);
            transform.localScale = new Vector2(0.3f, 0.3f);
        }

        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        movement = new Vector2(moveX, 0f);
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(movement.x * moveSpeed, rb.velocity.y);
    }
}