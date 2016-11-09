using UnityEngine;
using System.Collections;
using GB;
using System;

public class MultiplyState : IState {

    private Counter counter;

    public MultiplyState(Counter counter)
    {
        this.counter = counter;
    }

    public void Execute()
    {
        counter.IncreaseCount();
    }

    public void OnEnter()
    {
        Debug.Log("Enter multiply state: count: " + counter.Count);
    }

    public void OnExit()
    {
        Debug.Log("Exit multiply state count: " + counter.Count);
    }

}
