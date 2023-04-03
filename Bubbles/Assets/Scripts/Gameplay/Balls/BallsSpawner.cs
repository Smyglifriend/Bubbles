using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> balls;
    [SerializeField] private float spawnSecond = 1f;
    [SerializeField] private GameObject perantForSpawn;

    private Transform currentTransform;


    private void Start()
    {
        spawnSecond = 1f;
        StartCoroutine(SpawnBubbles());
    }

    IEnumerator SpawnBubbles()
    {
        while (true)
        {
            currentTransform = transform;
            Instantiate(balls[Random.Range(0, balls.Count)], currentTransform.position, Quaternion.identity, perantForSpawn.transform);
            yield return new WaitForSeconds(spawnSecond);
        }
    }
}
