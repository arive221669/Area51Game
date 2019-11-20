using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float movementInputDirection;

    private bool isFacingRight = true;
    //private bool isFacingUp = true;
    //Reloading test test

    private bool isWalking;

    private Rigidbody2D rb;

    private Animator anim;

    public float movementSpeed = 24.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    //Update is called once per frame
    void Update()
    {
        CheckInput();
        CheckMovementDirection();
        UpdateAnimations();
    }

    private void FixedUpdate()
    {
        ApplyMovement();
    }


    private void CheckMovementDirection()
    {
        if (isFacingRight && movementInputDirection < 0)
        {
            Flip();
        }
        else if (!isFacingRight && movementInputDirection > 0)
        {
            Flip();
        }

        // if (isFacingUp && movementInputDirection < 0)
        // {
        //     FlipUpDown();
        // }
        //
        // else if (!isFacingUp && movementInputDirection > 0)
        // {
        //     FlipUpDown();
        // }

        if (rb.velocity.x != 0)
        {
            isWalking = true;
        }
        else
        {
            isWalking = false;
        }
    }

    private void UpdateAnimations()
    {
        anim.SetBool("isWalking", isWalking);
    }

    private void CheckInput()
    {
        movementInputDirection = Input.GetAxis("Horizontal");
        //movementInputDirection = Input.GetAxis("Vertical");

        //this does nothing
    }


    private void ApplyMovement()
    {
        rb.velocity = new Vector2(movementSpeed * movementInputDirection, rb.velocity.y);
        //rb.velocity = new Vector2(movementSpeed * movementInputDirection, rb.velocity.x);
    }

    private void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.Rotate(0.0f, 180.0f, 0.0f);
    }

    // private void FlipUpDown()
    // {
    //     isFacingUp = !isFacingUp;
    //     transform.Rotate(180f, 0.0f, 0.0f);
    // }
}
