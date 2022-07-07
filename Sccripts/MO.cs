using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MO : MonoBehaviour
{
    private void Start() 
    {
      
    }
    public void ButtonCl1kk()
    {
        System.Random rnd = new System.Random();
        int a = rnd.Next(1,100);
        int b = 0;
        if (a<85){
            b = 7; 
        }
        if (a>85 && a<95){
            b = 10;
        }
        if (a>95){
            b = 9;
        }

        SceneManager.LoadScene(b);
    }
}