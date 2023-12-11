using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeBehavior2 : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Player" && collision.gameObject.tag != "Axe")
        {
            Destroy(this.gameObject, 0.75f);
        }
    }
}
