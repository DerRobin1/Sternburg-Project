using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class VisualizeButton1 : MonoBehaviour
{
    public GameObject WhiteTisch;
    public GameObject WhiteTur;
    public GameObject Flasche;
    public GameObject Canvas;
    public GameObject Canvas1;
    public GameObject Canvas2;
    public AudioSource Sele;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Canvas.activeSelf)
        {
            WhiteTisch.SetActive(false);
            WhiteTur.SetActive(false);
            Flasche.SetActive(false);
            Canvas1.SetActive(false);
            Canvas2.SetActive(false);
        }
    }

    void OnMouseOver()
    {
        WhiteTisch.SetActive(true);

        if (Input.GetMouseButtonDown(0) && WhiteTisch.activeSelf && Canvas1.activeSelf == false)
        {
            Sele.Play();
            Canvas.SetActive(true);
        }
    }

    void OnMouseExit()
    {
        WhiteTisch.SetActive(false);
    }
}

