using UnityEngine;

public class WheelRotation : MonoBehaviour
{
    public Transform While;
    [SerializeField] private float _maxSpeed, _minSpeed, _timeRotation;
    private float _currentSpeed;
    private float _timeStillAvailable;
    private StateWheel StateWheel;

    private void Start()
    {
        StateWheel = StateWheel.Run;
        FindMaxSpeed();
        _timeStillAvailable = _timeRotation;
    }


    private void Update()
    {
        if (StateWheel == StateWheel.Run)
        {
            _timeStillAvailable -= Time.deltaTime;
            var speedProcent = _timeStillAvailable / _timeRotation;
            RunWheel(_currentSpeed * speedProcent);
            if (_timeStillAvailable < 0)
            {
                StateWheel = StateWheel.Idle;
            }
        }
    }

    private void FindMaxSpeed()
    {
        _currentSpeed = Random.Range(_maxSpeed, _minSpeed);
    }

    private void RunWheel(float speed)
    {
        var z = While.rotation.z;
        While.Rotate(0f, 0f, z += speed);
    }
}