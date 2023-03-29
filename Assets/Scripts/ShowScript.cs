using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowScript : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI FerScore;

    // Start is called before the first frame update
    void Start()
    {
        FerScore.GetComponent<TextMeshProUGUI>().text = "" + GlobalScore.CurrentScore;
    }
}
