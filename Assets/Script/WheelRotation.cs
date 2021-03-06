using UnityEngine;

public class WheelRotation : MonoBehaviour
{
    public Transform While;//todo как записать в GameController 
    public GameController GameController;
    [SerializeField] 
    private float _maxSpeed, _minSpeed, _timeRotation;
    
    private float _currentSpeed;
    private float _timeStillAvailable;
    private StateWheel StateWheel;

    private void Start()
    {
//        GameController.StateWheel = StateWheel.Run;
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
    }

    public void RunWheel()
    {
//        if (GameController.StateWheel == StateWheel.Run)
//        {
            _timeStillAvailable -= Time.deltaTime;
            var speedProcent = _timeStillAvailable / _timeRotation;
            RotationWheel(_currentSpeed * speedProcent);
            if (_timeStillAvailable < 0)
            {
                _timeStillAvailable = _timeRotation;
                GameController.StateWheel = StateWheel.AfterRun;
            }
//        }
    }
    private void RotationWheel(float speed)
    {
        var z = While.rotation.z;
        While.Rotate(0f, 0f, z += speed);
    }
    
    
}