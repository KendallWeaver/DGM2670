using UnityEngine;
using System.Collections;

public class ScopeAndAccessModifiers : MonoBehaviour {

    // These variables are global and are in scope of this class. These can be changed in the inspector
    public int randomNumber = 1;
    public string publicString = "Player Name";

    // this is calling on another script that will be able to access it's public variables
    private RandomPublicScript publicScript;

	// Use this for initialization
	void Start ()
    {
        publicScript = new RandomPublicScript();
        print(publicString);
        print("Is this your name? If not, please enter your name in the Inspector and press the Space Bar. If it is correct, press Enter.");

    }
	
	// Update is called once per frame
	void Update ()
    {
        // This will re-evaluate the player's name, clarifying if it's correct
	    if(Input.GetKeyDown(KeyCode.Space))
        {
            print(publicString);
            print("Is this your name? If not, please enter your name in the Inspector and press the Space Bar. If it is correct, press Enter.");
        }


        // this will activate when enter is correct, calling the name the player entered and accessing the myName variable in the RandomPublicScript
        if (Input.GetKeyDown(KeyCode.Return))
        {
            print(publicString + ", huh? My name is " + publicScript.myName);
        }
	}
}
