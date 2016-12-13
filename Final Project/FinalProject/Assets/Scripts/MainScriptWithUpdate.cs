using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class MainScriptWithUpdate : MonoBehaviour
{
    public GameObject story;
    StoryText storyText;

    public GameObject trigger;
    Triggers triggerScript;

    // initializing other scripts that will be called
    // Triggers triggerScript = new Triggers();

    // name given to the objects in the inventory lists
    private string item;

    // Time limit. When this strikes zero, you die
    public int timeLimit = 1000000;
    public int decreaseTime = 1;

    public Action<bool> Something;
    //public Action<int> NearDeath;
    //public Action<KeyCode> Esc;
    public Action<KeyCode> UserInputs;

    //initializing inventory
    public List<string> inventory;

    void Start()
    {
        inventory.Add("Stick");
        inventory.Add("Bandana");
        inventory.Add("Donut");
        storyText = story.GetComponent<StoryText>();
        triggerScript = trigger.GetComponent<Triggers>();
        storyText.StartCoroutine(storyText.Intro());
        do
        {
            timeLimit = timeLimit - decreaseTime;
        } while (timeLimit > 0);
    }

    void HelpUseItem(KeyCode _keycode)
    {
        UserInputs(KeyCode.Alpha0);
    }


    // Update is called once per frame
    void Update()
    {
        if(triggerScript.cutscene == false)
        {
            if (triggerScript.firstChoice == true)
            {
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    triggerScript.firstChoice = false;
                    storyText.StartCoroutine(storyText.TakeLeftPath());
                }
                if (Input.GetKeyDown(KeyCode.X))
                {
                    triggerScript.firstChoice = false;
                    storyText.StartCoroutine(storyText.TakeRightPath());
                }
            }

            if (Input.GetKeyDown(KeyCode.Z) && triggerScript.leftPath == true)
            {
                print("NOPE STILL BROKEN");
            }
            if (Input.GetKeyDown(KeyCode.X) && triggerScript.rightPath == true)
            {
                print("TEST");
            }

            // attempting to write the above code in a switch statement
        }

        // When C is pressed and the player is not in a cutscene, this method brings up the inventory
        if(Input.GetKeyDown(KeyCode.C) && triggerScript.cutscene == false)
        {
            DisplayInventory(inventory);
            storyText.StartCoroutine(storyText.IntroReturn());
        }
    }


    public void DisplayInventory(List<string> inventory)
    {
        foreach (string item in inventory)
        {
            print(inventory.IndexOf(item) + 1 + " - " + item);
        }
    }
}
