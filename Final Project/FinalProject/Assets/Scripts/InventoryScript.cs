using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InventoryScript : MonoBehaviour {

    //public string[] inventory = {"Stick", "Band-aid", "Donut"};
    public List<string> theInventoryList = new List<string>();

    void Start()
    {
        theInventoryList.Add("Stick");
        theInventoryList.Add("Bandana");
        theInventoryList.Add("Donut");
    }
    
    /*
    public List<string> PlayerInventory()
    {
        foreach (string item in theInventoryList)
        {
            return item;
        }
    }*/

}
