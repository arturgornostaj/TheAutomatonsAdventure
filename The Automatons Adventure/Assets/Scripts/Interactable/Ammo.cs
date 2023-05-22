using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : Pickable
{
    private void OnTriggerEnter(Collider other)
    {
        Weapons weapons = other.GetComponent<Weapons>();
        weapons.AddAmmo(amount);

        PickupEffect();
        Destroy(gameObject);
    }
}
