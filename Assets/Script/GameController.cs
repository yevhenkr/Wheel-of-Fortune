﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Wheel Wheel;
    public WheelRotation WheelRotation;
    
    
    
    //todo manager связное звено между колесом и выводом на экран значения

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        WheelRotation.RunWheel();
    }
}
