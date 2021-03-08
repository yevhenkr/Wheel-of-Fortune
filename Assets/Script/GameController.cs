using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] 
    public Wheel Wheel;
    [SerializeField] 
    public Counter Counter;
    [SerializeField] 
    public Save Save;
    [SerializeField] 
    public Button Button;
    
    public StateWheel StateWheel;

    public void OnStateRotate()
    {
        StateWheel = StateWheel.Run;
        Button.interactable = false;
    }

    public void StopSpine()
    {
        Wheel.GetValueDrop(Wheel.GetDropSegment());
        Counter.SetValue(Wheel.ValueDrop);
        Save.SaveScore(Counter.ScoreValue);
        Button.interactable = true;
        StateWheel = StateWheel.Idle;
    }
    
    public void GoToMineMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}