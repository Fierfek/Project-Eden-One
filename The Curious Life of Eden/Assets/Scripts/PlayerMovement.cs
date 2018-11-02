using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float movementSpeed;
    Rigidbody2D rigidBody;
    private Vector2 direction; 

    // Use this for initialization
    void Start () {
        rigidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        direction.Normalize();

        rigidBody.MovePosition(rigidBody.position + (direction * movementSpeed * Time.deltaTime));
    }
}
