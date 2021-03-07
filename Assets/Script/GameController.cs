using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Wheel Wheel;
    public WheelRotation WheelRotation;
    public Counter Counter;
    public Save Save;
    public StateWheel StateWheel;

    //todo manager связное звено между колесом и выводом на экран значения
    void Update()
    {
        if (StateWheel == StateWheel.AfterRun)
        {
            Wheel.GetValueDrop(Wheel.GetDropSegment());
            Counter.SetValue(Wheel.valueDrop.ToString());
            Save.SaveScore(Counter.scoreValue);
            StateWheel = StateWheel.Idle;
        }
    }

    public void GoToMineMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}