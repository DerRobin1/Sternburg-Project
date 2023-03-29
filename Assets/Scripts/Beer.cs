using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Beer : MonoBehaviour
{
    public GameObject Bier;
    public GameObject TextScore;
    public AudioSource OpenBeerKlang;
    [SerializeField] private int points;

    // Start is called before the first frame update
    void Start()
    {

        if (Bier.activeSelf == true)
        {
            StartCoroutine(BeerDa());
        }
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    void OnMouseOver()
    {
        //Debug.Log(0);
        if (Input.GetMouseButtonUp(0))
        {
            GlobalScore.CurrentScore += points;
            
            StartCoroutine(WegDa());
        }
    }

    IEnumerator WegDa()
    {
        Bier.GetComponent<Animator>().SetBool("open", true);
        Bier.GetComponent<BoxCollider>().enabled = false;
        TextScore.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        OpenBeerKlang.Play();

    }

    IEnumerator BeerDa()
    {
        yield return new WaitForSeconds(2.5f);
        Bier.GetComponent<Animator>().SetBool("weg", true);
    }
}
