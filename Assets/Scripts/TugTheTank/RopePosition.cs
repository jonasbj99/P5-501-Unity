using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopePosition : MonoBehaviour
{
    private Vector3 pos;

    void Start()
    {
        pos = transform.position;
    }

    void Update()
    {
        if(transform.position.y > pos.y)
        {
            transform.position = pos;
        }
    }
}
