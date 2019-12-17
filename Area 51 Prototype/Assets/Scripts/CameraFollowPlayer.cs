﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{

  private Transform playerTransform;
  public float offset;


    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update(){
      
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 temp = transform.position;

        temp.x = playerTransform.position.x;

        temp.x += offset;

        transform.position = temp;
    }
}
