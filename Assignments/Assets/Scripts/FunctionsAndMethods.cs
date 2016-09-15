using UnityEngine;
using System.Collections;

public class FunctionsAndMethods : MonoBehaviour {

    // variables
    private int fifteen = 15;
    private int bigNumber = 178;
    private string woopie = "kill me";

	// Use this for initialization
	void Start ()
    {
        // print messages testing calling different functions
        print(VisableFunction());
        print("Now I will call upon a function that will display the unholy number.");
        print(OhNoWhy());
        print("Time for a function that calls two values");
        print("Here is what the function says: " + WellThen(bigNumber, woopie));
	}

    // Literally this function exists to show that void functions will not return a value unless called
    void HiddenFunction()
    {
        print("This is a function that does not return any value. This message is an illusion.");
    }

    // The first function that was called in start. It returns a string message created in the function
    string VisableFunction()
    {
        string ifYouCanReadThis = "This message is being called from the Start function so that you can read this. Don't believe me? Check the code.";

        return ifYouCanReadThis;
    }

    // This function will display a new integer created within the function
    int OhNoWhy()
    {
        int unholyNumber = fifteen * bigNumber;

        return unholyNumber;
    }

    // This function is to test taking in two differing data types and returning a single value
    string WellThen(int bigNumber, string woopie)
    {
        string woopieTwo = "I'm including the variable bigNumber (" + bigNumber + ") and adding the original woopie message (" + woopie + ")" ;
        return woopieTwo;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
