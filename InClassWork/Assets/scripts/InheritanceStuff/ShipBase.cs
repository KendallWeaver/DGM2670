using UnityEngine;
using System.Collections;
using System;

public class ShipBase : MonoBehaviour, IDamage, IAttack {

    public void Attack()
    {
        print("I attack");
    }

    public void Damage()
    {
        print("Damage All");
    }

    // Use this for initialization
    public virtual void Start ()
    {
        Attack();
        Damage();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
