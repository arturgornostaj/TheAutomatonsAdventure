using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : Pickable
{
    private void OnTriggerEnter(Collider other)
    {
        Points score = other.GetComponent<Points>();
        score.AddScore(amount);

        PickupEffect();
        Destroy(gameObject);
    }

}
