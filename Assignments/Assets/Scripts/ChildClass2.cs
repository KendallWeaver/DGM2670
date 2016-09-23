using UnityEngine;
using System.Collections;

// Changed this so that it is a child of ChildClass1
public class ChildClass2 : ChildClass1 {

    public string intro = "Here's what Dave has to say! ";
    public string combinedMessage;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // Unused method. I created this to test if I could access the ChildClass 1 variables
    // It's purpose is null, but I keep it open just in case? Yes, that's bad programming; I'm sorry.
    public string DavesMessage()
    {
        combinedMessage = intro + daveMessage;
        return daveMessage;
    }

    public string SchoolIsTheWorst()
    {
        string complaining = "School is the actual worst.";
        return complaining;
    }

}
