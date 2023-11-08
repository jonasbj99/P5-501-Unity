using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarPosition : MonoBehaviour
{
    public GameObject AttachPole;
    private Vector3 pos;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        offset = new Vector3(0, 0.3f, 0.2f);

        pos = AttachPole.transform.position;

        if(transform.position.z != pos.z)
        {
            transform.position = pos + offset;
        }
    }
}
