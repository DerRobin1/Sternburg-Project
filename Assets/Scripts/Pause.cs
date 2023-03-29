using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


public class Pause : MonoBehaviour
{  
    [SerializeField]
   public GameObject _spawnManager;
    public GameObject _spawnManager1;
    private GameObject _background;
    public void StartGame()
    {
        
        _spawnManager.SetActive(true);
        _spawnManager1.SetActive(true);

        SceneManager.LoadScene("Whack-A-Mole");
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("Hauptmenu");
    }
}
