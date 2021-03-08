using System;
using UnityEngine;
using UnityEngine.UI;

public class Save : MonoBehaviour
{
    [SerializeField]
    private Text LastScore;
    private String _keyToScore = "LastScore";
    private float _score;

    private void Start()
    {
        if (PlayerPrefs.HasKey(_keyToScore))
        {
            LastScore.text = ShowLastScore();
        }
    }

    public void SaveScore(int score)
    {
        PlayerPrefs.SetFloat(_keyToScore, score);
    }

    private float GetLastScore()
    {
        return (_score = PlayerPrefs.GetFloat(_keyToScore));
    }

    private string ShowLastScore()
    {
        _score = GetLastScore();
        if (_score >= 1000 && _score < 1000000)
        {
            var k = _score / 1000;
            return (k).ToString("0") + "K";
        }
        else if (_score >= 1000000)
        {
            var m = _score / 1000000;
            return (m).ToString("0.00") + "M";
        }
        else
            return _score.ToString();
    }
}