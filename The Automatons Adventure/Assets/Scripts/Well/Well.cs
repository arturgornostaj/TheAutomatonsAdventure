using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Well : MonoBehaviour
{

    [SerializeField] int waterDailyIncreaseRange = 3;
    [SerializeField] Bucket bucket;

    public void FillBucket()
    {
        if(bucket.IsAttachedToWell())
        {
            bucket.water += 1 + Random.Range(0, 0 + waterDailyIncreaseRange);
            print("W wiaderku jest " + bucket.water + " wody");
        }
            
        
    }
}
