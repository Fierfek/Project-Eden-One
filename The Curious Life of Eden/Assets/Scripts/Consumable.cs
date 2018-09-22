using UnityEngine;

public class Consumable : Item, IConsumable
{
    public virtual void consume()
    {
        Debug.Log("Consumed a consumable item!");
    }

    public override void OnItemUsed()
    {
        
    }
}
