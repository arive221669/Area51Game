using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMov : MonoBehaviour
{
    private bool moveRight = true;
    public float speed;

    private Rigidbody2D rb;
    private Animator anim;

    private bool isRunning;


    void Start(){
      rb = GetComponent<Rigidbody2D>();
      anim = GetComponent<Animator>();
    }

    void Update()
    {
        move();
    }
    void move()
    {
        if (moveRight)
            transform.Translate(Vector2.right * speed * Time.deltaTime);

        else
            transform.Translate(-Vector2.right * speed * Time.deltaTime);



        if (transform.position.x >= 1.0f)
        {
            moveRight = false;
            anim.SetBool("isMoving", true);
        }

        if (transform.position.x <= -1)
        {
            moveRight = true;

        }

        if (transform.position.y >= 1.0f)
        {
            moveRight = false;
            anim.SetBool("isMoving", true);
        }

        if (transform.position.y <= -1)
        {
            moveRight = true;
        }
    }
/*    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(GameObject.FindWithTag("Player"));
        }
    }*/
}
