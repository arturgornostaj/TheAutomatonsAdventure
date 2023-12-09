using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordEvents : GameManager
{
    [SerializeField] int dilatation = 1;
    [SerializeField] int day = 0;
    [SerializeField] int hour = 0;

    private void Start()
    {
        StartCoroutine(TimeFlow());
    }

    public void EveryDayRoutine(Well well)
    {
        well.FillBucket();
    }

    IEnumerator TimeFlow()
    {
        yield return new WaitForSeconds(dilatation);
        hour++;
        if (hour % 24 == 0)
        {
            hour = 0;
            day++;
            EveryDayRoutine(well);
            print("min¹³ kolejny dzieñ");
        }
        StartCoroutine(TimeFlow());

    }
}
