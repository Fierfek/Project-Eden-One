using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwable : MonoBehaviour
    {
    public GameObject throwingItem;
    public int throwSpeed;

    private GameObject throwingItemInstance;
    
    //Decrements amount of throwable item in inventory, then calls throw method passing in the direction at which the item should be thrown
	public void consume(Vector2 throwDirection)
    {
        Debug.Log("Decrementing amount of throwable Item");
        throwItem(throwDirection);
    }

    //Instantiates an Item at transform position at speed relative to throwSpeed and saves that Item as throwingItemInstance
    private void throwItem(Vector2 direction)
    {
        float rot_z = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        direction.Normalize();
        throwingItemInstance = Object.Instantiate(throwingItem, transform.position, Quaternion.Euler(0, 0, rot_z));
        throwingItemInstance.GetComponent<Rigidbody2D>().velocity = throwSpeed * direction * Time.deltaTime;
    }
}
