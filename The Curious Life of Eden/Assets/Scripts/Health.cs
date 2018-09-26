using UnityEngine;

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
                        gameObject.AddComponent<Paralysis>();
                        GetComponent<Paralysis>().timeDuration = effect.timeDuration;
                        GetComponent<Paralysis>().type = effect.type;
                    break;
            }
        }
    }

	private void die()
	{
		Destroy(gameObject);
	}
}
