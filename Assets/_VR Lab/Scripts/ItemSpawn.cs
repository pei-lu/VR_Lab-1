using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSpawn : MonoBehaviour
{
	public GameObject inventoryButton;
    public GameObject leftHand;
    public GameObject rightHand;
	public float spawnDistance = 3;

	public void SpawnItem(GameObject itemPrefab)
	{
		Vector3 handCenter = leftHand.transform.position + rightHand.transform.position;
		GameObject item = Instantiate(itemPrefab);
		item.transform.position = handCenter + gameObject.GetComponent<Camera>().transform.forward * spawnDistance;
		item.GetComponent<Rigidbody>().isKinematic = true;
		inventoryButton.GetComponent<Button>().onClick.Invoke();
	}

}
