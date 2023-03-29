using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPeople : MonoBehaviour
{
    public static SpawnPeople _singleton;
    //public Transform[] Positions;
    [SerializeField] GameObject[] Object;
	public GameObject Herz1;
	public GameObject Herz2;
	public GameObject Herz3;

	public Transform Location;

	private bool ToSpawn = true;
	private float _fastSpeed = 50;

    private void Start()
    {
		_singleton = this;
    }

    void Update()
	{
		//Location = Positions[Random.Range(0, Positions.Length)];
		_fastSpeed += Time.deltaTime;
		if (ToSpawn == true)
		{
			_fastSpeed += 3;
			GameObject gameObject = Instantiate(Object[Random.Range(0, Object.Length)], Location);
			gameObject.GetComponent<Falschgeld>()._movingSpeed = _fastSpeed;
			ToSpawn = false;
			StartCoroutine(ToSpawnTrueRight());
		}
	}

	IEnumerator ToSpawnTrueRight()
	{
		yield return new WaitForSeconds(0.8f);
		ToSpawn = true;
	}
}
