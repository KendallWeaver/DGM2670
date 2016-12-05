using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FindThingsWrong : MonoBehaviour {

    public List<GameObject> level;

	// Use this for initialization
	void Start () {

        // This will search every object and find the one called "Plane"
        GameObject temp = GameObject.Find("Plane");
        level.Add(temp);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
