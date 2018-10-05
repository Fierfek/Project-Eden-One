<<<<<<< HEAD
﻿using UnityEngine;

public class Health : MonoBehaviour
{
	public int health;
    public float moveSpeed;
    public float defaultSpeed;

	public void takeDamage(int damage)
	{
		health -= damage;
		if (health < 0)
		{
			die();
		}
	}

    /*<summary>
     * This function takes an array of GameObjects from the collided weapon
     * Each GameObject should contain an Effector that will be cloned onto the Entity
     * </summary>
     */
    public void takeEffects(GameObject[] weaponEffectors)
    {
        foreach(GameObject effectorObject in weaponEffectors)
        {
            Effector effect = effectorObject.GetComponent<Effector>();
            //This switch case will add scripts to the gameObject depending on the type
            //and adds corresponding attributes of each found Effector (e.g. timeDuration)
            switch (effect.type)
            {
                case Effector.EffectType.Paralysis:
                        Paralysis entityEffect = gameObject.AddComponent<Paralysis>();
                        entityEffect.timeDuration = effect.timeDuration;
                        entityEffect.type = effect.type;
                    break;
            }
        }
    }

	private void die()
	{
		Destroy(gameObject);
	}
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	private int hp, hp_max, temp_max;

	public Health() {

	}

	public Health(int hp, int hp_max) {
		this.hp = hp;
		this.hp_max = hp_max;
		this.temp_max = hp_max;
	}

	public void takeDamage(int damage) {
		hp -= damage;

		if(hp < 0) {
			hp = 0;
		}
	}

	public int getHealth() {
		return hp;
	}

	public int getMax() {
		if(temp_max != hp_max) {
			return temp_max;
		} else {
			return hp_max;
		}
	}

	public void setMaxHP(int newMax) {
		if (newMax < hp) {
			hp = hp_max = newMax;
		} else {
			hp_max = newMax;
		}
	}

	public void setTempMax(int newMax) {
		temp_max = newMax;
	}
}
>>>>>>> master
