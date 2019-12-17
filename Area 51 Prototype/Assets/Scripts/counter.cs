using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class counter : MonoBehaviour
{
    int Counter = 0;
    //public GameObject explosion;





    void OnCollisionEnter2D(Collision2D coll)
    {
       
        if (coll.gameObject.tag == "Coin")
        {
            Counter++;
            Debug.Log("counter " + Counter);

        }

    }
}
