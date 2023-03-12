using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsSpawnerMovement : MonoBehaviour
{
    [SerializeField] private List<GameObject> checkPoints;
    [SerializeField] private float duration = 5;


    void Start()
    {
        StartCoroutine(Movement());
    }    

    IEnumerator Movement()
    {
        var checkpointIndex = 0;
        var currentTransform = transform;
        while (true)
        {
            var startPosition = checkPoints[checkpointIndex].transform.position;
            var targetPosition = checkPoints[(checkpointIndex + 1) % checkPoints.Count].transform.position;

            float elapsedTime = 0f;

            while (elapsedTime < duration)
            {

                var currentPosition = Vector3.Lerp(startPosition, targetPosition, elapsedTime / duration);
                currentTransform.position = currentPosition;
                yield return null;

                elapsedTime += Time.deltaTime;
            }

            currentTransform.position = targetPosition;

            checkpointIndex = (checkpointIndex + 1) % checkPoints.Count;
        }
    }
}
