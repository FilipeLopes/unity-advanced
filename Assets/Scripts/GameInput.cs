using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class GameInput : MonoBehaviour
{
    //This is an event that needs to be listened from another class. In this case, player is listening.
    public event EventHandler OnInteractAction;
    
    private PlayerInputActions playerInputActions;

    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();

        //Works with the button of interaction (E in this case). It calls the Interact_performed function
        playerInputActions.Player.Interact.performed += Interact_performed;
    }

    //function that returns what was interacted with
    private void Interact_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        //It's a way to use if. In this case Invoke will be called only when OnInteractAction is different of null.
        OnInteractAction?.Invoke(this, EventArgs.Empty);
    }

    public Vector2 GetMovementVectorNormalized()
    {
        Vector2 inputVector = playerInputActions.Player.Move.ReadValue<Vector2>();

        inputVector = inputVector.normalized;
        return inputVector;
    }
}
