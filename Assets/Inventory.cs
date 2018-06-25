using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
	List<Item> Items = new List<Item>();

	public void AddItem(Item item)
	{
		if (Items.Contains(item))
		{
			return;
		}

		Items.Add(item);

		Debug.Log("Added " + item.GetName() + " to inventory. Count: " + Items.Count);
	}

	public void RemoveItem(Item item)
	{
		if (!Items.Contains(item))
		{
			return;
		}

		Items.Remove(item);

		Debug.Log("Removed " + item.GetName() + " from inventory. Count: " + Items.Count);
	}
}
