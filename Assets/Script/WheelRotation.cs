using UnityEngine;

public class WheelRotation : MonoBehaviour
{
    public Transform While;//todo как записать в GameController 
    
    [SerializeField] 
    private float _maxSpeed, _minSpeed, _timeRotation;
    
    private float _currentSpeed;
    private float _timeStillAvailable;
    private StateWheel StateWheel;

    private void Start()
    {
        StateWheel = StateWheel.Run;
        _currentSpeed = Random.Range(_maxSpeed, _minSpeed);
        _timeStillAvailable = _timeRotation;
    }



    public void RunWheel()
    {
        if (StateWheel == StateWheel.Run)
        {
            _timeStillAvailable -= Time.deltaTime;
            var speedProcent = _timeStillAvailable / _timeRotation;
            RotationWheel(_currentSpeed * speedProcent);
            if (_timeStillAvailable < 0)
            {
                StateWheel = StateWheel.Idle;
                _timeStillAvailable = _timeRotation;
            }
        }
    }
    private void RotationWheel(float speed)
    {
        var z = While.rotation.z;
        While.Rotate(0f, 0f, z += speed);
    }
    
    
}