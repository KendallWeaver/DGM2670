using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

    /*
     * 
     * Attempted to get the code, but since the MoveUsingArrowKeys is incomplete, it won't run
     * Try to problem solve on your own later
    Vector3 moveDirection;
    public float speed = 10;
    public float gravity = 1;
    public float jumpSpeed = 30;
    CharacterController cc;


	// Use this for initialization
	void Start ()
    {
        cc = GetComponent<CharacterController>();
        MoveUsingArrowKeys.MoveOnArrows = +Move;
        MoveUsingArrowKeys.RotateOnArrows += Rotate ;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Rotate(float _rotateInY)
    {
        transform.Rotate(0, _rotateInY, 0);
    }

    void Move(float _moveInZ)
    {
        if (cc.isGrounded)
        {
            if(Input.GetKey(KeyCode.Space))
            {
                moveDirection.y = jumpSpeed * Time.deltaTime;
            }

            moveDirection.y -= gravity * Time.deltaTime;

            moveDirection.x = _moveInZ * speed * Time.deltaTime;
            moveDirection = transform.TransformDirection(moveDirection * Time.deltaTime);
            cc.Move(MoveDirection);
        }

    }
    */
}
