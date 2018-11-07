using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Health))]
[RequireComponent(typeof(Rigidbody2D))]
public abstract class CharacterBase : MonoBehaviour {

    protected Health health;

    protected Animator anim;
    protected string state = "Idle";

    protected Rigidbody2D body;
    protected Vector2 newPos, changePos;

    public float speed = 3;

	// Use this for initialization
	public void Start () {
        health = GetComponent<Health>();
        anim = GetComponentInChildren<Animator>();
        body = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	public void Update () {
		if(changePos.magnitude > .01f)
        {
            anim.SetFloat("x", changePos.x);
            anim.SetFloat("y", changePos.y);
        }

        if(changePos.magnitude > 0f)
        {
            state = "Move";
        }
        else
        {
            state = "Idle";
        }

        anim.Play(state);
	}
}
