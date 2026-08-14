using System;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    [SerializeField] GameObject targetPrefab;

    [SerializeField] float spawnDistance = 20f;

    [SerializeField] float minX = -8f;
    [SerializeField] float maxX = 8f;

    [SerializeField] float minY = 1f;
    [SerializeField] float maxY = 6f;

    [SerializeField] float spawnInterval = 2f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnTarget), 1f, spawnInterval);
    }

    void SpawnTarget()
    {
        float x = UnityEngine.Random.Range(minX, maxX);
        float y = UnityEngine.Random.Range(minY, maxY);

        Vector3 spawnPosition = new Vector3(x, y, spawnDistance);

        Instantiate(targetPrefab, spawnPosition, Quaternion.Euler(0, 180, 0));
    }
}
