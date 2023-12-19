using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartMovement : MonoBehaviour
{
    public float moveSpeed = 10f; 
    private Rigidbody cartRB;
    // Start is called before the first frame update
    void Start()
    {
        cartRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            cartRB.AddForce(Vector3.forward * -moveSpeed, ForceMode.Impulse);

            //transform.Translate(Vector3.forward * -moveSpeed * Time.deltaTime, Space.World);
        }
    }
}
