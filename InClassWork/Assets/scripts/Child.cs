using UnityEngine;
using System.Collections;

public class Child : Parent {

    // this overrides the Parent Start
    public override void Start()
    {
        // Calls to the parent class
        base.Start();
        Bark();
    }

    void Bark()
    {
        print("I'm dead inside");
    }
}
