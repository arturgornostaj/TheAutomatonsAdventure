using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void Start()
    { 
        Destroy(gameObject, 3);
    }

    private void OnCollisionEnter(Collision collision)
    {
        print(this + "Pocisk trafi³ w " + collision.collider.name);
        Destroy(gameObject);
    }

}
