using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class MainScriptWithUpdate : MonoBehaviour
{
    public GameObject story;
    StoryText storyText;

    // initializing other scripts that will be called
    Triggers triggerScript = new Triggers();

    // name given to the objects in the inventory lists
    private string item;


    //public Action<bool> Something;
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
        storyText.StartCoroutine(storyText.Intro());
    }


    // Update is called once per frame
    void Update()
    {
        if (triggerScript.cutscene == true)
        {
            Input.GetKeyDown(KeyCode.Z);
        }

        if(Input.GetKeyDown(KeyCode.Z) && triggerScript.cutscene == false)
        {
            DisplayInventory(inventory);
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
