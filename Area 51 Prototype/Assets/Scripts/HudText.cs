using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudText : MonoBehaviour
{
    public static int scoreValue = 1;
    Text score;

    void Start()
    {
        score = GetComponent<Text> ();
    }

    void Update()
    {
        score.text = "Credits: " + scoreValue;
        //PlayerPrefs.SetInt("Player GPA", scoreValue);
    }
}
