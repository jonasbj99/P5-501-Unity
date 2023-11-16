using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitDespawn : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            Destroy(this.gameObject);
        }
    }
}
