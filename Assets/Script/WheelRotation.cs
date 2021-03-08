using UnityEngine;
using UnityEngine.UI;

public class WheelRotation : MonoBehaviour
{
    [SerializeField]
    private Transform While;
    [SerializeField]
    private GameController GameController;
    [SerializeField] private float _maxSpeed, _minSpeed, _timeRotation;
    private float _currentSpeed;
    private float _timeStillAvailable;

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

  
    public void RunWheel()
    {
        _timeStillAvailable -= Time.deltaTime;
        bool isAvailableTime = (_timeStillAvailable > 0);
        if (!isAvailableTime)
        {
            _timeStillAvailable = _timeRotation;
            GameController.StopSpine();
            //
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