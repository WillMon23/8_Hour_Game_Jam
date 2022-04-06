using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerImputBehavior : MonoBehaviour
{
    private PlayerMovementBehavior _playerMovement;

    // Start is called before the first frame update
    void Awake()
    {
        _playerMovement = GetComponent<PlayerMovementBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        _playerMovement.XDirection = -(Input.GetAxisRaw("Vertical"));
        _playerMovement.YDirection = new Vector2(0, Input.GetAxisRaw("Horizontal"));
        _playerMovement.Jump = Input.GetKeyDown(KeyCode.Space);
        
    }
}
