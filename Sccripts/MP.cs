using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MP : MonoBehaviour
{
    public void Start() 
    {
      
    }
    public void ButtonCl1k()
    {
        System.Random rnd = new System.Random();
        int a = rnd.Next(1,100);
        int b = 0;
        if (a<30){
            b = 7; 
        }
        if (a>20 && a<70){
            b = 10;
        }
        if (a>70){
            b = 9;
        }

        SceneManager.LoadScene(b);
    }
}
