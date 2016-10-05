using UnityEngine;
using System.Collections;
using System;

public class UserInput : MonoBehaviour {

    public static Action<KeyCode> UserInputs;

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKeyDown(KeyCode.RightArrow) && UserInputs != null)
        {
            UserInputs(KeyCode.RightArrow);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && UserInputs != null)
        {
            UserInputs(KeyCode.LeftArrow);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && UserInputs != null)
        {
            UserInputs(KeyCode.UpArrow);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && UserInputs != null)
        {
            UserInputs(KeyCode.DownArrow);
        }



    }
}
