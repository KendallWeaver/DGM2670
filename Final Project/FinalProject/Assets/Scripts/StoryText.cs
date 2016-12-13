using UnityEngine;
using System.Collections;

public class StoryText : MonoBehaviour
{
    Triggers triggerScript = new Triggers();

    public IEnumerator Intro()
    {
        triggerScript.cutscene = true;
        print("It's a late night...");
        yield return new WaitForSeconds(2);
        print("You wake up in a forest for some random reason.");
        yield return new WaitForSeconds(2);
        print("It's not safe at night; you need to survive the night");
        yield return new WaitForSeconds(2);
        print("You begin walking.");
        yield return new WaitForSeconds(2);
        print("You approach a fork in the road. Which way do you go? Left? Or Right?");
        triggerScript.cutscene = false;
        StopCoroutine(Intro());
    }
}
