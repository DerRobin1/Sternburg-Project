using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animtransition : MonoBehaviour
{
    private Animator _allAnim;
    // Start is called before the first frame update
    void Start()
    {
        _allAnim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {

            _allAnim.SetTrigger("Jog");


        }

        //if (Input.GetKeyDown("space"))
        //{

        //    _allAnim.SetTrigger("Jog");


        //}

        //// till the key after being pressed is not released it will not return
        //if (Input.GetKeyUp("space"))
        //{

        //    _allAnim.SetTrigger("Jog");


        //}
    }
}
