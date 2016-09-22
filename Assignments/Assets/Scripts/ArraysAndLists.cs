using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class ArraysAndLists : MonoBehaviour {

    // initializing the Array and the String
    private string[] theArray = { "See Ya", "Good-bye", "Later", "Sayonara", "Farewell", "Bye Suckers", };
    List<string> theList = new List<string>();
    List<string> theTempList = new List<string>();
    // Use this for initialization
    void Start ()
    {
        print("Press Space to display the array; X to display the List; Z to replace the list with the array.");
        // Adding values to the list
        theList.Add("Greetings");
        theList.Add("Salutations");
        theList.Add("Hello");
        theList.Add("Konichiwa");
        theList.Add("Salute");
        theList.Add("Sup Nerds");
        
	}
	
	// Update is called once per frame
	void Update ()
    {

        // this will display the Arrays, which are the farewells
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (string farewell in theArray)
            {
                print(farewell);
            }

        }

        // This will display the List items, which are the greetings
        if(Input.GetKeyDown(KeyCode.X))
        {
            foreach(string greeting in theList)
            {
                print(greeting);
            }
        }
        
        // In this we assign the values in theList and give it to theTempList for later
        // theList is then cleared and the Array is added and then displayed
        // The list is then cleared, theTempList is added back into theList, and theTempList is cleared to prevent abuse.
        if (Input.GetKeyDown(KeyCode.Z))
        {
            theTempList.AddRange(theList);
            
            theList.Clear();
            theList.AddRange(theArray);
             
            foreach (string farewell in theList)
            {
               print(farewell);
            }

            theList.Clear();
            theList.AddRange(theTempList);
            theTempList.Clear();
        }

        /* 
         * This code was used to test if theList values went back to normal after pressing z
        if (Input.GetKeyDown(KeyCode.V))
        {
            print("The first value in the List should be 'Greetings'..." + theList[0]);
        }
        */
        
	}
}
