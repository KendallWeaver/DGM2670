using UnityEngine;
using System.Collections;

public class DoubleJump : MonoBehaviour {

    public CharacterController myCC;
    private Vector3 tempPos;
    public float speed = 4f;
    public float gravity = 1f;
    public float jumpSpeed = 10f;
    public int jumpCount = 0;
    public int jumpCountMax = 2;

	// Use this for initialization
	void Start ()
    {
        myCC = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
	
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < jumpCountMax -1)
        {
            jumpCount++;
            tempPos.y = jumpSpeed;
        }

        if (myCC.isGrounded)
        {
            jumpCount = 0;
        }

        tempPos.y -= gravity;

        tempPos.x = speed * Input.GetAxis("Horizontal");
        myCC.Move(tempPos * Time.deltaTime);
	}
}
