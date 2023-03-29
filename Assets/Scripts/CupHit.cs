using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupHit : MonoBehaviour
{
    private GameObject controller;
    [SerializeField] private float upTime;
    [SerializeField] private AudioClip[] ballSounds;
    [SerializeField] private GameObject confetti;
    [SerializeField] private int points = 5;

    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.Find("BallMechanik");
        StartCoroutine(SelfDelete(upTime));
    }

    private void OnCollisionEnter(Collision collision)
    {
        int randomNumber = Random.Range(0, ballSounds.Length);
        GetComponent<AudioSource>().clip = ballSounds[randomNumber];
        GetComponent<AudioSource>().Play();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name != "Miss")
        {
            controller.GetComponent<CupManager>().cupCount += 1;
            controller.GetComponent<CupManager>().score += points;
            other.gameObject.SetActive(false);
            Instantiate(confetti, transform.position, Quaternion.identity);

            GetComponent<Renderer>().enabled = false;
            GetComponent<Collider>().enabled = false;
            StartCoroutine(SelfDelete(1));
        }
    }

    private IEnumerator SelfDelete(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Destroy(gameObject);
    }
}
