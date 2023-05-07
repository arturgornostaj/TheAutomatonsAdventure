using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condition : MonoBehaviour
{
    [SerializeField] private int _hp;
    public int hp
    {
        get { return _hp; }
        set
        {
            if (value < 0) _hp = 0;
            else _hp = value;
        }
    }

}
