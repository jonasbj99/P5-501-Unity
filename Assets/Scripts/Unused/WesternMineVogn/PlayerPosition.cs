using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    public GameObject AttachPole;
    private Vector3 pos;
    private Vector3 offset;
    private Vector3 initialOffset = new Vector3(0.1f, -1.1f, 0.7f);
    // Start is called before the first frame update
    void Start()
    {
        Vector3 initialPosition = AttachPole.transform.position + initialOffset;
        transform.position = initialPosition;
    }

    // Update is called once per frame
    void Update()
    {
        offset = new Vector3(0.1f, -1.1f, 0.7f);

        pos = AttachPole.transform.position;

        if(transform.position != pos)
        {
            transform.position = pos + offset;
        }
    }
}
