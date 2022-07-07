using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RS : MonoBehaviour
{
    private void Start() 
    {
      
    }
    public void ButtonClock()
    {
        System.Random rnd = new System.Random();
        int a = rnd.Next(1,100);
        int b = 0;
        if (a>90 && a<98){
            b = 8;
        }
        if (a<90){
            b = 7; 
        }
        if(a>98){
            b = 9;
        }
        SceneManager.LoadScene(b);
    }
}
