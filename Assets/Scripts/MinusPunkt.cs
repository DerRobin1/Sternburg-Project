using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinusPunkt : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Sector Unit", gameObject);
        if (other.gameObject.tag == "Player" && GlobalScore.CurrentScore >= 1)
        {
            GlobalScore.CurrentScore -= 1;
        }
    }
}
