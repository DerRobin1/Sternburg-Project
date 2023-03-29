using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManaging : MonoBehaviour
{
    [HideInInspector] public int score;

    // Start is called before the first frame update
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    public void Quit()
    {
        TotalScore.totalScore += score;
        SceneManager.LoadScene("Hauptmenu");
    }
}
