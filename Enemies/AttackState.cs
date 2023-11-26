using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public abstract class AttackState : State
{
    [SerializeField] protected int Damage;
    [SerializeField] protected float Delay;

    protected Animator Animator;
    protected float LastAttackTime;

    private void Start()
    {
        Animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if(LastAttackTime <= 0)
        {
            Attack(Target);
            LastAttackTime = Delay;
        }

        LastAttackTime -= Time.deltaTime;
    }

    public abstract void Attack(Player target);
}
