using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boss : MonoBehaviour
{
    private float bossHP = 100;

    // Start is called before the first frame update
    void Start()
    {
       
    }
    void Update()
    {
        if (bossHP == 0)
        {
            SceneManager.LoadScene("you win");
        }
    }
    void OnParticleCollision(GameObject other)
    {

        if (other.tag == "att")
        {
            bossHP -= GameFlow.currentDamage;
            Debug.Log(bossHP);
        }

    }
}
