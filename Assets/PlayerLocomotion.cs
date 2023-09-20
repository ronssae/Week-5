using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocomotion : MonoBehaviour
{
    private InputManager inputManager;
    private Vector3 PlayerDirection;
    private Rigidbody PlayerRigidBody;
    private Transform CameraObject;

    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        PlayerRigidBody = GetComponent<Rigidbody>();
        CameraObject = Camera.main.transform;
    }

    public void HandleAllMovement()
    {
        //private methods
        HandleMovement();
        HandleRotation();
    }

    private void HandleMovement()
    {

    }
    private void HandleRotation()
    {

    }
}
