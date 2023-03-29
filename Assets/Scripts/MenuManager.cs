using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject canvas;
    [SerializeField] private string sceneName;
    

    public void StartGame()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        canvas.SetActive(false);
    }
}
