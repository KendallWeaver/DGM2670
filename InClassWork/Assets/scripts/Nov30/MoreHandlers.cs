using UnityEngine;
using System.Collections;

public class MoreHandlers : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        DelegateIntro.EventString += ES;
        DelegateIntro.MyEvent += ME;
       // DelegateIntro.EventWithArgs += EA;
        DelegateIntro.EventReturnArgs += ER;
    }

    private string ER(string arg1)
    {
        return "I love" + arg1;
    }


    private string EA(string obj)
    {
        return "But I love " + obj;
    }

    private void ME()
    {
        print("Cool Beans");
    }

    private string ES()
    {
        return "Dogs are better";
    }

}
