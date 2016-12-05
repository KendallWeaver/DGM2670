using UnityEngine;
using System.Collections;
using System;

public class EnemyAttack : MonoBehaviour, IAttack, IDamage {


    public void Attack()
    {
        print("I attack");
    }

    public void Damage()
    {
        print("Damage All");
    }

    // Use this for initialization
    void Start ()
    {
        Attack();
        Damage();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
