using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Falschgeld1Kopie : MonoBehaviour
{
    
    //public TextMeshProUGUI PlusEins;
    BoxCollider _noBottleCollider;
    bool _goRight;
    bool _goDown;
    public float _movingSpeed = 60;
    // Start is called before the first frame update
    void Start()
    {
        _noBottleCollider = gameObject.GetComponent<BoxCollider>();
        //gameObject.GetComponent<Animator>().Play("Bierleute laufen");
        _goRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (_goDown)
        {
            transform.position += Vector3.down * _movingSpeed * Time.deltaTime;



        }
        if (_goRight)
        {
            transform.position += Vector3.right * _movingSpeed * Time.deltaTime;


        }
    }

    void OnMouseOver()
    {
        //Debug.Log(0);
        if (Input.GetMouseButtonUp(0) && _noBottleCollider.tag == "Player")
        {
            //PlusEins.GetComponent<Animator>().SetBool("+++1", true);
            gameObject.GetComponent<BoxCollider>().enabled = false;
            GlobalScore.CurrentScore += 1;
            //GlobalScore.CurrentScore -= 1;
            Debug.Log("Firstcalled");
            _goDown = true;
            _goRight = false;
            //StartCoroutine(RausMiDi());

        }

        else if (Input.GetMouseButtonUp(0) && _noBottleCollider.tag == "NotPlayer" && GlobalScore.CurrentScore >= 1)
        {

            gameObject.GetComponent<BoxCollider>().enabled = false;
            GlobalScore.CurrentScore -= 1;
            //GlobalScore.CurrentScore -= 1;
            Debug.Log("Firstcalled");
            _goDown = true;
            _goRight = false;
            //StartCoroutine(RausMiDi());

        }

        else if (Input.GetMouseButtonUp(0) && _noBottleCollider.tag == "NotPlayer")
        {

            gameObject.GetComponent<BoxCollider>().enabled = false;
            //GlobalScore.CurrentScore -= 1;
            Debug.Log("Firstcalled");
            _goDown = true;
            _goRight = false;
            //StartCoroutine(RausMiDi());

        }




    }


    IEnumerator RausMiDi()
    {
        Debug.Log("called");
        _goDown = true;
        _goRight = false;

        //gameObject.GetComponent<Animator>().SetBool("GoDown", true);
        gameObject.GetComponent<BoxCollider>().enabled = false;
        //TextScore.SetActive(true);
        yield return new WaitForSeconds(0.1f);

    }
}
