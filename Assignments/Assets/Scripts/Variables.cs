using UnityEngine;
using System.Collections;

public class Variables : MonoBehaviour {

    // Declaring variables
    // The other data types that I did not include are doubles, chars, vars,
    // and Quaternions. As far as I know we don't use Quaternions often, though.
    private int varOne = 1;
    private float floatOne = 2.2f;
    private string stringOne = "ONE PUNCH MAN";
    private int multiFive = 5;

    private float newVariable;

	// Use this for initialization
	void Start () {

        // various prints that will demonstrate use strings, ints, and floats in an incredibly simple manner
        print("BEHOLD AN INTEGER, WHICH IN THIS CASE IS " + varOne);
        print("WITNESS TO A FLOAT:" + floatOne);
        print("SPIDERMAN HAS NOTHING AGAINST " + stringOne);

        print("I WILL NOW MULTIPLY THE INTEGER WITH FIVE");

        print(varOne * multiFive);

        print("IMPRESSED? HOW ABOUT DIVISION? FIVE DIVIDED BY ONE IS " + (multiFive/varOne));

        print("Oh I guess you have to take my word for it. LOOK IN THE CODE");

        print("NOW I'MMA CREATE A NEW VARIABLE");

        float newVariable = 3.3f;

        print("AND NOW I WILL MULTIPLY THE TWO FLOATS AND THEN ADD THE INTEGER");

        print((newVariable * floatOne) + varOne);

        // MAN IT'S A BIT DIFFICULT TO SHOW THAT I KNOW VARIABLES AND STUFF LIKE THAT D:
        // Also hi professor. I'm the one who always comes in late
        // The reason being that I commute from Lehi from work. So there.

        // Also I swear, if you fail me because I said One Punch Man is better than Spiderman,
        // I'mma be pissed.
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
