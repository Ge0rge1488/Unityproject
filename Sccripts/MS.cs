using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MS : MonoBehaviour
{
    public void Start() 
    {
      
    }
    public void ButtonCl1ck()
    {
        System.Random rnd = new System.Random();
        int a = rnd.Next(1,100);
        int b = 0;
        if (a>1 && a<10){
            b = 9;
        }
        if (a>10 && a<60){
            b = 7; 
        }
        if(a>60){
            b = 10;
        }
        SceneManager.LoadScene(b);
    }
}
