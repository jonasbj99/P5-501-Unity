using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

// Tutorial used: https://youtu.be/xTT1Ae_ifhM

public class VeggieSpawner : MonoBehaviour
{
    private Collider spawnArea;

    [SerializeField] GameObject[] veggiePrefabs;

    [SerializeField] float startDelay = 5f;

    [SerializeField] float minSpawnDelay = 0.75f;
    [SerializeField] float maxSpawnDelay = 2f;

    [SerializeField] float minYAngle = 6f;
    [SerializeField] float maxYAngle = 12f;
    [SerializeField] float minZAngle = 6f;
    [SerializeField] float maxZAngle = 12f;

    [SerializeField] float minForce = 4f;
    [SerializeField] float maxForce = 7f;

    [SerializeField] float maxLifetime = 5f;

    void Awake()
    {
        spawnArea = GetComponent<Collider>();
    }

    void OnEnable()
    {
        StartCoroutine(SpawnFruit());
    }

    void OnDisable()
    {
        StopAllCoroutines();
    }

    IEnumerator SpawnFruit()
    {
        yield return new WaitForSeconds(startDelay);

        while (enabled)
        {
            GameObject prefab = veggiePrefabs[Random.Range(0, veggiePrefabs.Length)];

            Vector3 position = new Vector3();
            position.x = Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x);
            position.y = Random.Range(spawnArea.bounds.min.y, spawnArea.bounds.max.y);
            position.z = Random.Range(spawnArea.bounds.min.z, spawnArea.bounds.max.z);

            Quaternion rotation = Quaternion.Euler(0f, Random.Range(minYAngle, maxYAngle), Random.Range(minZAngle, maxZAngle));

            GameObject fruit = Instantiate(prefab, position, rotation);
            Destroy(fruit, maxLifetime);

            float force = Random.Range(minForce, maxForce);
            fruit.GetComponent<Rigidbody>().AddForce(fruit.transform.up * force, ForceMode.Impulse);

            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
        }
    }
}
