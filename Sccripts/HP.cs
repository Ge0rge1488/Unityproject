using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour
{
    private void Start() 
    {
      
    }
    public void ButtonCl1kk()
    {
        System.Random rnd = new System.Random();
        int a = rnd.Next(1,100);
        int b = 0;
        if (a<70){
            b = 7;
        }
        else{
            b =11;
        }
        SceneManager.LoadScene(b);
    }
}