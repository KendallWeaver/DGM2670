using UnityEngine;
using System.Collections;

public class EventHandler : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {

        // function added to the event
        DelegateIntro.MyEvent += MyEventHandler;

        DelegateIntro.EventWithArgs += EventWithArgsHandler;
	}

    // function that................. i dunoo
    private void MyEventHandler()
    {
        print("Ran");
    }

    private void EventWithArgsHandler(string _s)
    {
        print(_s);
    }
}
