using UnityEngine;
using System.Collections;

public class Triggers
{
    // AS A NOTE: All bools start as "false"

        // figure this out laterrrrr
    public bool cutscene;

    // First choices
    public bool leftPath; // Go to 2a
    public bool rightPath; // Go to 2b

    // 2a: Player encounters a scary noise
    public bool approachNoise; // if they approach, go to 2a.a. If not, go to 2a.b

    // 2b: Suddenly Shia LeBouf!
    public bool shiaLeBouf; 
    public bool partyMember; // Got Party Member. Go to 3a

    // 2a.a: Comes across an ancient temple
    public bool explore; // If they explore, go to 2.a.b. If not, go to 2.a.a

    // 2a.a.a: Finds a hidden artifact
    public bool artifact; // The artifact is needed to beat the monster. Go to 2.a.a.

    // 2a.a.b: A MONSTER!
    public bool monster;
    public bool victory; // Did they win? If yes, WIN. If no, DEATH

    // 3a: Shia LeBouf warns you to hide
    public bool treeRoot; // Go to 3a.a
    public bool cave;   // Go to 3a.b

    // 3a.a: Shia LeBouf Sacrificed himself to save you. You happen upon a fence.
    public bool climbFence; // FENCE WIN
    public bool findGate; // The monster that killed Shia LeBouf kills you.
}