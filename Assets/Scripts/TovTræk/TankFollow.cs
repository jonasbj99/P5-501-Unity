using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankFollow : MonoBehaviour
{
    private Vector3 tankPos;
    private Vector3 attachPos;
    public GameObject attachTank;
    // Start is called before the first frame update
    void Start()
    {
        tankPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(tankPos.x != attachPos.x)
        {
            tankPos.x = attachPos.x;
        }
    }
}
