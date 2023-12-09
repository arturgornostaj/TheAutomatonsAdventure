using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hydration : MonoBehaviour
{

    [SerializeField] int _hydration = 1;

    public int hydration
     {
        get { return _hydration; }
        set
        {
            if (value < 0) _hydration = 0;
            else _hydration = value;
        }
    }

    public void Hydrate(int waterAmount)
    {
        hydration += waterAmount;
    }

}
