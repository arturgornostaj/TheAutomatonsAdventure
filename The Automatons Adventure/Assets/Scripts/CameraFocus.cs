using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFocus : MonoBehaviour
{
    [SerializeField] Transform automatonPosition;
    [SerializeField] float followSpeed = 1;


    private void Update()
    {
        FollowPlayer();
    }

    void FollowPlayer()
    {
        transform.position = Vector3.Lerp(transform.position, automatonPosition.position, followSpeed * Time.deltaTime);
    }
}
