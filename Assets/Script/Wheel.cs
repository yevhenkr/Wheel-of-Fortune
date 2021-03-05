using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Wheel : MonoBehaviour
{
    private float _anglePart ;

    public byte CountParts;

    private void Awake()
    {
        _anglePart = 360 / CountParts;
    }

//    public StateWheel = StateWheel.I//todo
    void Update()
    {
//        Debug.Log("transform.eulerAngles.z = " +transform.eulerAngles.z);
        Debug.Log("Math = " + Math.Truncate(transform.eulerAngles.z / _anglePart));
    }
    
    //todo крутится быстро медленно всегда рандом отедльный клас крутящий момент 
    //todo manager связное звено между колесом и выводом на экран значения
    //todo где мы в этом классе getSelectPart
    
}

public enum StateWheel
{
    Idle,
    Run
}