using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCounter : MonoBehaviour
{
    private int score = 0;
    
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
