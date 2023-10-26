using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject building;
    private Vector3 spawnPos = new Vector3(0, 0, 0);


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBuilding", 1, .5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnBuilding()
    {
        Instantiate(building, spawnPos, building.transform.rotation);
    }
}
