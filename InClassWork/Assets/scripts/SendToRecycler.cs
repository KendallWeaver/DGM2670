using UnityEngine;
using System.Collections;
using System;

public class SendToRecycler : MonoBehaviour {

    public static Action<SendToRecycler> SendThis;


	// Use this for initialization
	void Start ()
    {
        SendThis(this);
	}
	
}
