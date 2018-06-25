using UnityEngine;

public class InputManager : MonoBehaviour
{
	public LayerMask m_layerMask;

	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			RaycastHit hit;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100f, m_layerMask))
			{
				var item = hit.collider.GetComponent<Item>();
				item.PickUp();
			}
		}

		if (Input.GetMouseButtonDown(1))
		{
			RaycastHit hit;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100f, m_layerMask))
			{
				var item = hit.collider.GetComponent<Item>();
				item.Drop();
			}
		}
	}
}
