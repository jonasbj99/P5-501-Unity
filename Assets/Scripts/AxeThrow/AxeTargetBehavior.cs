using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeTargetBehavior : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Axe")
        {
            AxeGameBehavior.axeScore += 1;
            Destroy(this.gameObject);
        }
    }
}
