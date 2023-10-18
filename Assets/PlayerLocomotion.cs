using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerLocomotion : MonoBehaviour
{
    private Vector3 PlayerDirection;
    private Transform CameraObject;

    private void Awake()
    {
        CameraObject = Camera.main.transform;
    }

    public void HandleAllMovement()
    {
        //private methods
        HandleMovement();
        HandleRotation();
    }

    public void HandleMovement()
    {
        PlayerDirection = CameraObject.forward * PlayerManager.Instance.inputManager.VerticalInput;
        PlayerDirection = PlayerDirection + CameraObject.right * PlayerManager.Instance.inputManager.HorizontalInput;
        PlayerDirection.Normalize();
        PlayerDirection.y = 0;

        if (PlayerManager.Instance.PlayerIsSprinting)
        {
            PlayerDirection *= PlayerManager.Instance.MovementSpeed;
        }
        else
        {

        }
        Vector3 MovementVelocity = PlayerDirection;
        PlayerManager.Instance.RigidBody.velocity = MovementVelocity;
    }
    private void HandleRotation()
    {
        Vector3 TargetDirection = Vector3.zero;
        TargetDirection = CameraObject.forward * PlayerManager.Instance.inputManager.VerticalInput;
        TargetDirection = PlayerDirection + CameraObject.right * PlayerManager.Instance.inputManager.HorizontalInput;
        TargetDirection.Normalize();
        TargetDirection.y = 0;

        //Line that makes the rotation same as direction
        if (TargetDirection == Vector3.zero)
        {
            TargetDirection = transform.forward;
        }

        Quaternion TargetRotation = Quaternion.LookRotation(TargetDirection);
        Quaternion PlayerRotation = Quaternion.Slerp(transform.rotation, TargetRotation, PlayerManager.Instance.RotationSpeed);

        transform.rotation = PlayerRotation;
    }
}
