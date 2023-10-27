using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeGameBehavior : MonoBehaviour
{
    [SerializeField] GameObject[] targetObject;
    [SerializeField] GameObject spawnArea;
    int targetCount;

    [SerializeField] GameObject throwingAxe1;
    [SerializeField] GameObject throwingAxe2;
    [SerializeField] Transform axeSpawn1;
    [SerializeField] Transform axeSpawn2;
    int axeCount1;
    int axeCount2;

    float spawnX;
    float spawnY;
    float spawnZ;

    public static int axeScore;
    //Public text field for in game score


    void Start()
    {
        axeScore = 0;

        spawnX = spawnArea.transform.localScale.x / 2;
        spawnY = spawnArea.transform.localScale.y / 2;
        spawnZ = spawnArea.transform.localScale.z / 2;
    }

    void Update()
    {
        Debug.Log(axeScore);

        if (Input.GetKeyDown("space"))
        {
            SpawnTarget();
        }

        if (Input.GetKeyDown("1"))
        {
            SpawnAxe(throwingAxe1, axeSpawn1);
        }

        if (Input.GetKeyDown("2"))
        {
            SpawnAxe(throwingAxe2, axeSpawn2);
        }

        targetCount = FindObjectsOfType<AxeTargetBehavior>().Length;

        axeCount1 = FindObjectsOfType<AxeBehavior1>().Length;

        axeCount2 = FindObjectsOfType<AxeBehavior2>().Length;

        if(targetCount < 1)
        {
            SpawnTarget();
        }

        if(axeCount1 < 1)
        {
            SpawnAxe(throwingAxe1, axeSpawn1);
        }

        if (axeCount2 < 1)
        {
            SpawnAxe(throwingAxe2, axeSpawn2);
        }
    }

    void SpawnTarget()
    {
        Vector3 randomSpawnPos = spawnArea.transform.position + new Vector3(Random.Range(-spawnX, spawnX), Random.Range(-spawnY, spawnY), Random.Range(-spawnZ, spawnZ));
        Instantiate(targetObject[Random.Range(0, targetObject.Length)], randomSpawnPos, spawnArea.transform.rotation);
    }

    void SpawnAxe(GameObject axe, Transform axeSpawn)
    {
        Instantiate(axe, axeSpawn);
    }
}
