using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotatoAttack : AttackState
{
    public override void Attack(Player target)
    {
        Animator.Play("Potato Attack");
        target.ApplyDamage(Damage);
    }
}
