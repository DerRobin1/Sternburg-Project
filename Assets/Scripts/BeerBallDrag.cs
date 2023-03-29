using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeerBallDrag : MonoBehaviour
{
    public BallTrajectory trajectory;
    public GameObject ball;
    public float maxForceMultiplier;
    public float minForceMultiplier;
    public float multiplierSpeed;
    public float ballDistance;

    [HideInInspector] public float forceMultiplier;
    //private bool maxMultiplierReached = false;

    [SerializeField] private float cooldown;
    private bool coolDownOver = true;


    private void Start()
    {
        forceMultiplier = maxForceMultiplier;
    }


    private void Update()
    {
        trajectory.Clear();

        Vector3 mousePosition = Input.mousePosition;

        mousePosition.z = ballDistance;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        float power = Vector3.Distance(mousePosition, transform.position);

        //Vector3 direction = (mousePosition - transform.position).normalized;
        //Vector3 direction = (transform.position - mousePosition).normalized;
        Vector3 direction = new Vector3(-(mousePosition.x - transform.position.x), -(mousePosition.y - transform.position.y), mousePosition.z - transform.position.z).normalized;

        //if (maxMultiplierReached == false && forceMultiplier < maxForceMultiplier)
        //{
        //    forceMultiplier += multiplierSpeed * Time.deltaTime;
        //}
        //else
        //{
        //    maxMultiplierReached = true;
        //}

        //if (maxMultiplierReached == true && forceMultiplier > minForceMultiplier)
        //{
        //    forceMultiplier -= multiplierSpeed * Time.deltaTime;
        //}
        //else
        //{
        //    maxMultiplierReached = false;
        //}

        //Debug.Log(forceMultiplier);

        if (Input.GetMouseButton(0) && coolDownOver)
            trajectory.Create(transform.position, direction * power * forceMultiplier);

        if (Input.GetMouseButtonUp(0) && coolDownOver)
        {
            Instantiate(ball, transform.position, Quaternion.identity).GetComponent<Rigidbody>().AddForce(direction * power * forceMultiplier);
            coolDownOver = false;
            StartCoroutine(Cooldown());
        }
    }


    IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(cooldown);
        coolDownOver = true;
    }
}
