using UnityEngine;
using System.Collections;

namespace GB.StateMachine
{
    public interface IState
    {

        void Execute();
        void OnEnter();
        void OnExit();
    }

}
