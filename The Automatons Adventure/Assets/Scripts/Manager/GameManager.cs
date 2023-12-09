using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject automaton;
    protected Well well;
    protected GameObject plant;
    protected Bucket bucket;

    protected Stance stance;
    protected Weapons weapons;
    protected Movement movement;
    protected Interactions interactions;

    private void Awake()
    {
        automaton = GameObject.FindGameObjectWithTag("Player");
        well = GameObject.FindGameObjectWithTag("Well").GetComponent<Well>();
        plant = GameObject.FindGameObjectWithTag("Plant");
        bucket = GameObject.FindGameObjectWithTag("Bucket").GetComponent<Bucket>();

        stance = automaton.GetComponent<Stance>();
        weapons = automaton.GetComponent<Weapons>();
        movement = automaton.GetComponent<Movement>();
        interactions = automaton.GetComponent<Interactions>();

    }

    void Start()
    {
        CursorPlayMode();
        InitializeAutomaton();
    }


    void CursorPlayMode()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void InitializeAutomaton()
    {
           
        stance.ChangeStance(AutomatonStance.Scouting);
        weapons.ChangeAmmoAmount(5);

        print(this + "Inicjalizowano automatona");
    }


}

