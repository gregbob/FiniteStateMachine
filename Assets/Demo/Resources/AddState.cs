using UnityEngine;
using System.Collections;
using System;

namespace GB.StateMachine
{
    public class AddState :  IState<CounterFSM.States> {

        private Counter counter;

        public AddState(Counter counter)
        {
            this.counter = counter;
        }

        public ITransition<CounterFSM.States> Execute()
        {
            counter.IncreaseCount();

            if (Input.GetKeyDown(KeyCode.Q))
            {
                return new ITransition<CounterFSM.States>(CounterFSM.States.ADD, CounterFSM.States.MULTIPLY);
            }
            return null;
        }

        public void OnEnter(IState<CounterFSM.States> previousState)
        {
            Debug.Log("Enter add state count: " + counter.Count);
        }

        public void OnExit()
        {
            Debug.Log("Exit add state count: " + counter.Count);
        }

    }

}
