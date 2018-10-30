using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poison : Effector {
    bool onEntity;
    Health hp;
    float counter;
	// Use this for initialization
	void Start () {
        onEntity = (gameObject.GetComponent<Health>() != null);
        type = EffectType.Poison;
        if(onEntity)
            hp = GetComponent<Health>();
        counter = 0f;
	}

    protected override void DoEffect()
    {
        if(counter <= timeElapsed)
        {
            hp.takeDamage(1);
            counter += 1f;
        }
    }

    protected override void RevertEffect()
    {
    }
}
