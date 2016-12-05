using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RecycleLevel : MonoBehaviour {

    private Vector3 movePos;

    public List<SendToRecycler> recycleList;

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
        int i = UnityEngine.Random.Range(0, recycleList.Count - 1);

        movePos.x = Static.nextPosition;
        recycleList[0].transform.position = movePos;

        recycleList.RemoveAt(i);

        Static.nextPosition += Static.distance;
    }
}
