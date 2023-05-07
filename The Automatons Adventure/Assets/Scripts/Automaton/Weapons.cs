using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    [SerializeField] private int _ammo;
    public int ammo
    {
        get { return _ammo; }
        set
        {
            if (value < 0) _ammo = 0;
            else _ammo = value;
        }
    }
}
