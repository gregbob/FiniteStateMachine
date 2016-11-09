using UnityEngine;
using System.Collections;
using GB.StateMachine;
using System;

public class MultiplyState : IState<CounterFSM.States> {

    private Counter counter;

    public MultiplyState(Counter counter)
    {
        this.counter = counter;
    }

    public ITransition<CounterFSM.States> Execute()
    {
        counter.IncreaseCount();

        if (Input.GetKeyDown(KeyCode.W))
        {
            return new ITransition<CounterFSM.States>(CounterFSM.States.MULTIPLY, CounterFSM.States.ADD);
        }
        return null;
    }

    public void OnEnter(IState<CounterFSM.States> previousState)
    {
        Debug.Log("Enter multiply state: count: " + counter.Count);
    }

    public void OnExit()
    {
        Debug.Log("Exit multiply state count: " + counter.Count);
    }

}
