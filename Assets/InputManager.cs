using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private PlayerControls playerControls;
    private Vector2 MovementInput;
    public float VerticalInput;
    public float HorizontalInput;

    // Start is called before the first frame update
    private void OnEnable()
    {
        if (playerControls == null)
        {
            playerControls = new PlayerControls();
            //When we hit WASD, we will record the movement to a variable
            playerControls.PlayerMovement.Movement.performed += i => MovementInput = i.ReadValue<Vector2>();
        }
        playerControls.Enable();
    }

    // Update is called once per frame
    private void OnDisable()
    {
        playerControls.Disable();
    }

    public void HandleAllInput()
    {
        HandleMovementInput();
    }

    private void HandleMovementInput()
    {
        VerticalInput = MovementInput.y;
        HorizontalInput = MovementInput.x;
    }
}
