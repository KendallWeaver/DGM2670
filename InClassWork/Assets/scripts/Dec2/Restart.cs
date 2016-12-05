using UnityEngine;
using System.Collections;
using System;

public class Restart : MonoBehaviour {

    public static Action ResetLevel;


	// Use this for initialization
	void Start () {
       EndGame.GameOver += OnReset;
	}
	
	// Update is called once per frame
	void OnReset () {
       ResetLevel();	
	}
}
