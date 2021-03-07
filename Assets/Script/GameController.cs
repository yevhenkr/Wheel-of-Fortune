using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Wheel Wheel;
    public Counter Counter;
    public Save Save;
    public StateWheel StateWheel;
//todo в этом классе старт и стоп должны отрабатывать да
    void Update()
    {
        if (StateWheel == StateWheel.AfterRun)
        {
            Wheel.GetValueDrop(Wheel.GetDropSegment());
            Counter.SetValue(Wheel.ValueDrop.ToString());
            Save.SaveScore(Counter.scoreValue);
            StateWheel = StateWheel.Idle;
        }
    }

    public void GoToMineMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}