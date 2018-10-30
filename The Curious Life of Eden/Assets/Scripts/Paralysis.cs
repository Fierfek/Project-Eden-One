using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralysis : Effector
{
    bool onEntity;
    float defaultSpeed;

    private void Start()
    {
        onEntity = (gameObject.GetComponent<PlayerMovement>() != null);
        type = EffectType.Paralysis;
        defaultSpeed = gameObject.GetComponent<PlayerMovement>().movementSpeed;
        timeElapsed = 0f;
    }
    protected override void DoEffect()
    {
        if(onEntity)
            gameObject.GetComponent<PlayerMovement>().movementSpeed = 0;
    }

    protected override void RevertEffect()
    {

        if (onEntity)
            gameObject.GetComponent<PlayerMovement>().movementSpeed = defaultSpeed;

    }
}