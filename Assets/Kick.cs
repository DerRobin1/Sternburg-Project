using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kick : MonoBehaviour
{
    public Animator KickOut;
    public AudioSource Pudd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Pudd.Play();
            KickOut.SetBool("Kicking", true);
            KickOut.Play("Kick");
        }
        
        else if (!Input.GetMouseButtonUp(0))
        {
            KickOut.SetBool("Kicking", false);
        }
    }
}
