using UnityEngine;
using UnityEngine.UI;

public class WheelRotation : MonoBehaviour
{
    public Transform While;
    public GameController GameController;
    public Button Button;
    [SerializeField] private float _maxSpeed, _minSpeed, _timeRotation;

    private float _currentSpeed;
    private float _timeStillAvailable;
    private StateWheel _stateWheel;

    private void Start()
    {
        _currentSpeed = Random.Range(_maxSpeed, _minSpeed);
        _timeStillAvailable = _timeRotation;
    }

    private void Update()
    {
        if (GameController.StateWheel == StateWheel.Run)
        {
            RunWheel();
        }
    }

    public void OnStateRotate()
    {
        GameController.StateWheel = StateWheel.Run;
        Button.interactable = false;
    }

    public void RunWheel()
    {
        _timeStillAvailable -= Time.deltaTime;
        bool isAvailableTime = (_timeStillAvailable > 0);
        if (!isAvailableTime)
        {
            _timeStillAvailable = _timeRotation;
            GameController.StateWheel = StateWheel.AfterRun;
            Button.interactable = true;
            return;
        }

        var speedProcent = _timeStillAvailable / _timeRotation;
        RotationWheel(_currentSpeed * speedProcent);
    }

    private void RotationWheel(float speed)
    {
        var z = While.rotation.z;
        if ((z += speed) < 0)
        {
            return;
        }

        While.Rotate(0f, 0f, z += speed);
    }
}