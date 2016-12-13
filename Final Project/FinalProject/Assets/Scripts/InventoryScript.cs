// Purpose of this script is suppose to be the main location for anything related to the inventory, including items you may find
public class InventoryScript : MainScriptWithUpdate
{

    // Script that is used in the MainScriptWithUpdate to collect item
    /* print("You got a " + InventoryScript.MethodName(item));
       inventory.Add(InventoryScript.Method(item));

           OR

       print("You got a " + gotItem.MethodName(item));
       inventory.Add(gotItem.Method(item));
       */

    // call this when the artifact is found
    internal static string GotArtifact(string item)
    {
        item = "Weird Artifact";
        return item;
    }

    // call this when gum is found
    internal static string GotGum(string item)
    {
        item = "Stick of Gum";
        return item;
    }

    public void UseDonut()
    {
        print("You ate the donut. You're glad that it's still good and not made of spiders.");
        inventory.Remove("Donut");
    }
}
