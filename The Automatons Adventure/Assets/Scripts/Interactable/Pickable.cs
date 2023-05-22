using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{
    [SerializeField] protected int amount = 1;
    [SerializeField] protected ParticleSystem particle;


    protected void PickupEffect()
    {
        Instantiate(particle, transform.position, Quaternion.identity);
    }


}
