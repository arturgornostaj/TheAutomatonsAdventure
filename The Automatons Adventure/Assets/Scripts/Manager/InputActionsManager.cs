using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class InputActionsManager : MonoBehaviour
{
    [SerializeField] GameObject automaton;

    Movement movement;
    Stance stance;

    private void Start()
    {
        stance = automaton.GetComponent<Stance>();
        movement = automaton.GetComponent<Movement>();
    }

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
}
