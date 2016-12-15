using UnityEngine;
using System.Collections;

// Used to Implement Interfaces. Who would have guessed.

public interface IKill
{
    void Kill();
}

public interface IDamage<D>
{
    void Damage(D damageTaken);
}

public interface IAttack
{
    void Attack();
}
