using UnityEngine;

public class Item : MonoBehaviour
{
	public ItemData Data;
	public Material InventoryMaterial;
	public Material WorldMaterial;
	public Renderer Renderer;

	public ItemEvent OnPickUp;
	public ItemEvent OnDrop;

	public string GetName()
	{
		return Data.Name;
	}

	public void PickUp()
	{
		Renderer.material = InventoryMaterial;
		OnPickUp.Raise(this);
	}

	public void Drop()
	{
		Renderer.material = WorldMaterial;
		OnDrop.Raise(this);
	}
}