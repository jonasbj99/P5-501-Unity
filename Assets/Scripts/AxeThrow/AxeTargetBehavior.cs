using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeTargetBehavior : MonoBehaviour
{
    private AudioSource axeHit;

    private void start()
    {
        axeHit = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Axe")
        {
            if(AxeGameBehavior.currentTime > 0)
            {
                AxeGameBehavior.axeScore += 1;
            }

            axeHit.Play();
            Destroy(this.gameObject);
        }
    }
}
