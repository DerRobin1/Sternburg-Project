using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _beer;
    [SerializeField]
    private GameObject _beerContainer;
    float _spawnSpeed = 50;
    float _spawnSpeedIncrement;
    // Start is called before the first frame update
    void Start()
    {
       
        StartCoroutine(SpawnRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        _spawnSpeed += Time.deltaTime;
        //int a = 5;
        //while (a > 0)
        //{
        //    a--;  // this will run the while loop 5 times

        //}
    }


    // spawn gameObjects every 5 seconds
    // create a coroutine of type IEnumerator -- Yield Events
    // while loop -- it is a infinite game loop -- they always keep on running -- can crash the computer

    IEnumerator SpawnRoutine()
    {
        //yield return null; // wait 1 frame

        //// then this line is called

        //yield return new WaitForSeconds(5.1f);

        //// then this line is called

        // while loop (infinite loop)
        // Instantiate Beer Sprite animation

        while (true)
        {
            Vector3 posToSpawn = new Vector3(Random.Range(75f,79f), Random.Range(-20f, 20f), 0);
            Vector3 posToSpawn_1 = new Vector3(Random.Range(75f, 79f), Random.Range(-25f, 25f), 0);
            Vector3 posToSpawn_2 = new Vector3(Random.Range(75f, 79f), Random.Range(-10f, 10f), 0);
            GameObject _beer0 =  Instantiate(_beer[0], posToSpawn, Quaternion.identity);
            //_beer0.transform.position = posToSpawn * _spawnSpeed;
            _beer0.transform.parent = _beerContainer.transform;
            yield return new WaitForSeconds(1f);
            GameObject _beer1 = Instantiate(_beer[1], posToSpawn_1, Quaternion.identity);
            _beer1.transform.parent = _beerContainer.transform;
            //_beer1.transform.position = posToSpawn_1 * _spawnSpeed;
            yield return new WaitForSeconds(1f);
            GameObject _beer2 = Instantiate(_beer[2], posToSpawn_2, Quaternion.identity);
            _beer2.transform.parent = _beerContainer.transform;
            //_beer2.transform.position = posToSpawn_2 * _spawnSpeed;

            yield return new WaitForSeconds(2f);
        }
        // as we are in a infinite loop we will never get here
        // called in countdown.cs to stop this while loop
    }

}
