using UnityEngine;
using System.Collections;

public class Parent : MonoBehaviour {

	// Use this for initialization
	public virtual void Start ()
    {
        Walk();
	}

    void Walk()
    {
        print("I'M WALKING HERE");
    }

}
