using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinotaurCelebration : CelebrationState
{
    public override void OnEnable()
    {
        Animator.Play("Minotaur Celebration");
    }
}
