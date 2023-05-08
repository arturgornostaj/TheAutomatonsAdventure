using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFocus : MonoBehaviour
{
    [SerializeField] Transform automatonPosition;
    [SerializeField] float followSpeed = 1;
    [SerializeField] float turnSpeed = 1;

    Vector2 rotateVector;


    private void Update()
    {
        FollowPlayer();
        RotateCamera();
    }

    void FollowPlayer()
    {
        transform.position = Vector3.Lerp(transform.position, automatonPosition.position, followSpeed * Time.deltaTime);
    }

    void RotateCamera()
    {
        transform.Rotate(0, rotateVector.x * turnSpeed, 0);
    }

    public void SetRotationVector(Vector2 vector)
    {
        rotateVector = vector;
    }


}
