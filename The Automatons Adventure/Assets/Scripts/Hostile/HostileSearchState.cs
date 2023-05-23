using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HostileSearchState : HostileBaseState
{
    public override void EnterState(HostileStateManager context)
    {
        Debug.Log(context.name + " rozpocz�� poszukiwania");
    }

    public override void OnVisualContact(HostileStateManager context, Transform automaton)
    {
        Debug.Log(context.name + " znalaz� przeciwnika");
        context.SwitchState(context.hostileAggresive);
    }

    public override void OnVisualContactLost(HostileStateManager context)
    {
        Debug.Log(context.name + " zako�czy� poszukiwania");
        context.SwitchState(context.hostilePatroll);
    }
}
