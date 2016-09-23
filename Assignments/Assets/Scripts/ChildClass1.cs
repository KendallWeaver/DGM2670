using UnityEngine;
using System.Collections;

public class ChildClass1 {

    // creating string to be inherited
    private string deadInside = "Math is the worst. ";
    private string saveMe = "Save me.";
    public string daveMessage;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //string function that combines the previous two messages
    public string LowestOfLow()
    {
        daveMessage = deadInside + saveMe;
        return daveMessage;
    }
}
