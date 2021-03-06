using System;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class Wheel : MonoBehaviour
{
    public Text[] partText;
    private int[] unicNumbers;
    public int valueDrop;
    private float _anglePart;
    public byte CountParts;

    [SerializeField] 
    private byte minValue, maxValue;

    private void Awake()
    {
        _anglePart = 22.5f;// 360 / CountParts;//todo 360 / CountParts
        unicNumbers = new int[partText.Length];
        GenarateNumbersOnWheel();
    }

    public void GetValueDrop(int part)//eee
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

    public void GenarateNumbersOnWheel()
    {
        for (int i = 0; i < unicNumbers.Length; i++)
        {
            unicNumbers[i] = GetRandomNumbers();
        }

        for (int i = 0; i < unicNumbers.Length; i++)
        {
            foreach (var VARIABLE in unicNumbers)
            {
                if (unicNumbers[i] == VARIABLE)
                {
                    unicNumbers[i] = GetRandomNumbers();
                }
            }
        }

        for (int i = 0; i < partText.Length; i++)
        {
            partText[i].text = unicNumbers[i].ToString();
        }
    }

    public int GetRandomNumbers()
    {
       return Random.Range(minValue, maxValue) * 1000;
    }
}

public enum StateWheel
{
    Idle,
    Run,
    AfterRun
}