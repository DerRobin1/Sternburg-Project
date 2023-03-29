using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShownMouse : MonoBehaviour
{

    public AudioSource EndeKlang;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        EndeKlang.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
