using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class PlayerController : MonoBehaviour
{
    private float _horizontal;
    private float _vertical;
    [SerializeField] private Rigidbody myRBD;
    [SerializeField] private float velocityModifier = 5f;
    [SerializeField] private AudioSource walkingEffect;

    public void OnMovement(InputAction.CallbackContext move)
    {
        _horizontal = move.ReadValue<Vector2>().x;
        _vertical = move.ReadValue<Vector2>().y;
  
    }
    public void Interact(InputAction.CallbackContext interact)
    {

    }
    public void FixedUpdate()
    {
        myRBD.velocity = new Vector3(_horizontal * velocityModifier, myRBD.velocity.y, _vertical * velocityModifier);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Walk();
            
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Walk();
           
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
           
            Walk();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            Walk();
           
        }
    }
    private void Walk()
    {
        walkingEffect.Play();
    }
    

}
