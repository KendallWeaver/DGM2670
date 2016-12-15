using UnityEngine;
using System.Collections;

public class StoryText : ReturnToChoicesCoroutines
{
    // initializing the GameObject Trigger here
    public GameObject trigger;
    Triggers triggerScript;

    public GameObject enemy;
    EnemyScripts enemyScripts;
    public new static int p = 2;

    public void Start()
    {
        triggerScript = trigger.GetComponent<Triggers>();
        enemyScripts = enemy.GetComponent<EnemyScripts>();
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


    public new IEnumerator Intro()
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
        yield return new WaitForSeconds(p);
        print("Z - Left             X - Right           C - Check Inventory");
        triggerScript.cutscene = false;
        StopCoroutine(Intro());
    }

    public IEnumerator TakeLeftPath()
    {
        triggerScript.cutscene = true;
        print("You decide to take the left path.");
        yield return new WaitForSeconds(p);
        print("It's rough and rugged.");
        triggerScript.leftPath = true;
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
        print("How long has it been like that...?");
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
        StopCoroutine(TakeLeftPath());
    }

    public IEnumerator ReturnToSituation()
    {
        if (triggerScript.firstChoice == true)
        {
            //yield return new WaitForSeconds(p);
            print("You still have to decide which direction to go. Which way?");
            yield return new WaitForSeconds(p);
            print("Z - Left             X - Right           C - Check Inventory");
            StopCoroutine(ReturnToSituation());
        }
        if (triggerScript.leftPath == true)
        {
            //yield return new WaitForSeconds(p);
            print("There's still the suspicious noise to deal with.");
            yield return new WaitForSeconds(p);
            print("Z - Approach the Sound             X - Keep to the path           C - Check Inventory");
            StopCoroutine(ReturnToSituation());
        }
        if (triggerScript.approachNoise == true)
        {
            //yield return new WaitForSeconds(p);
            print("So anyway... Temple? Or Path?");
            yield return new WaitForSeconds(p);
            print("Z - Enter the Temple             X - Follow the Path into the Forest           C - Check Inventory");
            StopCoroutine(ReturnToSituation());
        }
        if (triggerScript.monster == true)
        {
            if (triggerScript.useArtifact == false)
            {
               // yield return new WaitForSeconds(p);
                print("That didn't solve the problem though...!");
                yield return new WaitForSeconds(p);
                print("Z - ATTACK!          X - RUN AWAY           C - Inventory");
                StopCoroutine(ReturnToSituation());
            }
        }
        if(triggerScript.rightPath == true)
        {
            //yield return new WaitForSeconds(p);
            print("But you still sense danger approaching you two...!");
            yield return new WaitForSeconds(p);
            print("Z - Hide in the nearby cave         X - Hide under the root           C - Check Inventory");
            StopCoroutine(ReturnToSituation());
        }
        if (triggerScript.treeRoot == true)
        {
            //yield return new WaitForSeconds(p);
            print("So anyway... The Fence of Death.");
            yield return new WaitForSeconds(p);
            print("Z - Climb the fence         X - Find the gate          C - Check Inventory");
            StopCoroutine(ReturnToSituation());
        }

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
   
   public IEnumerator EnterTemple()
    {
        triggerScript.cutscene = true;
        print("When do you ever get to enter an ancient temple?");
        yield return new WaitForSeconds(p);
        print("Embracing your new found fondness for adventure, you walk in.");
        triggerScript.approachNoise = false;
        yield return new WaitForSeconds(p);
        print("The halls are dank and dark.");
        yield return new WaitForSeconds(p);
        print("The only light source are the few torches that are lit.");
        yield return new WaitForSeconds(p);
        print("Wait... Why are the torches lit?");
        yield return new WaitForSeconds(p);
        print("Eh, it's probably not that important to know.");
        yield return new WaitForSeconds(p);
        print("What's really important is the potential discovery of treasure.");
        yield return new WaitForSeconds(p);
        print("The temple is a a bit complicated.");
        yield return new WaitForSeconds(p);
        print("After traversing it for a bit you're not sure where you are.");
        yield return new WaitForSeconds(p);
        print("You're almost about to give up, when suddenly...");
        yield return new WaitForSeconds(p);
        print("You happen upon a corridor that seems promising.");
        yield return new WaitForSeconds(p);
        print("It looks more ornate than the others.");
        yield return new WaitForSeconds(p);
        print("Sensing treasure, you walk down the hallway.");
        yield return new WaitForSeconds(p);
        print("A large room apears before you.");
        yield return new WaitForSeconds(p);
        print("Etchings cover the walls.");
        yield return new WaitForSeconds(p);
        print("Ahead of you is a pedestal with an object on top.");
        yield return new WaitForSeconds(p);
        print("You approach the pedastal...");
        yield return new WaitForSeconds(p);
        print("There's an orb resting on top of it.");
        yield return new WaitForSeconds(p);
        print("It seems to be emitting a strong power...");
        yield return new WaitForSeconds(p);
        print("...");
        yield return new WaitForSeconds(p);
        print("Yoink!");
        triggerScript.artifact = true;
        yield return new WaitForSeconds(p);
        print("Now with that out of the way, you decide to leave the temple.");
        yield return new WaitForSeconds(p);
        print("Oddly enough it's easier to find the exit than it was to find the artifact.");
        yield return new WaitForSeconds(p);
        print("Once outside, you go down the path back into the forest.");
        yield return new WaitForSeconds(p);
        print("It only took a few minutes to return to the original path.");
        yield return new WaitForSeconds(p);
        print("And with that, you continue.");
        yield return new WaitForSeconds(p);
        print("Time passes...");
        yield return new WaitForSeconds(p);
        StartCoroutine(MonsterAttack());
        StopCoroutine(EnterTemple());
    }

    public IEnumerator DontEnterTemple()
    {
        triggerScript.cutscene = true;
        print("You've seen enough Indiana Jones movies to know what's in there.");
        yield return new WaitForSeconds(p);
        triggerScript.approachNoise = false;
        print("Besides, you need to get home.");
        yield return new WaitForSeconds(p);
        print("There's no time for a detour.");
        yield return new WaitForSeconds(p);
        print("You set down the path back into the forest.");
        yield return new WaitForSeconds(p);
        print("It only took a few minutes to return to the original path.");
        yield return new WaitForSeconds(p);
        print("And with that, you continue.");
        yield return new WaitForSeconds(p);
        print("Time passes...");
        yield return new WaitForSeconds(p);
        StartCoroutine(MonsterAttack());
        StopCoroutine(DontEnterTemple());
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
        StartCoroutine(MonsterAttack());
        StopCoroutine(AvoidSound());
    }

    public IEnumerator MonsterAttack()
    {
        triggerScript.cutscene = true;
        print("You've been traveling for a while...");
        triggerScript.monster = true;
        yield return new WaitForSeconds(p);
        print("Your feet begin to hurt.");
        yield return new WaitForSeconds(p);
        print("You long for the comfort of your home.");
        yield return new WaitForSeconds(p);
        print("Hopefully you get back alive...");
        yield return new WaitForSeconds(p);
        print("In the distance, you hear something approaching.");
        yield return new WaitForSeconds(p);
        print("You pause, listening carefully.");
        yield return new WaitForSeconds(p);
        print("There is definitely something alive out there.");
        yield return new WaitForSeconds(p);
        print("You want to believe it's some kind of animal, like a bear.");
        yield return new WaitForSeconds(p);
        print("That's when you notice a large shadow in the distance...");
        yield return new WaitForSeconds(p);
        print("A shadow that is about triple your size.");
        yield return new WaitForSeconds(p);
        print("You make out large horns.");
        yield return new WaitForSeconds(p);
        print("You can hear it deeply breathing from where you are.");
        yield return new WaitForSeconds(p);
        print("That's definitely not normal.");
        yield return new WaitForSeconds(p);
        print("You decide to try to lay low...");
        yield return new WaitForSeconds(p);
        print("Perhaps you can hide.");
        yield return new WaitForSeconds(p);
        print("Or at least that what you had hoped.");
        yield return new WaitForSeconds(p);
        print("Like in the movies, you take a step forward and accidentally snap a twig.");
        yield return new WaitForSeconds(p);
        print("You quickly look up to see if the creature heard it.");
        yield return new WaitForSeconds(p);
        print("It had.");
        yield return new WaitForSeconds(p);
        print("This is a game; you expect me to let you off like that?");
        yield return new WaitForSeconds(p);
        print("The monster turns towards your direction.");
        yield return new WaitForSeconds(p);
        print("It's eyes glowing bright.");
        yield return new WaitForSeconds(p);
        print("The creature bounds towards you.");
        yield return new WaitForSeconds(p);
        print("Jumping in front of you, it lets out a mighty roar.");
        yield return new WaitForSeconds(p);
        print("Now's the time for action!");
        yield return new WaitForSeconds(p);
        print("Z - ATTACK!          X - RUN AWAY           C - Inventory");
        triggerScript.cutscene = false;
        StopCoroutine(MonsterAttack());
    }

    public IEnumerator RunFromMonster()
    {
        triggerScript.cutscene = true;
        print("Fighting definitely doesn't seem like the best idea right now.");
        yield return new WaitForSeconds(p);
        print("You frantically dash away.");
        yield return new WaitForSeconds(p);
        print("You don't know where you're heading, but you don't care.");
        yield return new WaitForSeconds(p);
        print("...!");
        yield return new WaitForSeconds(p);
        print("A smashing blow strikes you from behind.");
        yield return new WaitForSeconds(p);
        print("Something in your body cracks from the impact.");
        yield return new WaitForSeconds(p);
        print("You fly forward from it's force, crashing into the ground when you land.");
        yield return new WaitForSeconds(p);
        print("You roll several feet, cutting and brusing your skin from the awful impact.");
        yield return new WaitForSeconds(p);
        print("Coming to a hault, you notice the monster is still charging towards you.");
        yield return new WaitForSeconds(p);
        print("It followed you...!");
        yield return new WaitForSeconds(p);
        print("It attacked you!");
        yield return new WaitForSeconds(p);
        print("You try to move, hoping to get away.");
        yield return new WaitForSeconds(p);
        print("Immense pain travels all over your body.");
        yield return new WaitForSeconds(p);
        print("You've definitely broken some bones.");
        yield return new WaitForSeconds(p);
        print("The monster is closer...");
        yield return new WaitForSeconds(p);
        print("Maybe there's still time...!");
        yield return new WaitForSeconds(p);
        print("... You still can't move!");
        yield return new WaitForSeconds(p);
        print("Closer....");
        yield return new WaitForSeconds(p);
        print("... Is this it...?");
        yield return new WaitForSeconds(p);
        print("The monster stands above you.");
        yield return new WaitForSeconds(p);
        print("You want to call out for help...!");
        yield return new WaitForSeconds(p);
        print("SOMEBODY! PLEASE!!");
        yield return new WaitForSeconds(p);
        print("...");
        yield return new WaitForSeconds(p);
        print("But nobody came.");
        yield return new WaitForSeconds(p);
        triggerScript.death = true;
        triggerScript.cutscene = false;
        StopCoroutine(RunFromMonster());
    }

    public IEnumerator FightTheMonster()
    {
        triggerScript.cutscene = true;
        print("You're not going down with out a fight!");
        yield return new WaitForSeconds(p);
        print("Grabbing a nearby rock, you prepare for your next move.");
        yield return new WaitForSeconds(p);
        print("The monster is staring you down.");
        yield return new WaitForSeconds(p);
        print("It's breath is so foul...");
        yield return new WaitForSeconds(p);
        print("It leans towards you...");
        yield return new WaitForSeconds(p);
        print("And you chuck the rock at it's face.");
        yield return new WaitForSeconds(p);
        print("Score! You actually hit it's eye!");
        yield return new WaitForSeconds(p);
        print("It's roar pierces your ears.");
        yield return new WaitForSeconds(p);
        print("It attacks back!");
        yield return new WaitForSeconds(p);
        print("And then everything goes dark.");
        yield return new WaitForSeconds(p);
        enemyScripts.Attack();
        triggerScript.cutscene = false;
        StopCoroutine(FightTheMonster());
    }
    public IEnumerator DefeatMonster()
    {
        triggerScript.cutscene = true;
        print("You beat the monster by the power of the orb!");
        yield return new WaitForSeconds(p);
        triggerScript.victory = true;
        triggerScript.cutscene = false;
        StopCoroutine(DefeatMonster());
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
        triggerScript.rightPath = true;
        triggerScript.shiaLeBouf = true;
        StartCoroutine(ShiaTellsYouToHide());
        StopCoroutine(TakeRightPath());
    }

    public IEnumerator ShiaTellsYouToHide()
    {
        yield return new WaitForSeconds(p);
        print("There's a strang noise... Shia tells you to hide!");
        yield return new WaitForSeconds(p);
        print("Z - Hide in the nearby cave         X - Hide under the root           C - Check Inventory");
        triggerScript.cutscene = false;
        StopCoroutine(ShiaTellsYouToHide());
    }

    public IEnumerator HideInCave()
    {
        triggerScript.cutscene = true;
        print("Clearly the cave is the smartest option!");
        yield return new WaitForSeconds(p);
        print("You go really deep into the cave.");
        yield return new WaitForSeconds(p);
        print("However it's really dark in here.");
        yield return new WaitForSeconds(p);
        print("You couldn't see where you were going.");
        yield return new WaitForSeconds(p);
        print("You fell into a hole and died.");
        yield return new WaitForSeconds(p);
        triggerScript.death = true;
        triggerScript.cutscene = false;
        StopCoroutine(ShiaTellsYouToHide());
    }

    public IEnumerator HideUnderRoot()
    {
        triggerScript.cutscene = true;
        print("Clearly the tree root is the smartest option!");
        yield return new WaitForSeconds(p);
        triggerScript.rightPath = false;
        print("You hide under the root.");
        yield return new WaitForSeconds(p);
        print("As you hide, you hear Shia scream in pain.");
        yield return new WaitForSeconds(p);
        print("Once everything is silent, you wait a bit longer before leaving.");
        yield return new WaitForSeconds(p);
        print("You find Shia's corpse.");
        yield return new WaitForSeconds(p);
        print("That's unfortunate.");
        triggerScript.shiaLeBouf = false;
        yield return new WaitForSeconds(p);
        print("You continue on your way.");
        yield return new WaitForSeconds(p);
        StartCoroutine(ApproachingTheFence());
        StopCoroutine(HideUnderRoot());
    }

    public IEnumerator ApproachingTheFence()
    {
        triggerScript.cutscene = true;
        print("A fence appears in front of you.");
        yield return new WaitForSeconds(p);
        print("Do you climb it? Or find the gate?");
        yield return new WaitForSeconds(p);
        print("Z - Climb the fence         X - Find the gate          C - Check Inventory");
        triggerScript.cutscene = false;
        StopCoroutine(ApproachingTheFence());
    }

    public IEnumerator ClimbTheFence()
    {
        triggerScript.cutscene = true;
        print("You climb the fence.");
        yield return new WaitForSeconds(p);
        triggerScript.cutscene = false;
        triggerScript.victory = true;
        StopCoroutine(ClimbTheFence());
    }

    public IEnumerator FindTheGate()
    {
        triggerScript.cutscene = true;
        print("Better find a gate... Just in case.");
        yield return new WaitForSeconds(p);
        print("You walk along the fence.");
        yield return new WaitForSeconds(p);
        print("Little did you know...");
        yield return new WaitForSeconds(p);
        print("You were being followed this whole time.");
        yield return new WaitForSeconds(p);
        print("That monster that killed Shia LeBouf?");
        yield return new WaitForSeconds(p);
        print("It's back.");
        yield return new WaitForSeconds(p);
        print("But you never knew what hit you~");
        yield return new WaitForSeconds(p);
        triggerScript.death = true;
        triggerScript.cutscene = false;
        StopCoroutine(FindTheGate());
    }

    public IEnumerator GameOver()
    {
        print("GAME OVER");
        yield return new WaitForSeconds(p);
        StopCoroutine(GameOver());
    }
}
