using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : Item
{
	public override void UseItem()
	{
		base.UseItem();
		Debug.Log("Good for teeth!");
	}
}
