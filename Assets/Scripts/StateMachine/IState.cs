using UnityEngine;
using System.Collections;

namespace GB.StateMachine
{
    public interface IState<T>
    {
        /// <summary>
        /// Main method of state. Return a transition to change state.
        /// </summary>
        /// <returns></returns>
        ITransition<T> Execute();

        /// <summary>
        /// Executes upon switching to new state. 
        /// </summary>
        /// <param name="previousState"></param>
        void OnEnter(IState<T> previousState);
        void OnExit();
    }

}
