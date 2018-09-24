using UnityEngine;

public class Health : MonoBehaviour
{
	public int health;

	public void takeDamage(int damage)
	{
		health -= damage;
		if (health < 0)
		{
			die();
		}
	}

	private void die()
	{
		Destroy(gameObject);
	}
}
