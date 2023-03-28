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
        StartCoroutine(SpawnBubbles());
    }

    IEnumerator SpawnBubbles()
    {
        currentTransform = transform;
        var ball = Instantiate(balls[0], currentTransform.position, Quaternion.identity, perantForSpawn.transform);
        Debug.Log(ball.transform.position);
        yield return null;

    }
    //IEnumerator SpawnBubbles()
    //{
    //    while (true)
    //    {
    //        currentTransform = transform;
    //        var ball = Instantiate(balls[Random.Range(0, balls.Count)], currentTransform.position, Quaternion.identity, perantForSpawn.transform);
    //        Debug.Log(ball.transform.position);
    //        yield return new WaitForSeconds(spawnSecond);
    //    }

    //}
}
