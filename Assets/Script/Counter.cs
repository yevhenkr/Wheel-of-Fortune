using System;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;
    private int scoreValue;
    public int ScoreValue
    {
        get { return scoreValue; }
    }

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
            if (5)
            {
                int r = 0;
            }
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