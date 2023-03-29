using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalScore : MonoBehaviour
{
    public static int CurrentScore;
    public int InternalScore;
    [SerializeField] GameObject sceneManager;
    [SerializeField] TextMeshProUGUI ScoreDisplay;
    [SerializeField] TextMeshProUGUI ScoreDisplayEnd;

    void Start()
    {
        InternalScore = 0;
        CurrentScore = 0;
        ScoreDisplay.GetComponent<TextMeshProUGUI>().text = "0";

    }

    // Update is called once per frame
    void Update()
    {
        InternalScore = CurrentScore;
        sceneManager.GetComponent<SceneManaging>().score = CurrentScore;
        ScoreDisplay.GetComponent<TextMeshProUGUI>().text = "" + InternalScore;
        ScoreDisplayEnd.GetComponent<TextMeshProUGUI>().text = "" + InternalScore;
    }
}
