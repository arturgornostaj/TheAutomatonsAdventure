using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucket : MonoBehaviour, IInteractable
{
    
    [SerializeField] int _water = 10;
    [SerializeField] float maxDistToAttachToWell;
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
    
    [SerializeField] Hydration plantHydration;

    Rigidbody bucketRb;
    bool isCarried = false;
    bool isWateringPossible = false;
    bool isAttachedToWell = true;

    private void Start()
    {
        bucketRb = GetComponent<Rigidbody>();
    }

    void AttachToWell()
    {
        if(!isCarried && Vector3.Distance(transform.position, wellPosition.position) < maxDistToAttachToWell) 
        {
            print("Od³o¿ono pod studnie");
            transform.position = wellPosition.position;
            transform.rotation = wellPosition.rotation;
            isAttachedToWell = true;
        }
    }

    public bool IsAttachedToWell() => isAttachedToWell;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Plant") 
        {
            isWateringPossible = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Plant") 
        {
            isWateringPossible = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Terrain" && isWateringPossible)
        {
            plantHydration.Hydrate(water);
            water = 0;
        }
        else if (collision.gameObject.tag == "Terrain" && !isWateringPossible)
        {
            water = 0;
        }

    }

    public void GrabObject(Transform backpackPosition)
    {
        isCarried = true;
        isAttachedToWell = false;
        bucketRb.isKinematic = true;
        transform.position = backpackPosition.position; 
        transform.SetParent(backpackPosition);      
    }

    public void DisposeObject(Transform backpackPosition, Vector3 force)
    {
        isCarried = false;
        backpackPosition.transform.DetachChildren();
        bucketRb.isKinematic = false;
        bucketRb.AddTorque(force);

        AttachToWell();
    }

}
