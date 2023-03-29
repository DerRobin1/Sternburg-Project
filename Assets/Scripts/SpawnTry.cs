using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTry : MonoBehaviour
{
	public Transform[] Positions;
	public GameObject Object;

	public Transform Location;

	private bool ToSpawn = true;

	// Start is called before the first frame update
	void Update()
	{
		Location = Positions[Random.Range(0, Positions.Length)];

		if (ToSpawn == true)
		{
			Instantiate(Object, Location);
			ToSpawn = false;
			StartCoroutine(ToSpawnTrue());
		}
	}

	IEnumerator ToSpawnTrue()
	{
		yield return new WaitForSeconds(3);
		ToSpawn = true;
	}
}
