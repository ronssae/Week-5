using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private PlayerControls playerControls;
    private Vector2 MovementInput;
    public float VerticalInput;
    public float HorizontalInput;

    public float MovementAmount;
    public bool Sprint_Input;

    // Start is called before the first frame update
    private void OnEnable()
    {
        if (playerControls == null)
        {
            playerControls = new PlayerControls();
            //When we hit WASD, we will record the movement to a variable
            playerControls.PlayerMovement.Movement.performed += i => MovementInput = i.ReadValue<Vector2>();
            playerControls.PlayerActions.Sprint.performed += i => Sprint_Input = true;
            playerControls.PlayerActions.Sprint.performed += i => Sprint_Input = false;
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
        HandleSprinting();
    }

    private void HandleMovementInput()
    {
        VerticalInput = MovementInput.y;
        HorizontalInput = MovementInput.x;

        MovementAmount = Mathf.Clamp01(Mathf.Abs(HorizontalInput + VerticalInput));
        PlayerManager.Instance.PlayerAnim.UpdateAnimatorValues(0, MovementAmount);
    }

    public void HandleSprinting()
    {
        if (Sprint_Input && MovementAmount > 0.5)
        {
            PlayerManager.Instance.PlayerIsSprinting = true;
        }
        else
        {

        }
    }
}
