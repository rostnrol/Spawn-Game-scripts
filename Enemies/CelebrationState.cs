using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public abstract class CelebrationState : State
{
    protected Animator Animator;

    private void Awake()
    {
        Animator = GetComponent<Animator>();
    }

    public abstract void OnEnable();

    private void OnDisable()
    {
        Animator.StopPlayback();
    }
}
