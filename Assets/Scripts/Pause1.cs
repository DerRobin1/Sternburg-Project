using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


public class Pause1 : MonoBehaviour
{  
    [SerializeField]
   private GameObject _spawnManager;
   private GameObject _background;
    public void StartGame()
    {
        
        _spawnManager.SetActive(true);

        SceneManager.LoadScene("Flasche sortieren");
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("Hauptmenu");
    }
}
