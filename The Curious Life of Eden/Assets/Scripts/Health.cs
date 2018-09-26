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

    public void takeEffects(GameObject[] e)
    {
        foreach (GameObject effect in e)
        {
            if (effect.GetComponent<Effector>() != null)
                gameObject.AddComponent<>();
        }
    }

	private void die()
	{
		Destroy(gameObject);
	}
}
