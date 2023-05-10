using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Condition : MonoBehaviour
{

    [SerializeField] UnityEvent onHpChange;


    [SerializeField] private int _hp;
    public int hp
    {
        get { return _hp; }
        set
        {
            if (value < 0) _hp = 0;
            else _hp = value;
        }
    }

    public void ChangeHp(int setHpValue)
    {
        hp = setHpValue;
        print(this +  "Poziom zdrowia Automatona to: " + hp);

        onHpChange.Invoke();
        
    }

    public void RecieveDamage(int damage)
    {
        hp -= damage;
        onHpChange.Invoke();
    }

    public void RestoreHp(int amount)
    {
        hp += amount;
        onHpChange.Invoke();
    }


}
