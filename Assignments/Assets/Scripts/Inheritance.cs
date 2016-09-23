using UnityEngine;
using System.Collections;


// CAN I JUST SHOW THAT MONOBEHAVIOR IS SOMETHING WE INHERIT FROM IN THIS CLASS? ... NO?
public class Inheritance : MonoBehaviour {

    

	// Use this for initialization
	void Start ()
    {
        // Initializing the classes so that they can be accessed
        ChildClass1 firstClass = new ChildClass1();
        ChildClass2 secondClass = new ChildClass2();

        // Printing the return value in this function
        print(firstClass.LowestOfLow());
        print(secondClass.SchoolIsTheWorst());

        // I commented this out because it seems like, because second class is a child of ChildClass1, it can still access it's methods here. Interesting.
        // secondClass.LowestOfLow();

	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
