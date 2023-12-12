using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointCounter : MonoBehaviour
{
    public static int score = 0;

    public static bool startTimer = false;
    public static float currentTime = 60f;
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text timeText;

    [SerializeField] AudioSource fanfare;

    bool gameEnded = false;

    void start()
    {
        startTimer = false;
    }


    void Update()
    {
        if(startTimer = true && currentTime > 0)
        {
            currentTime -= Time.deltaTime;
        }
        else
        {
            currentTime = 0;
        }

        scoreText.text = "Score: " + score;
        timeText.text = "Time: " + currentTime.ToString("0");

        if(score > 99 && gameEnded == false)
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        gameEnded = true;
        Debug.Log("You Win!");

        fanfare.Play();
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
