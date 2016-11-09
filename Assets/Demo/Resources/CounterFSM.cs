using UnityEngine;
using System.Collections;
using GB.StateMachine;

public class CounterFSM : MonoBehaviour {

    FiniteStateMachine<States> fsm;

    public enum States { ADD, MULTIPLY };

    private Counter counter;

	// Use this for initialization
	void Start () {
        counter = new Counter();
        AddState addState = new AddState(counter);
        MultiplyState multiplyState = new MultiplyState(counter);

        fsm = new FiniteStateMachine<States>(addState);
        fsm.AddTransition(new ITransition<States>(States.ADD, States.MULTIPLY), multiplyState);
        fsm.AddTransition(new ITransition<States>(States.MULTIPLY, States.ADD), addState);

    }
	
	// Update is called once per frame
	void Update () {
        fsm.Execute();
    }
}
