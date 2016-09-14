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

    // sliding variables
    public int slideDuration = 50;
    public float slideTime = 0.1f;

    // Use this for initialization
    void Start ()
    {
        myCC = GetComponent<CharacterController>();
	}

    // Coroutine for sliding the character
    IEnumerator Slide()
    {
        // temporary int is set to equal the same value of slideDuration
        int durationTemp = slideDuration;

        // store value of speed for later when sliding happens
        float speedTemp = speed;
        speed += speed;
        // loop runs "while" slideDuration is greater than zero
        while (slideDuration > 0)
        {
            
            // decrement
            slideDuration--;
            // yield "holds" the coroutine
            // return "sends" to the coroutine to do an operation while yielding
            // new creates an instance of an object
            // WaitForSeconds is an object that is self-explanatory
            yield return new WaitForSeconds(slideTime);
            // increase speed
        }

        // reset speed
        speed = speedTemp;

        slideDuration = durationTemp;
    }

	// Update is called once per frame
	void Update () {
	
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < jumpCountMax -1)
        {
            jumpCount++;
            tempPos.y = jumpSpeed;
        }

        if (Input.GetKey(KeyCode.RightArrow) && Input.GetKeyDown(KeyCode.S))
        {
            StartCoroutine(Slide());
        }

        if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKeyDown(KeyCode.S))
        {
            StartCoroutine(Slide());
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
