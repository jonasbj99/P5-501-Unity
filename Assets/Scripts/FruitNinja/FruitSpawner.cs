using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://www.youtube.com/watch?v=xTT1Ae_ifhM

public class FruitSpawner : MonoBehaviour
{
    private Collider spawnArea;

    [SerializeField] GameObject[] fruitPrefabs;

    [SerializeField] float startDelay = 5f;

    [SerializeField] float minSpawnDelay = 0.75f;
    [SerializeField] float maxSpawnDelay = 2f;

    [SerializeField] float minAngle = -15f;
    [SerializeField] float maxAngle = 15f;

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
            GameObject prefab = fruitPrefabs[Random.Range(0, fruitPrefabs.Length)];

            Vector3 position = new Vector3();
            position.x = Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x);
            position.y = Random.Range(spawnArea.bounds.min.y, spawnArea.bounds.max.y);
            position.z = Random.Range(spawnArea.bounds.min.z, spawnArea.bounds.max.z);

            Quaternion rotation = Quaternion.Euler(0f, 0f, Random.Range(minAngle, maxAngle));

            GameObject fruit = Instantiate(prefab, position, rotation);
            Destroy(fruit, maxLifetime);

            float force = Random.Range(minForce, maxForce);
            fruit.GetComponent<Rigidbody>().AddForce(fruit.transform.up * force, ForceMode.Impulse);

            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
        }
    }
}
