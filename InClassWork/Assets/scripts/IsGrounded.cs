using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]

public class IsGrounded : MonoBehaviour {

    public Vector3 startPoint;
    private CharacterController myCC;
    private float gravity = -5;
    private Vector3 tempP;

	// Use this for initialization
	void Start ()
    {
        startPoint = transform.position;
        myCC = GetComponent<CharacterController>();
	}
	
    void OnTriggerEnter()
    {
        //if(myCC.velocity.x < 40)
          //  gravity *= 1.5f;
        transform.position = startPoint;
    }

	// Update is called once per frame
	void Update ()
    {
        tempP.y = gravity;
        myCC.Move(tempP * Time.deltaTime);

        if (myCC.isGrounded)
        {
            tempP.x = gravity;
        }
        else
        {
            tempP.x = 0;
        }
	}
}
