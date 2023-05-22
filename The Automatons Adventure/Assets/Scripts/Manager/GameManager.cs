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
    protected Interactions interactions;
    protected Points score;


    private void Awake()
    {
        automaton = GameObject.FindGameObjectWithTag("Player");

        condition = automaton.GetComponent<Condition>();
        stance = automaton.GetComponent<Stance>();
        weapons = automaton.GetComponent<Weapons>();
        movement = automaton.GetComponent<Movement>();
        interactions = automaton.GetComponent<Interactions>();
        score = automaton.GetComponent<Points>();

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
        score.ChangeScore(0);

        print(this + "Inicjalizowano automatona");
    }
}

