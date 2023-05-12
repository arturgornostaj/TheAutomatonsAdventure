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
    [SerializeField] float shootRange = 50;

    [SerializeField] float dispersionRange;
    [SerializeField] GameObject laser;
    [SerializeField] Light light;
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
            Vector3 currentDispersion = new Vector3(Random.Range(-dispersionRange, dispersionRange), Random.Range(-dispersionRange, dispersionRange), 0);
            firedBullet.GetComponent<Rigidbody>().AddRelativeForce((barrel.transform.forward * shootRange) + currentDispersion, ForceMode.Impulse);
            print(this + "Wystrzelono pocisk, zosta³o pocisków: " + ammo);
        }
        
    }

    public void ChangeAmmoAmount(int amount)
    {
        ammo = amount;
        onAmmoChange.Invoke();
    }

    public void EnableLaser()
    {
        laser.SetActive(true);
        light.color = Color.red;
    }

    public void DisableLaser()
    {
        laser.SetActive(false);
        light.color = Color.white;
    }
}
