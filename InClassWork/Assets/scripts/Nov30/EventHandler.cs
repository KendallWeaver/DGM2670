using UnityEngine;
using System.Collections;

public class EventHandler : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {

        // function added to the event
        DelegateIntro.MyEvent += MyEventHandler;
	}

    // function that................. i dunoo
    private void MyEventHandler()
    {
        print("Ran");
    }
}
