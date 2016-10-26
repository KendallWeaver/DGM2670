using UnityEngine;
using System.Collections;

public class StarControl : MonoBehaviour {

    public float endTime = 3;

    public int forcetime = 2;

    private bool canAddForce = true;
    public float forceDuration = 0.1f;

    private Rigidbody rigid;
    private Vector3 forceVector;
    private float force;
    public float forceRange = 30;

    private Vector3 tortVector;

    //IEnumerator EndStar()
    //{
    //    yield return new WaitForSeconds(endTime);
    //}
    
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        StartCoroutine(RunRandomForce());
    }

    IEnumerator RunRandomForce()
    {
        force = Random.Range(-forceRange, forceRange);
        while(forcetime > 0)
        {

            yield return new WaitForSeconds(forceDuration);
            forceVector.x = force;
            tortVector.z = force/force;
            rigid.AddTorque(tortVector);
            rigid.AddForce(forceVector);
            forcetime--;
        }
    }

	void OnCollisionEnter ()
    {
        Destroy(gameObject, endTime);
    }
	
}
