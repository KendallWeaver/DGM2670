using UnityEngine;
using System.Collections;
using System;

public class SendThisRight : MonoBehaviour {

    public static Action<GameObject> SendThis;

	// Use this for initialization
	void Start () {
        if(SendThis != null)
            SendThis(gameObject);
	}

}
