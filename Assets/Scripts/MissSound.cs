using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissSound : MonoBehaviour
{
    [SerializeField] private float cooldown;
    private bool coolDownOver = true;

    private void OnTriggerEnter(Collider other)
    {
        if (coolDownOver)
        {
            GetComponent<AudioSource>().Play();
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
