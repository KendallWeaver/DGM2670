using UnityEngine;
using System.Collections;

public class DelegateIntro : MonoBehaviour {

    // this is what all the examples look like on the internet
    public delegate void MyDelegate();
    // events call delegates safely
    public static MyDelegate MyEvent;

	// Use this for initialization
	void Start () {
        MyEvent();
	}
	

}
