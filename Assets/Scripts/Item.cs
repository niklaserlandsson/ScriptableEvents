using UnityEngine;

public class Item : MonoBehaviour
{
	public ItemData Data;
	public Material InventoryMaterial;
	public Material WorldMaterial;
	public Renderer Renderer;

	public ItemEvent OnPickedUp;
	public ItemEvent OnDropped;

	public string GetName()
	{
		return Data.Name;
	}

	public void PickUp()
	{
		Renderer.material = InventoryMaterial;
		OnPickedUp.Raise(this);
	}

	public void Drop()
	{
		Renderer.material = WorldMaterial;
		OnDropped.Raise(this);
	}
}