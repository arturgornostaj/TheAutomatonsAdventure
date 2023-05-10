using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject automaton;

    Stance stance;
    Condition condition;


    private void Awake()
    {
        automaton = GameObject.FindGameObjectWithTag("Player");
        condition = automaton.GetComponent<Condition>();
        stance = automaton.GetComponent<Stance>();
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

        print(this + "Inicjalizowano automatona");
    }
}

