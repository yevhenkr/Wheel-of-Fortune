using System;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class Wheel : MonoBehaviour
{
    public Text[] SegmentText;
    public int ValueDrop
    {
        get { return valueDrop; }
    }
    
    
    private int valueDrop;
    [SerializeField] private byte _countSegment;
    [SerializeField] private int _minValue, _maxValue, _offSetRandomValue;

    private float _angleSegment;
    private int[] _unicNumbers;
    private float _circleDegrees = 360;

    private void Awake()
    {
        _angleSegment =  _circleDegrees / _countSegment;
        _unicNumbers = new int[SegmentText.Length];
        GenerateNumbersOnWheel();
    }

    public void GetValueDrop(int part)
    {
        if (part <= SegmentText.Length)
        {
            valueDrop = Int32.Parse(SegmentText[part].text);
        }
    }

    public int GetDropSegment()
    {
        var t = (int) Math.Truncate(transform.eulerAngles.z / _angleSegment);
        return t;
    }

    public void GenerateNumbersOnWheel()
    {
        for (int i = 0; i < _unicNumbers.Length; i++)
        {
            _unicNumbers[i] = GetRandomNumbers();
        }

        for (int i = 0; i < _unicNumbers.Length; i++)
        {
            foreach (var VARIABLE in _unicNumbers)
            {
                if (_unicNumbers[i] == VARIABLE)
                {
                    _unicNumbers[i] = GetRandomNumbers();
                }
            }
        }

        for (int i = 0; i < SegmentText.Length; i++)
        {
            SegmentText[i].text = _unicNumbers[i].ToString();
        }
    }

    public int GetRandomNumbers()
    {
        return Random.Range(_minValue, _maxValue) * _offSetRandomValue;
    }
}

public enum StateWheel
{
    Idle,
    Run,
    AfterRun
}