using UnityEngine;
using System.Collections;


// Interface is like a list of requirements
public interface PowerUp
{
    // get the power; set the power;
    int power { get; set; }


    void Start();

    void OnTriggerEnter();

}
