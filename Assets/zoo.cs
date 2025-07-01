using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class zoo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animal tom = new animal();
        tom.name = "돔";
        tom.sound = "냐옹!";
    
        animal jerry = new animal();
        jerry.name = "제리";
        jerry.sound = "찍찍!";
        
        jerry.name = "미키";
        
        tom.PlaySound();
        jerry.PlaySound();
    }
}
