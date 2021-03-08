using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bees : Item
{
	public override void UseItem()
	{
		base.UseItem();
		Debug.Log("Keep us alive - we make food!");
	}
}
