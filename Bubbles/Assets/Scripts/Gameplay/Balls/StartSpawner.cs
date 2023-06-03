using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> balls;
    [SerializeField] private float spawnSecond = 0f;
    [SerializeField] private GameObject perantForSpawn;


    private void Start()
    {
        for (var i = 0; i < 5; i++)
        {
            transform.localPosition = new Vector3((float)Random.Range(0, 5), (float)Random.Range(0,5), 0f);
            Instantiate(balls[Random.Range(0, balls.Count)], transform.position, Quaternion.identity, perantForSpawn.transform);
        }
        Destroy(gameObject);
    }

}
