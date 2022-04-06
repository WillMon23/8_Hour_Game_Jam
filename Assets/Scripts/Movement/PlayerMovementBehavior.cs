using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehavior : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    private Rigidbody _rigidbody;
    private float _xDirection;
    private Vector2 _rotationDirection;
    private bool _jump = false;
    [SerializeField]
    private float _rotationSpeedY;
    [SerializeField]
    private float _hieght;


    public float XDirection { get { return _xDirection; } set { _xDirection = value; } }

    public Vector2 YDirection { get { return _rotationDirection; } set { _rotationDirection = value; } }

    public bool Jump { get { return _jump; } set { _jump = value; } }

    // Start is called before the first frame update
    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Vector3 velocity =  transform.forward * XDirection * _speed * Time.fixedDeltaTime;

        _rigidbody.position = transform.position + velocity;

        _rigidbody.transform.Rotate(YDirection * _rotationSpeedY * Time.deltaTime);


        if (Jump && transform.position.y <= 1)
            _rigidbody.AddForce(new Vector3(0, _hieght, 0), ForceMode.Impulse);
        
    }
}
