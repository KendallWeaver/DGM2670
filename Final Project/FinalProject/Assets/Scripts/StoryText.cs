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
        print("Do you...");
        yield return new WaitForSeconds(p);
        print("Z - Approach the Sound             X - Keep to the path           C - Check Inventory");
        triggerScript.cutscene = false;
        triggerScript.leftPath = true;
        StopCoroutine(TakeLeftPath());
    }
   public IEnumerator TakeLeftPathReturn()
    {
        triggerScript.cutscene = true;
        print("There's still the suspicious noise to deal with.");
        yield return new WaitForSeconds(p);
        print("Z - Approach the Sound             X - Keep to the path           C - Check Inventory");
        triggerScript.cutscene = false;
        StopCoroutine(TakeLeftPathReturn());
    }

   
   public IEnumerator ApproachSound()
   {
        triggerScript.cutscene = true;
        print("Curiousity gets the better of you.");
        yield return new WaitForSeconds(p);
        print("If you don't check now, you'll never know.");
        triggerScript.approachNoise = true;
        yield return new WaitForSeconds(p);
        print("You step off the path and begin your journey towards the noise.");
        yield return new WaitForSeconds(p);
        print("Since it only happened once, you're trying to rely on your memory.");
        yield return new WaitForSeconds(p);
        print("As the forest gets thicker, your doubts get stronger.");
        yield return new WaitForSeconds(p);
        print("What direction are you heading?");
        yield return new WaitForSeconds(p);
        print("Where's the path? Will you even be able to find it again?");
        yield return new WaitForSeconds(p);
        print("... Will you even get out of here alive?");
        yield return new WaitForSeconds(p);
        print("And then you notice something off in the distance...");
        yield return new WaitForSeconds(p);
        print("It... looks like a building.");
        yield return new WaitForSeconds(p);
        print("As you get closer, you realize that it's an ancient temple.");
        yield return new WaitForSeconds(p);
        print("Moss, vines, and weeds cover the architecture.");
        yield return new WaitForSeconds(p);
        print("You circle the building.");
        yield return new WaitForSeconds(p);
        print("Time seems to be at a standstill here.");
        yield return new WaitForSeconds(p);
        print("Soon, you find an entrance.");
        yield return new WaitForSeconds(p);
        print("There's also a path leading out of it, towards the forest.");
        yield return new WaitForSeconds(p);
        print("... Maybe that can get you back to the path...?");
        yield return new WaitForSeconds(p);
        print("What do you do?");
        yield return new WaitForSeconds(p);
        print("Z - Enter the Temple             X - Follow the Path into the Forest           C - Check Inventory");
        triggerScript.cutscene = false;
        StopCoroutine(ApproachSound());
   }
   
   public IEnumerator AvoidSound()
    {
        triggerScript.cutscene = true;
        print("That's probably wise.");
        yield return new WaitForSeconds(p);
        print("I'm pretty sure the last time someone followed a freaky noise...");
        yield return new WaitForSeconds(p);
        print("... they died.");
        yield return new WaitForSeconds(p);
        print("...");
        yield return new WaitForSeconds(p);
        print("And on that morbid note, you continue down the path.");
        yield return new WaitForSeconds(p);
        triggerScript.cutscene = false;
        StartCoroutine(MonsterAttack());
        StopCoroutine(AvoidSound());
    }

    public IEnumerator MonsterAttack()
    {
        triggerScript.cutscene = true;
        print("Text is cool");
        triggerScript.monster = true;
        yield return new WaitForSeconds(p);
        triggerScript.cutscene = false;
        StopCoroutine(MonsterAttack());
    }

    public IEnumerator RunFromMonster()
    {
        triggerScript.cutscene = true;
        print("Running is futile.");
        yield return new WaitForSeconds(p);
        triggerScript.death = true;
        triggerScript.cutscene = false;
        StopCoroutine(RunFromMonster());
    }

    public IEnumerator FightTheMonster()
    {
        triggerScript.cutscene = true;
        print("You barely make a dent");
        yield return new WaitForSeconds(p);
        triggerScript.death = true;
        triggerScript.cutscene = false;
        StopCoroutine(FightTheMonster());
    }


    public IEnumerator TakeRightPath()
    {
        triggerScript.cutscene = true;
        print("You decide to take the right path. 'Choose the right', am I right?");
        yield return new WaitForSeconds(p);
        triggerScript.rightPath = true;
        print("Luckily, this path is nice and smooth.");
        yield return new WaitForSeconds(p);
        print("Perhaps this is a hiking trail?");
        yield return new WaitForSeconds(p);
        print("Regardless, you continue on your way enjoying the night breeze.");
        yield return new WaitForSeconds(p);
        print("The moonlight is shining brightly through the trees...");
        yield return new WaitForSeconds(p);
        print("And then you hear rustling in the bushes.");
        yield return new WaitForSeconds(p);
        print("You pause.");
        yield return new WaitForSeconds(p);
        print("Silence...");
        yield return new WaitForSeconds(p);
        print("...");
        yield return new WaitForSeconds(p);
        print("The bushes rustle with intent now. Something is emerging...!");
        yield return new WaitForSeconds(p);
        print("What?");
        yield return new WaitForSeconds(p);
        print("Shia LeBouf?!");
        yield return new WaitForSeconds(p);
        print("Oddly enough, he looks like he's been out here for a while.");
        yield return new WaitForSeconds(p);
        print("He is wearing face paint, his hair is mangled, and he's carrying a shotgun on his back.");
        yield return new WaitForSeconds(p);
        print("He looks you over, and chuckles.");
        yield return new WaitForSeconds(p);
        print("'You're not gonna last a second out here. I assume you want to go home?' he says.");
        yield return new WaitForSeconds(p);
        print("'How about this...'");
        yield return new WaitForSeconds(p);
        print("'You don't tell anyone I'm here, and I'll help you out.'");
        yield return new WaitForSeconds(p);
        print("You pause and think...");
        yield return new WaitForSeconds(p);
        print("It's not like anyone will believe you if you tell the truth about this situation.");
        yield return new WaitForSeconds(p);
        print("You agree to his terms.");
        yield return new WaitForSeconds(p);
        print("He nodds, and begins to lead the way.");
        yield return new WaitForSeconds(p);
        triggerScript.cutscene = false;
        triggerScript.rightPath = true;
        StopCoroutine(TakeRightPath());
    }
}
