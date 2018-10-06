using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poison : Effector {
    bool onEntity;
    Health hp;
	// Use this for initialization
	void Start () {
        onEntity = (gameObject.GetComponent<Health>() != null);
        type = EffectType.Poison;
        if(onEntity)
            hp = GetComponent<Health>();
	}

    protected override void DoEffect()
    {
        hp.takeDamage(1);
    }

    protected override void RevertEffect()
    {
    }
}
