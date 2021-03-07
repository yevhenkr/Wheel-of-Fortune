using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Wheel Wheel;
    public WheelRotation WheelRotation;
    public Counter Counter;
    public StateWheel StateWheel;
    
    //todo manager связное звено между колесом и выводом на экран значения
    void Update()
    {
        if (StateWheel == StateWheel.AfterRun)
        {
            Wheel.GetValueDrop( Wheel.GetDropSegment());
            Counter.SetValue(Wheel.valueDrop.ToString());  
            StateWheel = StateWheel.Idle;
        }
    }
    
    
}
