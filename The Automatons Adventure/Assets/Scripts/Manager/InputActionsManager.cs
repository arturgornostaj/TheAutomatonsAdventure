using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class InputActionsManager : GameManager
{
    [SerializeField] CameraFocus cameraFocus;

    public void OnChangeStance(InputAction.CallbackContext context)
    {
        if (context.started) stance.ChangeStance(AutomatonStance.Fighting);
        if (context.canceled) stance.ChangeStance(AutomatonStance.Scouting);
    }


    public void OnMovement(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            movement.SetMovementVector(context.ReadValue<Vector2>());
        }
        else movement.SetMovementVector(Vector2.zero);
    }

    public void OnRotateCamera(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            cameraFocus.SetRotationVector(context.ReadValue<Vector2>());
        }
        else cameraFocus.SetRotationVector(Vector2.zero);


    }

    public void OnShot(InputAction.CallbackContext context)
    {
        if(context.performed && stance.CurrentStance() == AutomatonStance.Fighting)
        {
            weapons.Shoot();
        }
    }
}
