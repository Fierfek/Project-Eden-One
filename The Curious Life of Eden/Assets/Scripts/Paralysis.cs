using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralysis : Effector {


    public override void DoEffect()
    {
        gameObject.GetComponent<Health>().moveSpeed = 0;
    }

    public override void RevertEffect()
    {
        gameObject.GetComponent<Health>().moveSpeed = GetComponent<Health>().defaultSpeed;
    }
}
