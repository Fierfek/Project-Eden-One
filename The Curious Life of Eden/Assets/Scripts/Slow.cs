using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slow : Effector
{
    bool onEntity;
    float defaultSpeed;
    // Use this for initialization
    void Start ()
    {

        onEntity = (gameObject.GetComponent<PlayerMovement>() != null);
        type = EffectType.Slow;
        defaultSpeed = gameObject.GetComponent<PlayerMovement>().movementSpeed;

    }

    // Update is called once per frame
    protected override void DoEffect()
    {

        if (onEntity)
        {
            gameObject.GetComponent<PlayerMovement>().movementSpeed = defaultSpeed / 2;
            onEntity = false;
        }
    }

    protected override void RevertEffect()
    {
            gameObject.GetComponent<PlayerMovement>().movementSpeed = defaultSpeed;
    }
}
