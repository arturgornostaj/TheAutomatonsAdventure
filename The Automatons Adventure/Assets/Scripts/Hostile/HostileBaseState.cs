using UnityEngine;

public abstract class HostileBaseState
{

    public abstract void EnterState(HostileStateManager context);

    public abstract void OnVisualContact(HostileStateManager context, Transform automaton);

    public abstract void OnVisualContactLost(HostileStateManager context);


}
