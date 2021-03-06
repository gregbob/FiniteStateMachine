﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace GB.StateMachine
{
    public class FiniteStateMachine <T>
    {
        Dictionary<ITransition<T>, IState<T>> transitions;

        /// <summary>
        /// Active state in the state machine.
        /// </summary>
        private IState<T> currentState;

        /// <summary>
        /// Last active state in the state machine.
        /// </summary>
        private IState<T> previousState;

        /// <summary>
        /// Initialize state machine with it's start state. Call the OnEnter method of the start state.
        /// </summary>
        /// <param name="initialState">Initial state of the state machine.</param>
        public FiniteStateMachine(IState<T> initialState)
        {
            currentState = initialState;
            currentState.OnEnter(initialState);
            transitions = new Dictionary<ITransition<T>, IState<T>>();
        }

        /// <summary>
        /// Create a transition from one state to the next
        /// </summary>
        /// <param name="transition"></param>
        public void AddTransition(ITransition<T> transition, IState<T> state)
        {
            transitions.Add(transition, state);
        }

        /// <summary>
        /// Execute the current state's action
        /// </summary>
        public void Execute()
        {
            ITransition<T> transition = currentState.Execute();
            if (transition != null)
                ChangeState(transition);
        }

        /// <summary>
        /// Change state based on transition and call OnExit of previous state and OnEnter of new state.
        /// </summary>
        /// <param name="transition"></param>
        public void ChangeState(ITransition<T> transition)
        {
            previousState = currentState;
            currentState = transitions[transition];

            previousState.OnExit();
            currentState.OnEnter(previousState);
        }


    }
}

