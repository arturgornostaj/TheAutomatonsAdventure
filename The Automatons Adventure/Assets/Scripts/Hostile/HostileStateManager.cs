using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HostileStateManager : MonoBehaviour
{
    [SerializeField] GameObject automaton;
    [SerializeField] float sightRangeMin = 10;
    [SerializeField] float sightRangeMax = 10;
    bool isAutomatonInSight;

    HostileBaseState currentState;

    public HostileDestroyedState hostileDestroyed = new HostileDestroyedState();
    public HostilePatrollState hostilePatroll = new HostilePatrollState();
    public HostileSearchState hostileSearch = new HostileSearchState();
    public HostileAggresiveState hostileAggresive = new HostileAggresiveState();


    private void Start()
    {
        currentState = hostilePatroll;
        currentState.EnterState(this);
    }

    private void Update()
    {
        if (DistanceToAutomaton(automaton) <= sightRangeMin) currentState.OnVisualContact(this, automaton.transform);
        else currentState.OnVisualContactLost(this);
    }

    float DistanceToAutomaton(GameObject _automaton) => Vector3.Distance(gameObject.transform.position, _automaton.transform.position);


    public void SwitchState(HostileBaseState newState)
    {
        currentState = newState;
    }




}
