using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    public GameObject obg;
    public void Start(){
        System.Random rnd = new System.Random();
        int a = rnd.Next(-54,157);
        int b = rnd.Next(-37,50);
        obg.GetComponent<Transform>().position = new Vector2(a,b);
    }
    
}
