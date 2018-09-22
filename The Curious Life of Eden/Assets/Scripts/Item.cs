using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
	public String itemName;
	public Sprite itemSprite;

	public abstract void OnItemUsed();

}
