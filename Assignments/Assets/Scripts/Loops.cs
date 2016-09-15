using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour {

    // Here's what I'm thinking
    // Have a countdown, and then when the countdown hits, you do another loop

    // You need a while loop
    // you need a do while loop
    // you need a for loop
    // you need a foreach loop

    // UNITY ALWAYS CRASHES WHEN I TRY TO DO A WHILE LOOP I'M SO PISSED
    // If and switch statements are some of my favorite things. 
    // Loops? I despise with a passion.

    private int forNumberCount = 5;
    private int whileLoopNumber = 4;
    private int[] theArray = new int[5];
    private int iDunnoo = 2;

    private bool totallyTrue = false;

	// Use this for initialization
	void Start ()
    {
        // You should probably put loops here
        // Cause, you know. It will do it once. And not crash you're code. Like in Update
        do
        {
            print("Help the while loop keeps crashing my code.");
        } while (totallyTrue == true);

        for (int i = 0; i <= forNumberCount; i++)
        {
            if (i == 4)
            {
                print("Look I counted! Thanks For Loop!");
            }
            if (i == 3)
            {
                print("3");
            }
            if (i == 2)
            {
                print("2");
            }
            if (i == 1)
            {
                print("1");
            }
        }
        // Here I'm initializing the int array
        theArray[0] = 4;
        theArray[1] = 7;
        theArray[2] = 1;
        theArray[3] = 6;
        theArray[4] = 56;

        // here I'm activating it for every value I have
        // remeber arrays start at 0 instead of one. It'll break your code
        foreach (int thingy in theArray)
        {
            print("Send help my number is " + (thingy * iDunnoo));
        }

        // THANK THE HEAVENS ABOVE iT FINALLY WORKED NEVER PUT THIS IN UPDATE
        // while the number is greater than 0, it will print this. Then we decrement it so that it doesn't continously loop forever.
        while (whileLoopNumber > 0)
        {
            print("SEND HELP THE WHILE LOOP KEEPS CRASHING UNITY IF YOU CAN SEE THIS IT MEANS IT FINALLY WORKED");
            whileLoopNumber--;
        }
    }

    // Update is called once per frame
    void Update ()
    {  

        // When the Spacebar is pressed, all of the values will return to normal
        
       
	}

}
