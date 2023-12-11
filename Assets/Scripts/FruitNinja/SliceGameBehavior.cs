using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem; // Debug Use

public class SliceGameBehavior : MonoBehaviour
{
    //XRIDefaultInputActions debugControls; // Debug Use

    public Transform[] spawnPositions;
    public GameObject[] sliceObjects;
    int objectCount;

    [SerializeField] TMP_Text scoreText;
    public static int sliceScore;

    [SerializeField] TMP_Text timeText;
    float currentTime = 300f;

    [SerializeField] GameObject[] spawners;

    /*
    private void Awake() // Debug Use
    {
        debugControls = new XRIDefaultInputActions();
    }
    private void OnEnable() // Debug Use
    {
        debugControls.Enable();
    }
    private void OnDisable() // Debug Use
    {
        debugControls.Disable();
    }
    */

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

        objectCount = GameObject.FindGameObjectsWithTag("SliceObject").Length;
        
        //debugControls.Debug.SpawnObject.ReadValue<float>(); // Debug Use

        /*
        if (debugControls.Debug.SpawnObject.ReadValue<float>() > 0 && objectCount < 1) // Debug Use
        {
            SpawnObject();
        }

        
        if (Input.GetKeyDown("space"))
        {
            SpawnObject();
        }
        */
    }

    void SpawnObject()
    {
        int spawnInt = Random.Range(0, spawnPositions.Length);
        int objectInt = Random.Range(0, sliceObjects.Length);
        Instantiate(sliceObjects[objectInt], spawnPositions[spawnInt].position, spawnPositions[spawnInt].rotation);
    }
}
