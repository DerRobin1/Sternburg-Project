using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrower : MonoBehaviour
{
    public GameObject ballPrefab; // drag the ball prefab into this field in the Inspector
    public float throwForce = 10; // adjust this value to change the throw force

    void Update()
    {
        // throw the ball when the space key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // instantiate a new ball at the position of the Ball Thrower object
            GameObject ball = Instantiate(ballPrefab, transform.position, Quaternion.identity);

            // add a force to the ball in the direction the Ball Thrower is facing
            ball.GetComponent<Rigidbody>().AddForce(transform.forward * throwForce, ForceMode.Impulse);
        }
    }
}
