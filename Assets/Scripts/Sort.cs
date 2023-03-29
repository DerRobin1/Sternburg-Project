using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Sort : MonoBehaviour
{
    public GameObject Canvas;
    public AudioSource Yes;
    public AudioSource No;

    public void StartGame()
    {
        Yes.Play();
        SceneManager.LoadScene("Flasche sortieren");
    }

    public void QuitGame()
    {
        No.Play();
        Canvas.SetActive(false);
    }
}
