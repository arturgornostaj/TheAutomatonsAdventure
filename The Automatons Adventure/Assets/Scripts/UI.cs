using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour, IStanceUpdate
{
    [SerializeField] TMP_Text stance;
    [SerializeField] TMP_Text hp;
    GameObject automaton;

    Condition condition;

    private void Awake()
    {
        automaton = GameObject.FindGameObjectWithTag("Player");
        condition = automaton.GetComponent<Condition>();
    }

    public void OnHPChange()
    {
        hp.text = "Hp: " + condition.hp;
    }

    public void OnFightingEnter()
    {
        stance.text = "Automaton mode: Combat";
    }

    public void OnScoutingEnter()
    {
        stance.text = "Automaton mode: Scout";
    }

    public void OnSearchingEnter()
    {
        stance.text = "Automaton mode: Search";
    }

}
