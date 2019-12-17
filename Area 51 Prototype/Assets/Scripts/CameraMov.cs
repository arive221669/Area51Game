using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMov : MonoBehaviour

{

    public GameObject player;       //Public variable to store a reference to the player game object
    public int movingSpeed = (int)2.5f;

        
    void Update()
    {
        transform.position += Vector3.right * Time.deltaTime * movingSpeed;
        {

        }
    }
}