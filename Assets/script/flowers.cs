using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flowers : Item
{
	public override void UseItem()
	{
		base.UseItem();
		Debug.Log("Medicinal in small quantities");
	}
}
