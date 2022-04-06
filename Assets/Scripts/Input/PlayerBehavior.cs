using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum PlayerState
{
    IDLE,
    HASGUN,
    HASTEAMMATE
}
public class PlayerBehavior : MonoBehaviour
{
    [SerializeField]
    GameObject _gunGameObj;
    [SerializeField]
    GameObject _friendGameObj;

    Vector3 _localPosition;

    bool _hasFriend = false;


    private PlayerState _currentState;

    private Rigidbody _rigdbody;

    // Start is called before the first frame update
    void Start()
    {
        _currentState = PlayerState.IDLE;
        _rigdbody = GetComponent<Rigidbody>();
    }

    private void Awake()
    {
        _localPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse1) && _hasFriend)
            _currentState = PlayerState.HASTEAMMATE;
        else
        {
            _currentState = PlayerState.HASGUN;
            _hasFriend = false;
        }
        switch (_currentState)
        {
            case PlayerState.IDLE:
            {
                    _currentState = PlayerState.HASGUN;
                    break;
            }
            case PlayerState.HASGUN:
                {
                    _friendGameObj.transform.parent = null;
                    _gunGameObj.transform.SetParent(transform);

                    break;
                }
            case PlayerState.HASTEAMMATE:
                {
                    _gunGameObj.transform.parent = null;
                    _friendGameObj.transform.SetParent(transform);
                    break;
                }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("friend"))
        {
            _hasFriend = true;
            _friendGameObj = other.gameObject;
        }

        

        if(other.CompareTag("Enemy"))
            transform.position = _localPosition;

    }
}
