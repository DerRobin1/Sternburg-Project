using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Countdown : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Zeit;
    float currentTime = 0f;
    [SerializeField]
    private float startingTime = 10f;
    public GameObject Ende;
    public GameObject SpawnerManager;
    public GameObject SpawnerManager1;
    public GameObject BS;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        Zeit.text = currentTime.ToString("0");



        if (currentTime <= 0)
        {
            if (SpawnerManager)
                SpawnerManager.SetActive(false);
            SpawnerManager1.SetActive(false);
            BS.SetActive(false);
            Ende.SetActive(true);
        }
    }
}
