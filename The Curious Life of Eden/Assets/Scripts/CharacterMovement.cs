using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

    public Vector2 direction;
    public Rigidbody2D rb;
    public float speed; 
	// Use this for initialization
	void Start () {
        speed = .5f;
	}
	
	// Update is called once per frame
	void Update () {
        direction.Set(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")); 
        direction = direction.normalized;
        rb.MovePosition(rb.position + (direction*speed*Time.deltaTime)); 
	}
}
