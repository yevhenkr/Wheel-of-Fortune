using System;
using UnityEngine;
using UnityEngine.UI;

public class Save : MonoBehaviour
{
    public Text LastScore;
    private String keyToScore = "LastScore";
    private float score;

    private void Start()
    {
        if (PlayerPrefs.HasKey(keyToScore))
        {
            LastScore.text = ShowLastScore();
        }
    }

    public void SaveScore(int score)
    {
        PlayerPrefs.SetFloat(keyToScore, score);
    }

    private float GetLastScore()
    {
        return (score = PlayerPrefs.GetFloat(keyToScore));
    }

    private string ShowLastScore()
    {
        score = GetLastScore();
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