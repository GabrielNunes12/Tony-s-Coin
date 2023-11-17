using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private int _playerSpeed = 2;
    [SerializeField] private GameObject _playerGameObject;
    [SerializeField] private int _playerJumpForce = 5;
    [SerializeField] private Rigidbody _playerRb;
    [SerializeField] private int _maxJump = 2;
    [SerializeField] private float _jumpCooldownSec = 0f;
    private int actualJump = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            _playerGameObject.gameObject.transform.position += new Vector3(_playerSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            _playerGameObject.gameObject.transform.position += new Vector3(-_playerSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            actualJump++;
            if (actualJump <= _maxJump && _jumpCooldownSec <= 3.0f)
            {
                _playerRb.AddForce(new Vector3(0, _playerJumpForce), ForceMode.Impulse);
            }
        }
        jumpCooldown();
    }

    private void jumpCooldown()
    {
        _jumpCooldownSec += Time.deltaTime;
        if (_jumpCooldownSec >= 3.0f)
        {
            actualJump = 0;
            _jumpCooldownSec = 0f;
        }
    }
}
