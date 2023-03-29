using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorMovementLocked : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
       

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 _cursor = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.farClipPlane));
        gameObject.transform.position = _cursor;
    }
}
