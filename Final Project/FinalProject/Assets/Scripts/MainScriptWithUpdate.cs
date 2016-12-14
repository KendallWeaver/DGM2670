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
    // use item attempt
    public int useItemNum;

    // Time limit. When this strikes zero, you die
    public int timeLimit = 1000000;
    public int decreaseTime = 1;

    //public Action<bool> Something;
    //public Action<int> NearDeath;
    //public Action<KeyCode> Esc;
    //public Action<KeyCode> UserInputs;

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

    // Update is called once per frame
    void Update()
    {
        // when there is no cutscene active and the inventory isn't pulled up
        if(triggerScript.cutscene == false && triggerScript.invInUse == false)
        {
            // FIRST CHOICE IF STATEMENT
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

            // IF THE PLAYER WENT LEFT
            if (Input.GetKeyDown(KeyCode.Z) && triggerScript.leftPath == true)
            {
                triggerScript.leftPath = false;
                storyText.StartCoroutine(storyText.ApproachSound());
            }
            if (Input.GetKeyDown(KeyCode.X) && triggerScript.leftPath == true)
            {
                triggerScript.leftPath = false;
                storyText.StartCoroutine(storyText.AvoidSound());
            }

            // IF THE PLAYER WENT LEFT, AVOIDED THE SOUND OR GOT THE ARTIFACT
            if (Input.GetKeyDown(KeyCode.Z) && triggerScript.monster == true)
            {
                print("Some kind of fight is suppose to happen I dunno.");
            }
            if (Input.GetKeyDown(KeyCode.X) && triggerScript.rightPath == true)
            {
                storyText.StartCoroutine(storyText.RunFromMonster());
            }

            // IF THE PLAYER WENT RIGHT
            if (Input.GetKeyDown(KeyCode.Z) && triggerScript.rightPath == true)
            {
                print("Working");
            }
            if (Input.GetKeyDown(KeyCode.X) && triggerScript.rightPath == true)
            {
                print("NOT COMPLETED");
            }

            // attempting to write the above code in a switch statement
        }

        // When C is pressed and the player is not in a cutscene, this method brings up the inventory
        if(Input.GetKeyDown(KeyCode.C) && triggerScript.cutscene == false)
        {
            triggerScript.invInUse = true;
            DisplayInventory(inventory);
            print("V - Exit");
        }

        if(triggerScript.invInUse == true)
        {
            if(Input.GetKey(KeyCode.Alpha1))
            {
                HelpUseItem(KeyCode.Alpha1);
                triggerScript.invInUse = false;
                //storyText.StartCoroutine(storyText.IntroReturn());
            }
            if (Input.GetKey(KeyCode.Alpha2))
            {
                HelpUseItem(KeyCode.Alpha2);
                triggerScript.invInUse = false;
                //storyText.StartCoroutine(storyText.IntroReturn());
            }
            if (Input.GetKey(KeyCode.Alpha3))
            {
                HelpUseItem(KeyCode.Alpha3);
                triggerScript.invInUse = false;
                //storyText.StartCoroutine(storyText.IntroReturn());
            }
            if(Input.GetKey(KeyCode.V))
            {
                triggerScript.invInUse = false;
                if (triggerScript.firstChoice == true)
                {
                    storyText.StartCoroutine(storyText.IntroReturn());
                }
                if(triggerScript.leftPath == true)
                {
                    storyText.StartCoroutine(storyText.TakeLeftPathReturn());
                }
                if (triggerScript.rightPath == true)
                {

                }
            }
        }
    }


    public void DisplayInventory(List<string> inventory)
    {
        foreach (string item in inventory)
        {
            print(inventory.IndexOf(item) + 1 + " - " + item);
        }
    }

    private void HelpUseItem(KeyCode _keycode)
    {
        switch (_keycode)
        {
            case KeyCode.Alpha1:
                if (inventory.IndexOf("Stick") == 0)
                {
                    StartCoroutine(PauseToRemoveStick());
                }
                
                if (inventory.IndexOf("Bandana") == 0)
                {
                    StartCoroutine(PauseToWearBandana());
                }

                if (inventory.IndexOf("Donut") == 0)
                {
                    StartCoroutine(PauseToEatDonut());
                }
                break;

            case KeyCode.Alpha2:
                if (inventory.IndexOf("Donut") == 1)
                {
                    StartCoroutine(PauseToEatDonut());
                }
                if (inventory.IndexOf("Bandana") == 1)
                {
                    StartCoroutine(PauseToWearBandana());
                }
                
                break;

            case KeyCode.Alpha3:
                if (inventory.IndexOf("Donut") == 2)
                {
                    StartCoroutine(PauseToEatDonut());
                }
                break;
        }
    }

    private IEnumerator PauseToEatDonut()
    {
        InventoryScript.UseDonut();
        yield return new WaitForSeconds(3);
        if (inventory.IndexOf("Donut") == 0)
        {
            inventory.RemoveAt(0);
        }
        if (inventory.IndexOf("Donut") == 1)
        {
            inventory.RemoveAt(1);
        }
        if (inventory.IndexOf("Donut") == 2)
        {
            inventory.RemoveAt(3);
        }
        //yield return new WaitForSeconds(0);
        StopCoroutine(PauseToRemoveStick());
    }

    private IEnumerator PauseToWearBandana()
    {
        InventoryScript.WearBandana();
        yield return new WaitForSeconds(3);
        if (inventory.IndexOf("Bandana") == 0)
        {
            inventory.RemoveAt(0);
        }
        if (inventory.IndexOf("Bandana") == 1)
        {
            inventory.RemoveAt(1);
        }
        //yield return new WaitForSeconds(0);
        StopCoroutine(PauseToRemoveStick());
    }

    private IEnumerator PauseToRemoveStick()
    {
        InventoryScript.UseStick();
        yield return new WaitForSeconds(3);
        inventory.RemoveAt(0);
        //yield return new WaitForSeconds(0);
        StopCoroutine(PauseToRemoveStick());
    }
}
