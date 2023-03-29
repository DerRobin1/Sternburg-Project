using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SortEnding : MonoBehaviour
{

    public GameObject Ende;
    public GameObject SpawnerManager;
    public GameObject Herz1;
    public GameObject Herz2;
    public GameObject Herz3;
    public GameObject BS;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Herz1.activeSelf == false && Herz2.activeSelf == false && Herz3.activeSelf == false)
        {
            SpawnerManager.SetActive(false);
            BS.SetActive(false);
            Ende.SetActive(true);
        }
    }
}
