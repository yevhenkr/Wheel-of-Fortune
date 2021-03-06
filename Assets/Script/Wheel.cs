using System;
using UnityEngine;
using UnityEngine.UI;


public class Wheel : MonoBehaviour
{
    public WheelRotation WheelRotation;
    public Text[] partText;
    public int valueDrop;
    private float _anglePart;

    public byte CountParts;

    private void Awake()
    {
        _anglePart = 360 / CountParts;
        WheelRotation = GetComponent<WheelRotation>();
    }

    public void GetValueDrop(int part)
    {
        if (part <= partText.Length)
        {
            if (Int32.Parse(partText[part].text) != null)
            {
                valueDrop = Int32.Parse(partText[part].text);
            }
        }
    }

    public int GetDropPart()
    {
        var t = (int) Math.Truncate(transform.eulerAngles.z / _anglePart);
        return t;
    }
}

public enum StateWheel
{
    Idle,
    Run,
    AfterRun
}