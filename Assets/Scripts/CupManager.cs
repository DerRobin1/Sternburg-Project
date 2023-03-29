using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CupManager : MonoBehaviour
{
    [HideInInspector] public int cupCount;
    [HideInInspector] public int score;
    [SerializeField] private GameObject[] cups;
    [SerializeField] private TextMeshProUGUI[] scoreUI;
    [SerializeField] private GameObject endButton;
    //public GameObject Ende;

    // Start is called before the first frame update
    void Start()
    {
        cupCount = 0;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        foreach (TextMeshProUGUI scoreDisplay in scoreUI)
            scoreDisplay.text = score.ToString();

        endButton.GetComponent<SceneManaging>().score = score;

        if (cupCount == cups.Length)
        {
            //Ende.SetActive(true);
            foreach (GameObject cup in cups)
                cup.SetActive(true);
            cupCount = 0;
        }
    }
}
