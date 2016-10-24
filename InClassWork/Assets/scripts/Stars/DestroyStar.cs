using UnityEngine;
using System.Collections;

public class DestroyStar : MonoBehaviour {

    public float endTime = 3;

    //IEnumerator EndStar()
    //{
    //    yield return new WaitForSeconds(endTime);
    //}


	void OnCollisionEnter ()
    {
        Destroy(gameObject, endTime);
    }
	
}
