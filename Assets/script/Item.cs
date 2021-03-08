using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
	public string Name;
	public int Calories;
	public int Karmas;
	public bool Alive;
	public string Message;
	public virtual void UseItem()

	{
		//two lines below find a script called TellPlayer and call functions in it
		FindObjectOfType<TextScript>().WriteMessage(Message);
		FindObjectOfType<TextScript>().UpdateStats(Calories, Karmas);

	}

	private void OnMouseDown()
	{
		UseItem();
	}
}
