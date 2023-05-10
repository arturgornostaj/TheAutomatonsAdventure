using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Weapons : MonoBehaviour
{
    [SerializeField] private int _ammo;
    [SerializeField] UnityEvent onShot, onAmmoChange;

    [SerializeField] Transform barrel;
    [SerializeField] GameObject bullet;

    [SerializeField] Vector3 offsetToEndOfBarrel;
    public int ammo
    {
        get { return _ammo; }
        set
        {
            if (value < 0) _ammo = 0;
            else _ammo = value;
        }
    }

    public void Shoot()
    {
        if(ammo > 0)
        {
            ammo--;
            onShot.Invoke();
            GameObject firedBullet =  Instantiate(bullet, barrel.position, Quaternion.identity);
            firedBullet.GetComponent<Rigidbody>().AddRelativeForce(barrel.transform.forward * 50, ForceMode.Impulse);
            print(this + "Wystrzelono pocisk, zosta³o pocisków: " + ammo);
        }
        
    }

    public void ChangeAmmoAmount(int amount)
    {
        ammo = amount;
        onAmmoChange.Invoke();
    }
}
