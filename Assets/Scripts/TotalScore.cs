using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TotalScore : MonoBehaviour
{
    public static int totalScore = 0;

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = totalScore.ToString();
    }
}
