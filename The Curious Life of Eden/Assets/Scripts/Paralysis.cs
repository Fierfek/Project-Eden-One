using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralysis : Effector
{
    bool onEntity;

    private void Start()
    {
        onEntity = (gameObject.GetComponent<Health>() != null);
        type = EffectType.Paralysis;
    }
    protected override void DoEffect()
    {
        if(onEntity)
            gameObject.GetComponent<PlayerMovement>().moveSpeed = 0;
    }

    protected override void RevertEffect()
    {
        if (onEntity)
            gameObject.GetComponent<PlayerMovement>().moveSpeed = GetComponent<PlayerMovement>().defaultSpeed;
    }
}
