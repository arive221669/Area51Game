using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBehavior : MonoBehaviour
{
    Image healthBar;
    public float maxHealth = 100f;
    public static float health;
    public GameObject deathEffect;
    public GameObject Enemy;
    public GameObject Player;


    private void Start()
    {
        healthBar = GetComponent<Image>();
        health = maxHealth;
    }
    void Update()
    {
        healthBar.fillAmount = health / maxHealth;
        Debug.Log(health);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    //Should kill Player
    public void OnCollisionEnter2D(Collision2D collision) //
    {
        if (Enemy.gameObject.tag == "Enemy")
        {
            Debug.Log("poatoes");
        }
        if (Player.gameObject.tag == "Player")
        {
            Debug.Log("tomatoes");
            //collision.gameObject.GetComponent<PlayerStats>().PlayerKilled();

        }
    }
}
