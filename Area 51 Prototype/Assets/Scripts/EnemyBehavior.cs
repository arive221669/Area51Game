using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
  public int health = 100;
  public GameObject deathEffect;
  public GameObject Enemy;
  public GameObject Player;

public void TakeDamage(int damage){
    health -= damage;

    if (health <= 0){
      Die();
    }
  }

    void Die(){
      Instantiate(deathEffect, transform.position, Quaternion.identity);
      Destroy(gameObject);
    }

    //Should kill Player
    public void OnCollisionEnter2D(Collision2D collision) //
    {
        if (Enemy.gameObject.tag == "Enemy")
        {
          Debug.Log("poatoes");
            Destroy(gameObject);
        }
        if (Player.gameObject.tag == "Player")
        {
          Debug.Log("tomatoes");
            //collision.gameObject.GetComponent<PlayerStats>().PlayerKilled();
            Destroy(gameObject);
        }
    }
}
