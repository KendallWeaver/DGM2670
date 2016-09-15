// These two lines help indicate the kind of system that this code will be used for
// It helps Unity be able to read it and not freak out
using UnityEngine;
using System.Collections;

// This is the class that encompasses the entire code. You can also create another class within the code, if the need is there
// Classes can also be called in other scripts. This can help pull everything together, and keep things organized.
public class ConventionsAndSyntax : MonoBehaviour {

    //Before we start, yes I am aware that I accidentally mispelled the scene name. I'm being graded on my work, not my spelling please. 

    /* Comments are incredibly useful to create a layout of what your code does. 
     * Sometimes it's smart to write out your plan for your code (Pseudo-Code) before beginning to code anything.
     * This helps you understand and focus on what you're trying to accomplish.
     * It's niiiice. */

    

	// Use this for initialization
    // This method comes automatically when creating a script from within Unity
    // It will only play once, when the game begins
    // The brackets are a "block" that encompasses some code used in the function. It's essential to have for functions/methods
	void Start () {
        print("Press Z to attack!");
	}
	
	// Update is called once per frame
    // This is another method created automatically. This method will continuously update when the game is being played.
    // An if statement is used, otherwise the print("Ouch"); will continuously display until the game ends.
	void Update () {
    // an if statement is being used to demonstrate dot operators.
    // Input is the "general" category, and "GetKeyDown" is a static function within the "Input" category that can be used.
    // In the case of an if statement, a semicolon is not needed at the end, because it encompasses some more basic code
    // "Key code" is an enum parameter, and another dot is to call the kinds of "keys" within that parameter
        if (Input.GetKeyDown(KeyCode.Z))
        {
            print("Ouch");
        }

	}

    // Comments can also be helpful to hide code that needs fixing
    // I usually do this, since a lot of my codes fail the first time I write them. Commenting out the problem can sometimes help figure out what exactly is wrong without
    // adding up unnecessary errors.
}
