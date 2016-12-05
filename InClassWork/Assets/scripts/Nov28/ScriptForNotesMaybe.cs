using UnityEngine;
using System.Collections;

public class ScriptForNotesMaybe : MonoBehaviour {

    // switch statements are good for multiple options
    // if statements are true and false in a sense
    // delegates delegates larger tasks to smaller stuff
    // action is an event and delegate (they send/receive information ???)
    //Good Drag Object script
    /* void OnMouseDown()
     * {
     *  screenPoint = Camera.main.WorldToScreenPointr(gameObject.transform.position);
     *  offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
     * }
     * void OnMouseDrag()
     * {
     *  clickPosition = Input.mousePosition;
     *  mousePosition = Camera.main.ScreenToWorldPoint(clickPosition) + offset;
     *  transform.position = movePosition;
     * }
     */

    // Delegates are a good way to populate lists
    // public static Action<NavAgent> SendToGenerator;
    // public NavAgent navAgent;
    // in Start() ----> SendToGenerator(navAgent);

    // in the generator script; it looks like it manages everything??

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
