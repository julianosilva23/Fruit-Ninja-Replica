using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour {

	public GameObject itemPrefab;
	public Transform[] spawnPoints;

	public float minDelay = .1f;
	public float maxDelay = 1f;

	// Use this for initialization
	void Start () {
		StartCoroutine(SpawnItens());
	}

	IEnumerator SpawnItens ()
	{
		while (true)
		{
			float delay = Random.Range(minDelay, maxDelay);
			yield return new WaitForSeconds(delay);

			int spawnIndex = Random.Range(0, spawnPoints.Length);
			Transform spawnPoint = spawnPoints[spawnIndex];
            
			GameObject spawnedItem = Instantiate(itemPrefab, spawnPoint.position, spawnPoint.rotation);	
            //Destroy(spawnedItem, 5f);
		}
	}
	
}
