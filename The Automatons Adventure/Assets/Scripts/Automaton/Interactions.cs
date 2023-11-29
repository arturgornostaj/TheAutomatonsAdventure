using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions : MonoBehaviour
{

    [SerializeField] GameObject interactable;
    [SerializeField] Transform interactionPosition;
    [SerializeField] float rangeToInteract = .7f;

    Rigidbody bucketRb;
    bool isCarringObject = false;
    float distanceToInteractable;

    public void StartSearching()
    {
        print(this + " Przeszukuje");

        distanceToInteractable = Vector3.Distance(interactable.transform.position, transform.position);
        if((distanceToInteractable < rangeToInteract) && !isCarringObject)
        {
            print("Podnoszê wiaderko");
            isCarringObject = true;

            bucketRb = interactable.GetComponent<Rigidbody>();
            bucketRb.isKinematic = true;
            interactable.transform.position = Vector3.Lerp(interactable.transform.position, interactionPosition.position, 1f);
            interactable.transform.SetParent(interactionPosition);
            
        } else if(isCarringObject)
        {
            print("Odrzucam wiaderko");
            isCarringObject = false;

            interactionPosition.transform.DetachChildren();
            bucketRb.isKinematic= false;

        }


    }

}
