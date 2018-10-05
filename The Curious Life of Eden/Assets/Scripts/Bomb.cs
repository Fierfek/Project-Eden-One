using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bomb : Weapon
{
    public int radius; //defines how big too explode
    public float time = 3f; //defines how long before it explodes

    public GameObject explosionEffect; //plays the explosion effect?
    float countdown;
    bool hasExploded = false;

    private void Start()
    {
        countdown = 0;
    }

    private void Update()
    {
        countdown += Time.deltaTime;
        if(countdown >= time && !hasExploded)
        {
            Explode();
            hasExploded = true;
        }
    }
    private void Explode()
    {
        Debug.Log("BOOM");

        //show explosion effect
        Instantiate(explosionEffect, transform.position, transform.rotation); //brings the explosion effect

        //get nearby objects
        Collider2D[] colliders =  Physics2D.OverlapCircleAll(transform.position, radius);

        foreach (Collider2D nearobject in colliders)
        {
            Health h = nearobject.GetComponent<Health>();
            if (h != null)
            {
                h.takeDamage(damage);
                h.takeEffects(effects);
            
            }
        }

        //damage them
        //apply effects
        //knockback?

        //remove bomb
        Destroy(gameObject);
    }
}

