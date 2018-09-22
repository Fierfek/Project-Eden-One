using UnityEngine;

public class Sword : Weapon
{
    private void Start()
    {
        isRanged = false;
    }

    //Updates 1 time per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Right clicked");
        }
    }

    public override void attack()
    {
        base.attack();
        Debug.Log("Attacking with sword!");
    }
}
