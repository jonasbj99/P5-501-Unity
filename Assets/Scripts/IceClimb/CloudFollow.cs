using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudFollow : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    Vector3 cloudOffset;

    void Start()
    {
        cloudOffset = this.transform.position;
    }

    void Update()
    {
        this.transform.position = playerTransform.position + cloudOffset;
    }
}
