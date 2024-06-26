using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SadDance : MonoBehaviour
{
    public Sprite up, down, left, right;
    public Animator animator;

    void Start()
    {
        animator.enabled = true;
    }

    void Update()
    {
        // arrow up
        if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<SpriteRenderer>().sprite = up;
            animator.enabled = false;
        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            animator.enabled = true;
        }

        // arrow down
        if (Input.GetKey(KeyCode.DownArrow))
        {
            GetComponent<SpriteRenderer>().sprite = down;
            animator.enabled = false;
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            animator.enabled = true;
        }

        // arrow left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<SpriteRenderer>().sprite = left;
            animator.enabled = false;
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            animator.enabled = true;
        }

        // arrow right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<SpriteRenderer>().sprite = right;
            animator.enabled = false;
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            animator.enabled = true;
        }
    }
}
