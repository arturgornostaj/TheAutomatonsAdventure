using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject automaton;

    protected Stance stance;
    protected Condition condition;
    protected Weapons weapons;
    protected Movement movement;


    private void Awake()
    {
        automaton = GameObject.FindGameObjectWithTag("Player");

        condition = automaton.GetComponent<Condition>();
        stance = automaton.GetComponent<Stance>();
        weapons = automaton.GetComponent<Weapons>();
        movement = automaton.GetComponent<Movement>();
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
     
        condition.ChangeHp(3);       
        stance.ChangeStance(AutomatonStance.Scouting);
        weapons.ChangeAmmoAmount(5);

        print(this + "Inicjalizowano automatona");
    }
}

