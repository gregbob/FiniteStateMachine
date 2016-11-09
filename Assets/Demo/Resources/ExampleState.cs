using UnityEngine;
using System.Collections;
using System;

namespace GB
{
    public class ExampleState :  IState {

        private Counter counter;

        public ExampleState(Counter counter)
        {
            this.counter = counter;
        }

        public void Execute()
        {
            counter.IncreaseCount();
        }

        public void OnEnter()
        {
            Debug.Log("Enter example state count: " + counter.Count);
        }

        public void OnExit()
        {
            Debug.Log("Exit example state count: " + counter.Count);
        }

    }

}
