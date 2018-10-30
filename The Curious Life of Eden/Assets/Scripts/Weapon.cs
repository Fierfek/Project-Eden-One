using UnityEngine;

public class Weapon : Item, IAttackable
{
    public GameObject[] effects;
    public int damage;
    public bool isRanged;

    /// <summary>
    /// This function is the most generic form of attack for a weapon
    /// </summary>
    public virtual void attack()
    {
        Debug.Log("Attacking with generic weapon!");
    }

    /// <summary>
    /// This function is for handling each weapons skill as each weapon has a secret ability
    /// that differentiates itself from other weapons
    /// </summary>
    public virtual void OnSkillUsed()
    {

    }

    public override void OnItemUsed()
    {

    }

    /// <summary>
    /// Dealing with objects with colliders entering the weapon
    /// </summary>
    /// <param name="other"></param>
    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        Health healthScript = other.gameObject.GetComponent<Health>();
        if (healthScript != null)
        {
            healthScript.takeDamage(damage);
            GiveEffects(other.gameObject);
        }
    }

    protected void GiveEffects(GameObject thing)
    {
        //thing.AddComponent<Paralysis>();
        //thing.GetComponent<Paralysis>().timeDuration = 5;

        foreach (GameObject effect in effects)
        {
            if (effect.GetComponent<Paralysis>() != null)
            {
                thing.AddComponent<Paralysis>();
                thing.GetComponent<Paralysis>().timeDuration = effect.GetComponent<Paralysis>().timeDuration;

            }
            else if (effect.GetComponent<Poison>() != null)
            {
                thing.AddComponent<Poison>();
                thing.GetComponent<Poison>().timeDuration = effect.GetComponent<Poison>().timeDuration;
            }
            else if (effect.GetComponent<Slow>() != null)
            {

                if(thing.GetComponent<Slow>() == null)
                {
                    thing.AddComponent<Slow>();
                    thing.GetComponent<Slow>().timeDuration = effect.GetComponent<Slow>().timeDuration;
                }
            }
        }
    }
}