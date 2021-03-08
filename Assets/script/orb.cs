using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orb : Item
{
	public override void UseItem()
	{
		base.UseItem();
		Debug.Log("optimal food source!");
	}
}
