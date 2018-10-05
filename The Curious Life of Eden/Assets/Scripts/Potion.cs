using System;
using UnityEngine;

public class Potion : Consumable
{
	public int healsFor;
	Health health;

	private void Start()
	{
		health = gameObject.GetComponent <Health>();
	}

	private void Update()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			consume();
		}
	}

	public override void consume ()
	{
		Debug.Log ("Consumed a health potion");
		health.heal (healsFor);
	}
}