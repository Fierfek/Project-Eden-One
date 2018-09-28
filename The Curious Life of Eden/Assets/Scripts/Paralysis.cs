using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralysis : Effector {
    bool onEntity;

    private void Start()
    {
        onEntity = (gameObject.GetComponent<Health>() != null);
    }
    public override void DoEffect()
    {
        if(onEntity)
            gameObject.GetComponent<Health>().moveSpeed = 0;
    }

    public override void RevertEffect()
    {
        if (onEntity)
            gameObject.GetComponent<Health>().moveSpeed = GetComponent<Health>().defaultSpeed;
    }
}
