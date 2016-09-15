using UnityEngine;
using System.Collections;

public class IfAndSwitchStatements : MonoBehaviour {

    // I'm going to make this unnecessarily complicated

    // Variables used
    private int theChangingNumber = 0;
    private int theFirst = 3;
    private int theSecond = 4;
    private int theWeirdOne = 6;
    
	// Use this for initialization
	void Start ()
    {
        // Introduction to the system and provides instructions
        print("Welcome to a simplified calculator! You're beginning number is zero. Get your number to be equal to 1, 2, 3, 4, 5, or 6.");
        print("Press Z to add to your number by 3.");
        print("Press X to add to your number by 4.");
        print("Press C to subtract to your number by 6.");
        print("Press Space to restart your number back to 0");
        print("Press Enter when you have your number.");

    }
	
	// Update is called once per frame
	void Update ()
    {
        // If Z is pressed, the player's number will be multiplied by three
        if (Input.GetKeyDown(KeyCode.Z))
        {
            theChangingNumber = theChangingNumber + theFirst;
            print(theChangingNumber);
        }
        
        // If X is pressed, the player's number will be added to by 4
        if (Input.GetKeyDown(KeyCode.X))
        {
            theChangingNumber = theChangingNumber + theSecond;
            print(theChangingNumber);
        }
        
        // If C is pressed, 6 will be subtracted from the number
        if (Input.GetKeyDown(KeyCode.C))
        {
            theChangingNumber = theChangingNumber - theWeirdOne;
            print(theChangingNumber);
        }

        // If Space is pressed, the number will return to zero
        if (Input.GetKeyDown(KeyCode.Space))
        {
            theChangingNumber = 0;
            print("Back to zero.");
        }

        // This if statement has a switch statement within it, 
        // that will check if you meet the necessary requirements and will give a statement if you do depending on your results
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            switch (theChangingNumber)
            {
                case 1:
                    print("Wow, how'd you manage to get one? You must have spent a lot of time doing that");
                    break;
                case 2:
                    print("That was TWO easy! ;D");
                    break;
                case 3:
                    print("Today's horoscope says that you will never find true happiness");
                    break;
                case 4:
                    print("Congrats on getting the number four, you lazy bum.");
                    break;
                case 5:
                    print("Oh look at you. You got the number five. Don't you feel special.");
                    break;
                case 6:
                    print("If there were three more sixes, we'd a lot of sixes. OoOoOoOoOo");
                    break;
                default:
                    print("Excuse you. You need a number between 1-6.");
                    break;
            }
        }

    }
}
