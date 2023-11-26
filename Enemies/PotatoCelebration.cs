using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotatoCelebration : CelebrationState
{
    public override void OnEnable()
    {
        Animator.Play("Potato Celebration");
    }
}
