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
       WheelRotation.RunWheel();
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