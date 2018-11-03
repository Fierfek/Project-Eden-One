using UnityEngine;

public class Sword : Weapon
{
    private void Start()
    {
        isRanged = false;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            attack();
        }
    }

    public override void attack()
    {
        Debug.Log("Attacking with sword!");
    }

    public override void OnSkillUsed()
    {
        Debug.Log("Skill used with sword!");
    }

    protected override void OnTriggerEnter2D(Collider2D other)
    {
        //Contains grabbing health script and calling take damage
        base.OnTriggerEnter2D(other);
        Debug.Log("Sword collided with an object");
        //play sword hit sound stuff idk
    }
}
