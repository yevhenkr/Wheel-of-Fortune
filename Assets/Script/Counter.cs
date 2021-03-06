using System;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text score;

    void Start()
    {
        score = GetComponent<Text>();
    }

    public void SetValue(string dropValue)
    {
        var t = Int32.Parse(dropValue) + Int32.Parse(score.text);
        score.text = ScoreReduse(t);
    }

    public string ScoreReduse(int score)
    {
        if (score >= 1000 && score < 1000000)
        {
            return (score / 1000).ToString("0.00") + "K";
        }
        else if (score >= 1000000)
            return (score / 1000000).ToString("0.00") + "M";
        else
            return score.ToString();
    }
}