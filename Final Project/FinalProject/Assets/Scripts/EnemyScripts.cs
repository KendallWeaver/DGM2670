using UnityEngine;
using System.Collections;

public class EnemyScripts : MonoBehaviour, IDamage<int>, IAttack
{
    public GameObject player;
    MainScriptWithUpdate playerStats;

    public GameObject trigger;
    Triggers triggerScript;

    public int enemyHealth = 1000;


    public void Start()
    {
        playerStats = player.GetComponent<MainScriptWithUpdate>();
        triggerScript = trigger.GetComponent<Triggers>();
    }

    public void Damage(int _d)
    {
        playerStats.health = playerStats.health - _d;
        triggerScript.death = true;
    }

    public void Attack()
    {
        Damage(1000);
    }
}
