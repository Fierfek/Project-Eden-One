using UnityEngine;

public class GrappleHead : MonoBehaviour 
{
	private void OnCollisionEnter2D(Collision2D other)
	{
		var spear = transform.parent.GetComponent<Spear>();
		
		spear.CollisionFromGrappleHead(other);
	}
}
