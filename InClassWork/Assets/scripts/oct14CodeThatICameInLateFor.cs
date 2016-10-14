using UnityEngine;
using System.Collections;
using System;

// Apparently this was called "DelegateGeneral"
// As a note for the Sprite Section we went over; Since I'm technically "not" working on a personal game or have a class that focuses on it,
// I'll just take notes about it at the very bottom.
public class oct14CodeThatICameInLateFor : MonoBehaviour {

    Action<oct14CodeThatICameInLateFor> Move;
    Action Idle;
    Action Jump;

    int speed = 200;

    void MoveHandler(oct14CodeThatICameInLateFor obj)
    {
        print("Move at " + obj.speed + " mph");
        Move = null;
        Idle = IdleHandler;
    }

    void JumpHandler()
    {
        print("Jump");
        Jump = null;
    }

    void IdleHandler()
    {
        print("Idle");
        Idle = null;
        Jump = JumpHandler;
    }

	// Use this for initialization
	void Start () {
        Move = MoveHandler;
        Idle = IdleHandler;
        Jump = JumpHandler;
	}
	
	// Update is called once per frame
	void Update () {
        if(Move != null)
            Move(this);
        if (Idle != null)
            Idle();
        if (Jump != null)
            Jump();
	}
}
// Sprite Animation notes
// it's complicated.
// But it seems that the gist of it is that when a statement is true, an animation should play if done correctly
// Each kind of motion has a different state