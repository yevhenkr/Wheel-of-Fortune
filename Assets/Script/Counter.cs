using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text value;
    
    void Start()
    {
        value = GetComponent<Text>();
    }

    // Update is called once per frame
    public void SetValue(string s)
    {
        var t = Int32.Parse(s) + Int32.Parse(value.text);
        value.text = t.ToString();
        Debug.Log("s = " + value);

    }
}
