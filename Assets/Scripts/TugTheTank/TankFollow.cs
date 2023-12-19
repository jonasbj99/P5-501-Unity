using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankFollow : MonoBehaviour
{
    private Vector3 tankPos;
    private Vector3 attachPos;
    public GameObject tankAttach;
    private float tankOffset = -62.3f;

    void Start()
    {
        tankPos = transform.position;
        attachPos = tankAttach.transform.position;
    }

    void Update()
    {
        attachPos = tankAttach.transform.position;

        if(tankPos.x != attachPos.x)
        {
            tankPos.x = attachPos.x + tankOffset;

            transform.position = tankPos;
        }
    }
}
