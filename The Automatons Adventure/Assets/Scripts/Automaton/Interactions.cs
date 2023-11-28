using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions : MonoBehaviour
{

    bool readyToInteract = false;
 
    public void StartSearching()
    {
        print(this + " Przeszukuje");

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Well")
        {
            print("Automaton jest przy studni");
            readyToInteract = true;
        }

        if(other.tag == "Plant")
        {
            print("Automaton jest przy roœlinie");
            readyToInteract = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        readyToInteract = false;
    }

}