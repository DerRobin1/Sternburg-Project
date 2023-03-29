using System.Collections;
using UnityEngine;

public class Falschgeld : MonoBehaviour
{

    SpawnPeople _hearts;
    //public TextMeshProUGUI PlusEins;
    BoxCollider _noBottleCollider;
    bool _goRight;
    bool _goDown;

    [SerializeField] private int points;

    public float _movingSpeed = 60;
    // Start is called before the first frame update
    void Start()
    {
        _hearts = SpawnPeople._singleton;
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
            GlobalScore.CurrentScore += points;
            //GlobalScore.CurrentScore -= 1;
            Debug.Log("Firstcalled");
            _goDown = true;
            _goRight = false;
            //StartCoroutine(RausMiDi());

        }

         if (Input.GetMouseButtonUp(0) && _noBottleCollider.tag == "NotPlayer" && _hearts.Herz1.activeSelf)
         {
  
            _hearts.Herz1.SetActive(false);
            gameObject.GetComponent<BoxCollider>().enabled = false;
            //GlobalScore.CurrentScore -= 1;
            Debug.Log("Firstcalled");
            _goDown = true;
            _goRight = false;

            //StartCoroutine(RausMiDi());

        }



        else if (Input.GetMouseButtonUp(0) && _noBottleCollider.tag == "NotPlayer" && _hearts.Herz2.activeSelf)
        {


            _hearts.Herz2.SetActive(false);
            gameObject.GetComponent<BoxCollider>().enabled = false;
            //GlobalScore.CurrentScore -= 1;
            Debug.Log("Firstcalled");
            _goDown = true;
            _goRight = false;

            //StartCoroutine(RausMiDi());

        }

        else if (Input.GetMouseButtonUp(0) && _noBottleCollider.tag == "NotPlayer" && _hearts.Herz3.activeSelf)
        {

            _hearts.Herz3.SetActive(false);
            gameObject.GetComponent<BoxCollider>().enabled = false;
            _goDown = true;
            _goRight = false;
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
