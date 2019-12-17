﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

  public float speed = 500f;
  public int damage = 40;
  public Rigidbody2D rb;
  public GameObject impactEffect;

    // Start is called before the first frame update
    void Start(){
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo){
      Debug.Log(hitInfo.name);
      EnemyBehavior enemy = hitInfo.GetComponent<EnemyBehavior>();
      if (enemy != null){
        enemy.TakeDamage(damage);
      }

      Instantiate(impactEffect, transform.position, transform.rotation);
      Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collision2D col){
      if (col.gameObject.tag.Equals("Bullet")){
        Destroy (col.gameObject);
        //Destroy (gameObject);
      }
    }

}
