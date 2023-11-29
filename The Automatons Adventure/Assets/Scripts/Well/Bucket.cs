using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucket : MonoBehaviour
{
    [SerializeField] int _water = 10;
    public int water
    {
        get { return _water; }
        set
        {
            if (value < 0) _water = 0;
            else _water = value;
        }
    }

    [SerializeField] Transform wellPosition;

    Rigidbody bucketRb;

    private void Start()
    {
        bucketRb = GetComponent<Rigidbody>();
    }


    public void AddWater(int water)
    {

    }

    public void RemoveWater(int water)
    {

    }
}
