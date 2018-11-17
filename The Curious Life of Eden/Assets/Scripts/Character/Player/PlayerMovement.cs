using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : CharacterBase {

    Rigidbody2D rigidBody;
    private Vector2 direction;

    // Use this for initialization
    void Start () {
        base.Start();
        rigidBody = GetComponentInChildren<Rigidbody2D>();
        
	}
	
	// Update is called once per frame
	void Update () {
        direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        direction.Normalize();

        newPos = rigidBody.position + (direction * speed * Time.deltaTime);

        changePos = newPos - body.position;

        rigidBody.MovePosition(newPos);

        base.Update();
    }
}
