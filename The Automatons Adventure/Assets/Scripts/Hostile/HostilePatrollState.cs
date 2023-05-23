using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HostilePatrollState : HostileBaseState
{
    public override void EnterState(HostileStateManager context)
    {
        Debug.Log(context.name + " rozpoczyna patrol");
        
    }

    public override void OnVisualContact(HostileStateManager context, Transform automaton)
    {
        Debug.Log(context.name + " przechodzi w tryb bojowy");
        context.SwitchState(context.hostileAggresive);
    }

    public override void OnVisualContactLost(HostileStateManager context)
    {
       
    }
}
