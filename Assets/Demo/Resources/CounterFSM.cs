using UnityEngine;
using System.Collections;
using GB;

public class CounterFSM : MonoBehaviour {

    FiniteStateMachine<States> fsm;

    public enum States { ADD, MULTIPLY };

    private Counter counter;

	// Use this for initialization
	void Start () {
        counter = new Counter();
        ExampleState exampleState = new ExampleState(counter);
        MultiplyState multiplyState = new MultiplyState(counter);

        fsm = new FiniteStateMachine<States>(exampleState);
        fsm.AddTransition(new ITransition<States>(States.ADD, States.MULTIPLY), exampleState);
        fsm.AddTransition(new ITransition<States>(States.MULTIPLY, States.ADD), multiplyState);

    }
	
	// Update is called once per frame
	void Update () {
        fsm.Execute();

        if (Input.GetKeyDown(KeyCode.Q))
        {
            fsm.ChangeState(new ITransition<States>(States.ADD, States.MULTIPLY));
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            fsm.ChangeState(new ITransition<States>(States.MULTIPLY, States.ADD));
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            counter.PrintCount();
        }
    }
}
