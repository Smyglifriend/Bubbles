using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> balls;
    [SerializeField] private float spawnSecond = 1f;


    private void Start()
    {
        StartCoroutine(SpawnBubbles());
    }

    IEnumerator SpawnBubbles()
    {
        while (true)
        {
            Instantiate(balls[Random.Range(0, balls.Count)], transform.position, Quaternion.identity);

            yield return new WaitForSeconds(spawnSecond);
        }
        
    }
}
