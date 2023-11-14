using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarPosition : MonoBehaviour
{
    public GameObject AttachPole;
    private Vector3 pos;
    private Vector3 offset;
    public Vector3 initialOffset = new Vector3(0, -0.1f, 0.7f);
    private float originalY;

    // Start is called before the first frame update
    void Start()
    {
    // Set the initial position with the offset
        Vector3 initialPosition = AttachPole.transform.position + initialOffset;
        //transform.position = new Vector3(initialPosition.x, initialPosition.y, initialPosition.z);
        originalY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        /*offset = new Vector3(0, 0.3f, 0.2f);

        pos = AttachPole.transform.position;

        if(transform.position.z != pos.z)
        {
            transform.position = pos + offset;
        }*/


        // Offset is added to the z-axis only
        Vector3 offset = new Vector3(0, -0.1f, 0.7f);

        // Get the position of the AttachPole
        Vector3 pos = AttachPole.transform.position;

        // Check if the z-coordinate is different
        if (Mathf.Abs(transform.position.z - pos.z) > 0.01f)
        {
            // Save the original y position
            originalY = transform.position.y;

            // Update the position only on the z-axis
            transform.position = new Vector3(transform.position.x, originalY, pos.z) + offset;
        }

    }
}
