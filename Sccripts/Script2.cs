using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script2 : MonoBehaviour
{
    private void Start() 
    {
      
    }
    public void ButtonClick()
    {
        System.Random rnd = new System.Random();
        int a = rnd.Next(1,11);
        int b = 0;
        if (a <5){
            b = 5;
        }
        if (a>8){
            b = 6;
        }
        if (a>5 && a<8){
            b = 3;
        }
        if (a == 5){
            b = 4;
        }
        SceneManager.LoadScene(b);
    }
}
