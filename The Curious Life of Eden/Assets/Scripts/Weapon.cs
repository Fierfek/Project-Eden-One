using UnityEngine;

public class Weapon : Item, IAttackable
{
    public int damage;
    public bool isRanged;
    
    public virtual void attack()
    {
        Debug.Log("Attacking with generic weapon!");
    }

    public override void OnItemUsed()
    {
        
    }
}