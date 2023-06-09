using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : GameManager, IStanceUpdate
{
    [SerializeField] TMP_Text stanceTxt;
    [SerializeField] TMP_Text hpTxt;
    [SerializeField] TMP_Text ammoTxt;
    [SerializeField] TMP_Text scoreTxt;

    public void OnHPChange()
    {
        hpTxt.text = "Hp: " + condition.hp;
    }

    public void OnAmmoAmountChange()
    {
        ammoTxt.text = "Ammo: " + weapons.ammo;
    }

    public void OnFightingEnter()
    {
        stanceTxt.text = "Automaton mode: Combat";
    }

    public void OnScoutingEnter()
    {
        stanceTxt.text = "Automaton mode: Scout";
    }

    public void OnSearchingEnter()
    {
        stanceTxt.text = "Automaton mode: Search";
    }

    public void OnScoreChange()
    {
        scoreTxt.text = score.CurrentScore().ToString();
    }

}
