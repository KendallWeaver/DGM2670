using UnityEngine;
using System.Collections;

public class StoryText : MonoBehaviour
{
    // initializing the GameObject Trigger here
    public GameObject trigger;
    Triggers triggerScript;

    // creating a int for the pause because Magic Numbers are bad
    private int p = 2;

    public void Start()
    {
        triggerScript = trigger.GetComponent<Triggers>();
    }

    // BASE IENUMERATOR METHOD
    /*
    public IEnumerator SceneName()
    {
        triggerScript.cutscene = true;
        print("Text is cool");
        yield return new WaitForSeconds(p);
        triggerScript.cutscene = false;
        StopCoroutine(SceneName());
    }
    */


    public IEnumerator Intro()
    {
        triggerScript.cutscene = true;
        print("It's a late night...");
        yield return new WaitForSeconds(p);
        print("You wake up in a forest for some random reason.");
        yield return new WaitForSeconds(p);
        print("It's not safe at night; you need to survive the night.");
        yield return new WaitForSeconds(p);
        print("You begin walking.");
        yield return new WaitForSeconds(p);
        print("You approach a fork in the road. Which way do you go? Left? Or Right?");
        print("Z - Left             X - Right           C - Check Inventory");
        triggerScript.cutscene = false;
        StopCoroutine(Intro());
    }

    public IEnumerator IntroReturn()
    {
        triggerScript.cutscene = true;
        yield return new WaitForSeconds(p);
        print("You still have to decide which direction to go. Which way?");
        print("Z - Left             X - Right           C - Check Inventory");
        triggerScript.cutscene = false;
        StopCoroutine(IntroReturn());
    }

    public IEnumerator TakeLeftPath()
    {
        triggerScript.cutscene = true;
        print("You decide to take the left path.");
        yield return new WaitForSeconds(p);
        print("It's rough and rugged.");
        yield return new WaitForSeconds(p);
        print("As you walk, the path begins to narrow.");
        yield return new WaitForSeconds(p);
        print("The trees are getting uncomfortably closer.");
        yield return new WaitForSeconds(p);
        print("Despite this, you press on. The only sound you hear are the leaves rustling in the wind.");
        yield return new WaitForSeconds(p);
        print("Suddenly, you hit something against your foot. Luckily it didn't hurt.");
        yield return new WaitForSeconds(p);
        print("But it didn't feel like any object you're familiar with...");
        yield return new WaitForSeconds(p);
        print("You peer down to see if you can see what it was.");
        yield return new WaitForSeconds(p);
        print("It's dark, but there's definitely something there.");
        yield return new WaitForSeconds(p);
        print("You get closer...");
        yield return new WaitForSeconds(p);
        print("The unknown object becomes recognizable.");
        yield return new WaitForSeconds(p);
        print("It's a human skull.");
        yield return new WaitForSeconds(p);
        print("In fact, you realize that there are shards of bones scattered along this path.");
        yield return new WaitForSeconds(p);
        print("How long has it been lilke that...?");
        yield return new WaitForSeconds(p);
        print("Suddenly, you hear a strange sound in the distance, off the path.");
        yield return new WaitForSeconds(p);
        print("It didn't sound like a human... or an animal.");
        yield return new WaitForSeconds(p);
        print("...");
        yield return new WaitForSeconds(p);
        print("Do you approach the sound?");
        print("Z - Yes             X - NO!!!           C - Check Inventory");
        triggerScript.cutscene = false;
        triggerScript.leftPath = true;
        StopCoroutine(TakeLeftPath());
    }

   
   public IEnumerator ApproachSound()
   {
       triggerScript.cutscene = true;
       print("Curiousity gets the better of you.");
       yield return new WaitForSeconds(p);
        print("If you don't check now, you'll never know.");
        triggerScript.approachNoise = true;
        yield return new WaitForSeconds(p);
        triggerScript.cutscene = false;
       StopCoroutine(ApproachSound());
   }
   


    public IEnumerator TakeRightPath()
    {
        triggerScript.cutscene = true;
        Debug.Log("You decide to take the right path. 'Choose the right', am I right?");
        yield return new WaitForSeconds(p);
        triggerScript.cutscene = false;
        triggerScript.rightPath = true;
        StopCoroutine(TakeRightPath());
    }
}
