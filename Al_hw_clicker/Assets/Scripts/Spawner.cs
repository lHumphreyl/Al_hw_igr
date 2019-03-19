using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject targetPrefab;

    public Vector3 MinOffset;
    public Vector3 MaxOffset;

    public float spawnTime = 1f;
    public float lifeTime = 3f;

    private void OnEnable()
    {
        StartCoroutine(SpawnRoutine());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    private IEnumerator SpawnRoutine()
    {
        while (isActiveAndEnabled)
        {
            yield return new WaitForSeconds(spawnTime);
            Spawn();
        }
    }

    private void Spawn()
    {
        var position = new Vector3(
            Random.Range(MinOffset.x, MaxOffset.x),
            Random.Range(MinOffset.y, MaxOffset.y),
            0f);

        Instantiate(targetPrefab, position, Quaternion.Euler(new Vector3(90f, 0f, 0f)));
    }
}
