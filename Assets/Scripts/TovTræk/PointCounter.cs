using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointCounter : MonoBehaviour
{
    private int score = 0;

    public static float currentTime = 10f;
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text timeText;


    void Update()
    {
        if(currentTime > 0)
        {
            currentTime -= Time.deltaTime;
        }
        else
        {
            currentTime = 0;
        }

        scoreText.text = "Score: " + score;
        timeText.text = "Time: " + currentTime.ToString("0");

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
