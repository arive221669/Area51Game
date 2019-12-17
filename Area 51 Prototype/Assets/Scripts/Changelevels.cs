using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Changelevels : MonoBehaviour

{

  public void update(){
    Debug.Log("potatoes");

  }

  public void OnMouseDown()
  {

    Debug.Log("cherries");
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

  }

  public void QuitGame(){

    Application.Quit();

  }

}
