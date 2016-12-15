using UnityEngine;
using System.Collections;

public class ReturnToChoicesCoroutines : MonoBehaviour
{
    // At least that's what I'm calling it.
    // Mainly using this as a second Inheritance script

    // creating a int for the pause because Magic Numbers are bad
    // Also putting it here to show the instance of polymorphism
    public static int p = 1;

    // I'm mainly putting this here to show polymorphism.
    // Let's say this is the original.
    // Now, in the StoryText.cs, the script that's inheriting from this one, it overrides this IEnumerator Function
    public IEnumerator Intro()
    {
        
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
        
        StopCoroutine(Intro());
    }

}
