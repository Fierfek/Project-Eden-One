using System;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
	public String itemName;
	public Sprite itemSprite;

	/// <summary>
	/// Defines what an item will do on use will be different
	/// for each type of item
	/// </summary>
	public abstract void OnItemUsed();

}
