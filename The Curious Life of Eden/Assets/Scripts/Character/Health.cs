using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	public int hp, hp_max, temp_max;

    public Health() {

	}

	public Health(int hp, int hp_max) {
		this.hp = hp;
		this.hp_max = hp_max;
		this.temp_max = hp_max;
	}

	public void takeDamage(int damage) {
		hp -= damage;

		if(hp <= 0) {
			hp = 0;
		}
	}

    public void heal(int amount)
    {
        hp += amount;

        if (temp_max > hp_max)
        {
            if (hp > temp_max)
            {
                hp = temp_max;
            }
        }
        else if (temp_max <= hp_max)
        {
            if (hp > temp_max)
            {
                hp = temp_max;
            }
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
