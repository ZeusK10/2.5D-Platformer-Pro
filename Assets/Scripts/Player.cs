using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController _controller;
    [SerializeField]
    private float _speed = 5.0f;
    [SerializeField]
    private float _gravity = 1.0f;
    [SerializeField]
    private float _jumpHeight = 15.0f;
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 move = new Vector3(horizontalInput, 0, 0);
        Vector3 velocity = move * _speed;
        if(_controller.isGrounded)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                velocity.y += _jumpHeight;
            }
            
        }
        else
        {
            velocity.y -= _gravity;
        }
        _controller.Move(velocity * Time.deltaTime);
       
    }
}
