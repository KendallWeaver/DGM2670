using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RecycleLevel : MonoBehaviour {

    private Vector3 movePos;

    private List<SendToRecycler> recycleList;

    void SendThisHandler(SendToRecycler _r)
    {
        recycleList.Add(_r);
        print(recycleList.Count);
    }



    void Start()
    {
        recycleList = new List<SendToRecycler>();

        SendToRecycler.SendThis += SendThisHandler;
    }

    void OnTriggerEnter()
    {
        movePos.x = Static.nextPosition;
        recycleList[0].transform.position = movePos;
        Static.nextPosition += Static.distance;
    }
}
