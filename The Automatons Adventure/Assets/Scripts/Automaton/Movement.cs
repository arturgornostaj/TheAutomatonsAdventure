using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour, IStanceUpdate
{
    CharacterController automaton;

    [SerializeField] float turnSpeed = .5f;
    float currentTurnSpeed;
    [SerializeField] float movementSpeed = 5;
    float currentMovementSpeed;

    Vector2 movementVector;

    private void Start()
    {
        automaton = GetComponent<CharacterController>();
    }

    private void Update()
    {
        AutomatonMove();
        AutomatonRotate();
    }

    void AutomatonMove()
    {
        automaton.SimpleMove(transform.TransformDirection(Vector3.forward) * currentMovementSpeed * movementVector.y);
    }

    void AutomatonRotate()
    {
        transform.Rotate(0, movementVector.x * currentTurnSpeed, 0);
    }

    public void SetMovementVector(Vector2 vector)
    {
        movementVector = vector;
    }

    public void OnScoutingEnter()
    {
        currentMovementSpeed = movementSpeed;
        currentTurnSpeed = turnSpeed;
    }

    public void OnFightingEnter()
    {
        currentMovementSpeed = movementSpeed / 3;
        currentTurnSpeed = turnSpeed/2;
    }

    public void OnSearchingEnter()
    {
        currentMovementSpeed = movementSpeed;
        currentTurnSpeed = turnSpeed;
    }
}
