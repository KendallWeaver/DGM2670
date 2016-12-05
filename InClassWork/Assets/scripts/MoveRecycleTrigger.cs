using UnityEngine;
using System.Collections;

public class MoveRecycleTrigger : MonoBehaviour {

    private Vector3 movPos;
    public float speed = 1;

	// Update is called once per frame
	void Update ()
    {
        movPos.x = speed*Time.deltaTime;
        transform.Translate(movPos);
	}
}
