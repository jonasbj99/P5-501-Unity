using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCounter : MonoBehaviour
{
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter (Collider other)
    {
        if(other.CompareTag("TovTrækPointCounter"))
        {
            score += 1;
            Debug.Log(score);

            Destroy(other.gameObject);
        }
    }
}
