using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    CharacterController automaton;

    [SerializeField] float turnSpeed = 10;
    [SerializeField] float movementSpeed = 10;

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
        automaton.SimpleMove(transform.TransformDirection(Vector3.forward) * movementSpeed * movementVector.y);
    }

    void AutomatonRotate()
    {
        transform.Rotate(0, movementVector.x * turnSpeed, 0);
    }

    public void SetMovementVector(Vector2 vector)
    {
        movementVector = vector;
    }





}
