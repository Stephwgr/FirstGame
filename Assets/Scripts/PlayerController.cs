using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private Rigidbody _rb;

    public float _speed;
    public float _jumpForce;
    private Vector3 velocity = Vector3.zero;

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void Start()
    {
       _rb = gameObject.GetComponent<Rigidbody>();
    //    _playerInput = GetComponent<PlayerInput>();                  

    }

    void MovePlayer()
    {
        // float h = Input.GetAxis("Horizontal") * _speed;
        // _rb.velocity = new Vector2 (h, _rb.velocity.y);
        // Vector3 movement = new Vector3(h, )

        if(Input.GetKeyDown(KeyCode.Space))
        {
            _rb.AddForce(new Vector3 (0f, _jumpForce, 0f));
        }
    }

}
