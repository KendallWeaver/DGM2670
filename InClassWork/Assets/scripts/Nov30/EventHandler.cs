using UnityEngine;
using System.Collections;

public class EventHandler : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        // function added to the event
        DelegateIntro.MyEvent += MyEventHandler;

        DelegateIntro.EventWithArgs += EventWithArgsHandler;

        DelegateIntro.EventString += EventStringHandler;

        DelegateIntro.EventReturnArgs += EventReturnArgsHandler;
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

    private string EventStringHandler()
    {
        print("Do you like life?");
        return "I hate life";
    }

    private string EventReturnArgsHandler(string s)
    {
        return "The animal I hate the most is " + s;
    }
}
