using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Helth : MonoBehaviour
{
    public Image bar;
    public float fill;
    void Awake()
    {
        fill = 1f;
    }
    void Update()
    {
       bar.fillAmount = fill; 
    }
}