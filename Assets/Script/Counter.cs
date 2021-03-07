using System;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text scoreText;
    public int scoreValue;

    public void SetValue(int dropValue)
    {
        scoreValue += dropValue;
        scoreText.text = ScoreToFormat(scoreValue);
    }

    public string ScoreToFormat(float score)
    {
        if (score >= 1000 && score < 1000000)
        {
            var k = score / 1000;
            return (k).ToString("0") + "K";
        }
        else if (score >= 1000000)
        {
            var m = score / 1000000;
            return (m).ToString("0.00") + "M";
        }
        else
            return score.ToString();
    }
}