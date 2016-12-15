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

    //public GameObject enemy;
    //EnemyScripts enemyScripts;


    // initializing other scripts that will be called
    // Triggers triggerScript = new Triggers();

    // name given to the objects in the inventory lists
    private string item;

    // Player health
    public int health = 10;


    // Time limit. When this strikes zero, you die
    public int timeLimit = 1000;
    public static int decreaseTime = 1;

    // Used to make sure that the Game Over text does not repeat
    // same for the got item text
    // and the victory number
    // and the partyMemNum
    private int gameOverOncePlease = 0;
    private int gotItem = 0;
    private int victoryNum = 0;
    private int partyMemNum = 0;

    //initializing inventory
    public List<string> inventory;

    // initializing party member list
    public List<string> partyMem;

    void Start()
    {
        inventory.Add("Stick");
        inventory.Add("Bandana");
        inventory.Add("Donut");
        storyText = story.GetComponent<StoryText>();
        triggerScript = trigger.GetComponent<Triggers>();
        //enemyScripts = enemy.GetComponent<EnemyScripts>();
        storyText.StartCoroutine(storyText.Intro());
        StartCoroutine(TimeLimitCountdown());
    }

    private IEnumerator TimeLimitCountdown()
    {
        while (timeLimit > 0)
        {
            timeLimit--;
            yield return new WaitForSeconds(3);
        }
        if (timeLimit == 0)
        {
            triggerScript.timesUp = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // when there is no cutscene active and the inventory isn't pulled up
        if(triggerScript.cutscene == false && triggerScript.invInUse == false && triggerScript.death == false && triggerScript.victory == false)
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

            // IF THE PLAYER FOLLOWED THE SOUND
            if (Input.GetKeyDown(KeyCode.Z) && triggerScript.approachNoise == true)
            {
                triggerScript.explore = true;
                storyText.StartCoroutine(storyText.EnterTemple());
            }
            if (Input.GetKeyDown(KeyCode.X) && triggerScript.approachNoise == true)
            {
                triggerScript.explore = false;
                storyText.StartCoroutine(storyText.DontEnterTemple());
            }

            // IF THE PLAYER WENT LEFT, AVOIDED THE SOUND OR GOT THE ARTIFACT
            if (Input.GetKeyDown(KeyCode.Z) && triggerScript.monster == true)
            {
                storyText.StartCoroutine(storyText.FightTheMonster());
            }
            if (Input.GetKeyDown(KeyCode.X) && triggerScript.monster == true)
            {
                storyText.StartCoroutine(storyText.RunFromMonster());
            }

            // IF THE PLAYER WENT RIGHT
            if (triggerScript.rightPath == true)
            {

                if (Input.GetKeyDown(KeyCode.Z) && triggerScript.rightPath == true)
                {
                    triggerScript.cave = true;
                    storyText.StartCoroutine(storyText.HideInCave());
                }
                if (Input.GetKeyDown(KeyCode.X) && triggerScript.rightPath == true)
                {
                    triggerScript.treeRoot = true;
                    storyText.StartCoroutine(storyText.HideUnderRoot());
                    partyMem.Remove("Shia LeBouf");
                }
            }

            // WHEN THE PLAYER APPROACHED THE FENCE ON THE RIGHT PATH
            if (Input.GetKeyDown(KeyCode.Z) && triggerScript.treeRoot == true && triggerScript.shiaLeBouf == false)
            {
                storyText.StartCoroutine(storyText.ClimbTheFence());
            }
            if (Input.GetKeyDown(KeyCode.X) && triggerScript.treeRoot == true && triggerScript.shiaLeBouf == false)
            {
                storyText.StartCoroutine(storyText.FindTheGate());
            }
        }

        // When C is pressed and the player is not in a cutscene, this method brings up the inventory
        if(Input.GetKeyDown(KeyCode.C) && triggerScript.cutscene == false && triggerScript.death == false && triggerScript.victory == false)
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
                //storyText.StartCoroutine(storyText.ReturnToSituation());
            }
            if (Input.GetKey(KeyCode.Alpha2))
            {
                HelpUseItem(KeyCode.Alpha2);
                triggerScript.invInUse = false;
                //storyText.StartCoroutine(storyText.ReturnToSituation());
            }
            if (Input.GetKey(KeyCode.Alpha3))
            {
                HelpUseItem(KeyCode.Alpha3);
                triggerScript.invInUse = false;
                //storyText.StartCoroutine(storyText.ReturnToSituation());
            }
            if (Input.GetKey(KeyCode.Alpha4))
            {
                HelpUseItem(KeyCode.Alpha4);
                triggerScript.invInUse = false;
                
            }
            if (Input.GetKey(KeyCode.V))
            {
                triggerScript.invInUse = false;
                storyText.StartCoroutine(storyText.ReturnToSituation());
            }
        }

        while (triggerScript.death == true && gameOverOncePlease == 0)
        {
            storyText.StartCoroutine(storyText.GameOver());
            gameOverOncePlease++;
        }
        while(triggerScript.artifact == true && gotItem == 0)
        {
            print("You got a " + InventoryScript.GotArtifact(item));
            inventory.Add(InventoryScript.GotArtifact(item));
            gotItem++;
        }
        while (triggerScript.victory == true && victoryNum == 0)
        {
            print("You made it home safely, just in time for the holidays!");
            victoryNum++;
        }
        while(triggerScript.shiaLeBouf == true && partyMemNum == 0)
        {
            print("Shia LeBouf joined your party!");
            partyMem.Add("Shia LeBouf");
            partyMemNum++;
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
                if (inventory.IndexOf("Weird Artifact") == 0)
                {
                    StartCoroutine(UseArtifact());
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
                if (inventory.IndexOf("Weird Artifact") == 1)
                {
                    StartCoroutine(UseArtifact());
                }
                break;

            case KeyCode.Alpha3:
                if (inventory.IndexOf("Donut") == 2)
                {
                    StartCoroutine(PauseToEatDonut());
                }
                if (inventory.IndexOf("Weird Artifact") == 2)
                {
                    StartCoroutine(UseArtifact());
                }
                break;
            case KeyCode.Alpha4:
                if (inventory.IndexOf("Weird Artifact") == 3)
                {
                    StartCoroutine(UseArtifact());
                }
                break;
        }
    }

    private IEnumerator UseArtifact()
    {
        triggerScript.useArtifact = true;
        InventoryScript.UseArtifact(triggerScript.monster);
        yield return new WaitForSeconds(2);
        storyText.StartCoroutine(storyText.ReturnToSituation());
        storyText.StartCoroutine(storyText.DefeatMonster());
    }

    private IEnumerator PauseToEatDonut()
    {
        InventoryScript.UseDonut(triggerScript.monster);
        yield return new WaitForSeconds(2);
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
            inventory.RemoveAt(2);
        }
        storyText.StartCoroutine(storyText.ReturnToSituation());
        //yield return new WaitForSeconds(0);
        StopCoroutine(PauseToEatDonut());
    }

    private IEnumerator PauseToWearBandana()
    {
        InventoryScript.WearBandana();
        yield return new WaitForSeconds(2);
        if (inventory.IndexOf("Bandana") == 0)
        {
            inventory.RemoveAt(0);
        }
        if (inventory.IndexOf("Bandana") == 1)
        {
            inventory.RemoveAt(1);
        }
        storyText.StartCoroutine(storyText.ReturnToSituation());
        //yield return new WaitForSeconds(0);
        StopCoroutine(PauseToWearBandana());
    }

    private IEnumerator PauseToRemoveStick()
    {
        InventoryScript.UseStick(triggerScript.monster);
        yield return new WaitForSeconds(2);
        inventory.RemoveAt(0);
        storyText.StartCoroutine(storyText.ReturnToSituation());
        //yield return new WaitForSeconds(0);
        StopCoroutine(PauseToRemoveStick());
    }
}
