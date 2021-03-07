﻿using System;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class Wheel : MonoBehaviour
{
    public Text[] SegmentText;
    public int valueDrop;
    public byte CountSegment;

    private float _angleSegment;
    private int[] unicNumbers;

    [SerializeField] private int minValue, maxValue, offSetRandomValue;

    private void Awake()
    {
        _angleSegment = 22.5f; // 360 / CountSegment;//todo 360 / CountSegment
        unicNumbers = new int[SegmentText.Length];
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

        for (int i = 0; i < SegmentText.Length; i++)
        {
            SegmentText[i].text = unicNumbers[i].ToString();
        }
    }

    public int GetRandomNumbers()
    {
        return Random.Range(minValue, maxValue) * offSetRandomValue;
    }
}

public enum StateWheel
{
    Idle,
    Run,
    AfterRun
}