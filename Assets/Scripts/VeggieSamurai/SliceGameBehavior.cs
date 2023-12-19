using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SliceGameBehavior : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    public static int sliceScore;

    [SerializeField] TMP_Text timeText;
    float currentTime = 180f;

    [SerializeField] GameObject[] spawners;

    private void Start()
    {
        sliceScore = 0;
    }

    private void Update()
    {
        Debug.Log(sliceScore);

        currentTime -= Time.deltaTime;

        scoreText.text = "Score: " + sliceScore;

        timeText.text = "Time: " + currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
            for(int i = 0; i < spawners.Length; i++)
            {
                Destroy(spawners[i]);
            }
        }
    }
}
