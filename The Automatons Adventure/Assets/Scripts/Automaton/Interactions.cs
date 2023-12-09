using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions : MonoBehaviour
{

    [SerializeField] Bucket interactable;

    [SerializeField] Transform interactionPosition;
    [SerializeField] float rangeToInteract = .7f;
    [SerializeField] float disposeForceFactor = 1.2f;

    bool isCarringObject = false;


    Vector3 DisposeVector()
    {
        Vector3 disposeFactor = new Vector3(Random.Range(-1,1), 0, 0) + Vector3.forward * disposeForceFactor;
        return disposeFactor;
    }

    public void StartSearching()
    {
        print(this + " Przeszukuje");

        if((Vector3.Distance(interactable.transform.position, transform.position) < rangeToInteract) && !isCarringObject)
        {
            print("Podnoszê przedmiot");
            isCarringObject = true;
            interactable.GrabObject(interactionPosition);

            
        } else if(isCarringObject)
        {
            print("Odrzucam przedmiot");
            isCarringObject = false;
            interactable.DisposeObject(interactionPosition, DisposeVector());

        }


    }


}
