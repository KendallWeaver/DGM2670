// Purpose of this script is suppose to be the main location for anything related to the inventory, including items you may find
// This also ended up being the health and damage script...?
using System;

public class InventoryScript : MainScriptWithUpdate, IDamage<int>, IAttack
{
    // Script that is used in the MainScriptWithUpdate to collect item
    /* print("You got a " + InventoryScript.MethodName(item));
       inventory.Add(InventoryScript.Method(item));

           OR

       print("You got a " + gotItem.MethodName(item));
       inventory.Add(gotItem.Method(item));
       */

    public void Damage(int _d)
    {
        
    }

    public void Attack()
    {

    }

    // call this when the artifact is found
    internal static string GotArtifact(string item)
    {
        item = "Weird Artifact";
        return item;
    }

    internal static void UseDonut(bool _t)
    {
        switch (_t)
        {
            case true:
                print("You threw the donut at it. It ate it. It's still mad.");
                break;
            case false:
                print("You ate the donut. You're glad that it's still good and not made of spiders.");
                break;
        }
    }

    internal static void UseStick(bool _t)
    {
        switch (_t)
        {
            case true:
                print("You threw the stick at the monster. 10 damage!");
                break;
            case false:
                print("You threw the stick. It did not come back.");
                break;
        }
    }

    private static void IDamage(int v)
    {
        
    }

    internal static void WearBandana()
    {
        print("You put the bandana on your head. Now you feel manly.");
    }

    internal static void UseArtifact(bool _t)
    {
        switch (_t)
        {
            case true:
                print("You used the artifact!");
                break;
            case false:
                print("Nothing happened");
                break;
        }
    }

}
