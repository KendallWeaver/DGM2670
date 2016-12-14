using UnityEngine;
using System.Collections;

// I realized that I needed a separate script for removing items from the inventory
public class RemovingItems : MainScriptWithUpdate
{

public IEnumerator PauseToRemoveItems()
    {
        print(inventory.IndexOf("Stick"));
        InventoryScript.UseStick();
        yield return new WaitForSeconds(3);
        inventory.RemoveAt(0);
        StopCoroutine(PauseToRemoveItems());
    }

}
