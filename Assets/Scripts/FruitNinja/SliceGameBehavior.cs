using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; // Debug Use

public class SliceGameBehavior : MonoBehaviour
{
    XRIDefaultInputActions debugControls; // Debug Use

    public Transform[] spawnPositions;
    public GameObject[] sliceObjects;
    int objectCount;

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
    private void Update()
    {
        objectCount = GameObject.FindGameObjectsWithTag("SliceObject").Length;
        debugControls.Debug.SpawnObject.ReadValue<float>(); // Debug Use

        if (debugControls.Debug.SpawnObject.ReadValue<float>() > 0 && objectCount < 1) // Debug Use
        {
            SpawnObject();
        }
    }

    void SpawnObject()
    {
        int spawnInt = Random.Range(0, spawnPositions.Length);
        int objectInt = Random.Range(0, sliceObjects.Length);
        Instantiate(sliceObjects[objectInt], spawnPositions[spawnInt].position, spawnPositions[spawnInt].rotation);
    }
}
