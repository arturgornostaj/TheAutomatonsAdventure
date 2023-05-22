using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Points : MonoBehaviour
{

    [SerializeField] int score = 0;
    [SerializeField] UnityEvent onScoreChange;

    public void AddScore(int _score)
    {
        score += _score;
        onScoreChange.Invoke();
    }

    public void ChangeScore(int _score)
    {
        score = _score;
        onScoreChange.Invoke();
    }

    public int CurrentScore() => score;
}
