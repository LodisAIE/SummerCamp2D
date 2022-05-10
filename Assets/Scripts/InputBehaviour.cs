using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputBehaviour : MonoBehaviour
{
    private PlayerMovementBehaviour _playerMovement;
    [SerializeField]
    private int _playerNum;

    // Start is called before the first frame update
    void Start()
    {
        _playerMovement = GetComponent<PlayerMovementBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_playerNum == 1)
        {
            _playerMovement.SetMoveDirection(new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0));
            if (Input.GetKeyDown(KeyCode.W))
                _playerMovement.Jump();

        }
        else if (_playerNum == 2)
        {
            _playerMovement.SetMoveDirection(new Vector3(Input.GetAxisRaw("Horizontal2"), 0, 0));
            if (Input.GetKeyDown(KeyCode.UpArrow))
                _playerMovement.Jump();
        }

    }
}
