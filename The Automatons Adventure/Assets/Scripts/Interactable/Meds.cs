using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meds : Pickable
{
    
    private void OnTriggerEnter(Collider other)
    {
        Condition condition = other.GetComponent<Condition>();
        condition.RestoreHp(amount);

        PickupEffect();
        Destroy(gameObject);
    }
}
