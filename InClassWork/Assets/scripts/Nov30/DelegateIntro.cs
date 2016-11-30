using UnityEngine;
using System.Collections;
using System;

public class DelegateIntro : MonoBehaviour {

    // this is a delegate and an event
    public static Action MyEvent;


    /*
    public delegate void DelWithArgs(string _s);
    public static DelWithArgs EventWithArgs;
    */
    //This is a better way to write it
    public static Action<string> EventWithArgs;
    /*
    public delegate string DelString();
    public static DelString EventString;
    */
    public static Func<string> EventString;
    // Func is a delegate with a return type

	// Use this for initialization
	void Start ()
    {
        // this if statement is here to only have the delegate run if something is there; deleting the cube will cause this not to run
        if(MyEvent != null)
            MyEvent();

        EventWithArgs("Hello World");

        print (EventString());
	}
	

}
