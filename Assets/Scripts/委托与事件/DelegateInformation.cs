using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateInformation : MonoBehaviour
{
    public delegate void myDelegate();
    public event myDelegate Inform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            BeginInform();
        }
    }

    void BeginInform()
    {
        if (Inform != null)
        {
            Inform();
        }
    }
}
