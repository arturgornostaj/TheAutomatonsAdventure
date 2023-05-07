using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stance : MonoBehaviour
{
    public AutomatonStance stance;

    private void Start()
    {
        stance = AutomatonStance.Scouting;
    }

    public void ChangeStance(AutomatonStance desireStance)
    {
        stance = desireStance;
    }

}

public enum AutomatonStance
{
    Scouting,
    Fighting,
    Searching
}
