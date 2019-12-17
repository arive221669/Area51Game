using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move2D : MonoBehaviour
{
    //public float jumpVelocity = 50f;
    
      private float movementInputDirection;
      private float movementInputDirectionUp;
      private bool isFacingRight = true;
      public bool isFacingUp = true;

      public float moveSpeed;
      private bool isMoving;
      private bool isShooting;
      private bool isKnifeState;
      private bool isKnifeAttacking;
      private bool isKnifeMoving;
      private bool isShotgunState;
      private bool isShotgunShooting;
      private bool isShotgunMoving;
      //public bool isGrounded = false;

      private Rigidbody2D rb;
      private Animator anim;


    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update(){

        CheckInput();
        CheckInputUp();
        CheckMovementDirection();
        CheckMovementDirectionUp();
        UpdateAnimations();
        ApplyMovement();
        ApplyMovementUp();
        // CheckCrouch();
        // CheckAttackRun();
        State1();
    }

      private void UpdateAnimations(){
          // State 1
          anim.SetBool("isMoving", isMoving);
          anim.SetBool("isShooting", isShooting);
          // State 2
          anim.SetBool("isKnifeState", isKnifeState);
          //anim.SetBool("isKnifeMoving", isKnifeMoving);
          anim.SetBool("isKnifeAttacking", isKnifeAttacking);
          // State 3
          anim.SetBool("isShotgunState", isShotgunState);
          //anim.SetBool("isShotgunMoving", isShotgunMoving);
          anim.SetBool("isShotgunShooting", isShotgunShooting);
        }

      private void ApplyMovement(){
          Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
          transform.position += movement * Time.deltaTime * moveSpeed;

        }

        private void ApplyMovementUp(){
            Vector3 movement = new Vector3(0f, Input.GetAxis("Vertical"), 0f);
            transform.position += movement * Time.deltaTime * moveSpeed;

          }

    // void Jump(){
    //   if (Input.GetKeyDown(KeyCode.W) && isGrounded == true){
    //       //gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 50f), ForceMode2D.Impulse);
    //       GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpVelocity;
    //     }
    //   }

      private void State1(){
        if (Input.GetKeyDown(KeyCode.Space)){
            isShooting = true;

        } else if(Input.GetKeyUp(KeyCode.Space)){
            isShooting = false;
        }
      }

      // private void State2(){
      //   if (Input.GetKeyDown(KeyCode.Space)){
      //       isShooting = true;
      //
      //   } else if(Input.GetKeyUp(KeyCode.Space)){
      //       isShooting = false;
      //   }
      // }

      // private void CheckAttackRun(){
      //   if (Input.GetKeyDown(KeyCode.D) && Input.GetKeyDown(KeyCode.Space)){
      //       isRunAttacking = true;
      //
      //   } else if(Input.GetKeyUp(KeyCode.D) && Input.GetKeyUp(KeyCode.Space)){
      //       isRunAttacking = false;
      //   }
      // }

      // private void CheckCrouch(){
      //   if (Input.GetKeyDown(KeyCode.S)){
      //       isCrouching = true;
      //
      //   } else if(Input.GetKeyUp(KeyCode.S)){
      //       isCrouching = false;
      //   }
      // }

      private void CheckMovementDirection(){
          if (isFacingRight && movementInputDirection < 0){
              Flip();
          }
          else if (!isFacingRight && movementInputDirection > 0){
              Flip();
          }

          if (movementInputDirection != 0){
              isMoving = true;
          }
          else{
              isMoving = false;
          }
      }

      private void CheckMovementDirectionUp(){
          if (isFacingUp && movementInputDirectionUp < 0){
              //Flip();
          }
          else if (!isFacingUp && movementInputDirectionUp > 0){
              //Flip();
          }

          if (movementInputDirectionUp != 0){
              isMoving = true;
          }
          else{
              isMoving = false;
          }
      }

      private void CheckInput(){
          movementInputDirection = Input.GetAxis("Horizontal");
      }

      private void CheckInputUp(){
          movementInputDirectionUp = Input.GetAxis("Vertical");
      }


      private void Flip(){
          isFacingRight = !isFacingRight;
          //isFacingUp = !isFacingUp;
          transform.Rotate(0.0f, 180.0f, 0.0f);
      }

}
