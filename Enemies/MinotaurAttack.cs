using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinotaurAttack : AttackState
{
    public override void Attack(Player target)
    {
        Animator.Play("Minotaur Attack");
        target.ApplyDamage(Damage);
    }
}
