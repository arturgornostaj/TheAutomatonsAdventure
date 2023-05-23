using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HostileAggresiveState : HostileBaseState
{
    public override void EnterState(HostileStateManager context)
    {
        Debug.Log(context.name + " rozpocz�� tryb bojowy");
    }

    public override void OnVisualContact(HostileStateManager context, Transform automaton)
    {
        Debug.Log(context.name + " jest w trybie bojowym");
    }

    public override void OnVisualContactLost(HostileStateManager context)
    {
        Debug.Log(context.name + " zgubi� cel");
        context.SwitchState(context.hostileSearch);
    }
}
