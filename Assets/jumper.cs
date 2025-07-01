using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class jumper : MonoBehaviour
{
    
    [SerializeField]
    private Rigidbody myRigidbody;

    
    void Start()
    {
       //myRigidbody = GetComponent<Rigidbody>();
       myRigidbody.AddForce(0, 500, 0);
    }
}
