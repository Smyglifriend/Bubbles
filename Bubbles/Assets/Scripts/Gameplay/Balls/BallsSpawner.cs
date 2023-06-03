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
        spawnSecond = 0.1f;
        StartCoroutine(SpawnBubbles());
    }

    private void Update()
    {
        spawnSecond = Random.Range(3,5);
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
