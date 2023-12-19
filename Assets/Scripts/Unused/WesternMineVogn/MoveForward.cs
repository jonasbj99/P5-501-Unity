using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float moveSpeed = 10f; 
    private Rigidbody movingObjectRB;
    // Start is called before the first frame update
    void Start()
    {
        movingObjectRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            movingObjectRB.AddForce(Vector3.forward * -moveSpeed, ForceMode.Impulse);

            //transform.Translate(Vector3.forward * -moveSpeed * Time.deltaTime, Space.World);
        }
    }
}
