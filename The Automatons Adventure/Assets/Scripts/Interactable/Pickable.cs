using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{
    [SerializeField] PicableType type;
    [SerializeField] int quantity = 1;

    [SerializeField] GameObject scorePrefab;
    [SerializeField] GameObject medsPrefab;
    [SerializeField] GameObject ammoPrefab;


    private void Start()
    {
        Initialize();
    }

    void Initialize()
    {
        GameObject picable;

        switch (type)
        {
            case PicableType.score:
                picable = scorePrefab;
                break;

            case PicableType.meds:
                picable = medsPrefab;
                break;

            case PicableType.ammo:
                picable = ammoPrefab;
                break;

            default: picable = scorePrefab;              
                break;
        }

        GameObject instantiatedPicable = Instantiate(picable, transform.position, Quaternion.identity);
        instantiatedPicable.transform.SetParent(transform);

    }

    private void OnTriggerEnter(Collider other)
    {
        switch (type)
        {
            case PicableType.score:
                print(this + " Nie dodano efektu");
                break;
            case PicableType.meds:
                Condition condition = other.GetComponent<Condition>();
                condition.RestoreHp(quantity);
                break;
            case PicableType.ammo:
                Weapons weapons = other.GetComponent<Weapons>();
                weapons.AddAmmo(quantity);
                break;
            default:
                break;
        }

        Destroy(gameObject);
    }

}


public enum PicableType
{
    score,
    meds,
    ammo,
}
