using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class animal : MonoBehaviour
{
    public string animalName;
    public string sound;

    public void PlaySound()
    {
        Debug.Log(animalName + " : " + sound);
    }
}
