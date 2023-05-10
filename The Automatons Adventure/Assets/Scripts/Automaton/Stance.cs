using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Stance : MonoBehaviour
{
    public AutomatonStance stance;
    [SerializeField] UnityEvent onScoutingStanceEnter, onFightingStanceEnter, onSearchingStanceEnter;

    public void ChangeStance(AutomatonStance desireStance)
    {
        print("Automaton w trybie: " + desireStance);
        switch (desireStance)
        {
            case AutomatonStance.Scouting:
                onScoutingStanceEnter.Invoke();
                stance = desireStance;
                break;
            case AutomatonStance.Fighting:
                onFightingStanceEnter.Invoke();
                stance = desireStance;
                break;
            case AutomatonStance.Searching:
                onSearchingStanceEnter.Invoke();
                stance = desireStance;
                break;
            default:
                onScoutingStanceEnter.Invoke();
                stance = desireStance;
                break;
        }
    }

    public AutomatonStance CurrentStance()
    {
        return stance;
    }


}

