using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] private GameObject point1;
    [SerializeField] private GameObject point2;
    [SerializeField] private GameObject prefab;

    [SerializeField] private float speed = 0.2f;
    
    void Start()
    {
        Instantiate(prefab, point1.transform.position, Quaternion.identity);
    }

    void Update()
    {
        
    }

    void Move()
    {
        var pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
    }
}
