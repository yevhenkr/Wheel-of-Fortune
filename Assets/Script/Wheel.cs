using System;
using UnityEngine;


public class Wheel : MonoBehaviour
{
    public WheelRotation WheelRotation;
    
    private float _anglePart ;

    public byte CountParts;

    private void Awake()
    {
    StateWheel StateWheel = StateWheel.Run;
    _anglePart = 360 / CountParts;
    WheelRotation = GetComponent<WheelRotation>();
    }

    void Update()
    {
    }
    
    public int GetSelectPart()
    {
       return (int)Math.Truncate(transform.eulerAngles.z / _anglePart);
    }
}

public enum StateWheel
{
    Idle,
    Run
}