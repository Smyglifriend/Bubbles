using System;
using System.Collections;
using System.Net;
using TMPro;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private float duration = 4f;
    [SerializeField] private float zAmplitude = 0.5f;
    [SerializeField] private float yAmplitude = 1f;
    [SerializeField] private float timePeriod = 2f;

    private Transform _currentTransform;
    private Vector3 _startPostion;
    private Vector3 _inermediatePosition = new Vector3(0f, 0f, 14f);
    private Vector3 _endPosition;
    private int _countTargets;
    private Vector3 _centerOffset;
    private float _timeSinceStart;

    

    private void Start()
    {
        _currentTransform = transform;
        _startPostion = new Vector3(_currentTransform.position.x, _currentTransform.position.y, _currentTransform.position.z);
        _endPosition = new Vector3(_currentTransform.position.x * -1, _currentTransform.position.y * -1, _currentTransform.position.z);
        _centerOffset = new Vector3(0, 1, 0);
        _timeSinceStart = (3 * timePeriod) / 4;

        StartCoroutine(Movement(_startPostion, _inermediatePosition, _centerOffset, duration));
    }

    IEnumerator Movement(Vector3 start, Vector3 target, Vector3 centerOffset, float duration)
    {
        var center = (start + target) * 0.5F;
        center -= centerOffset;

        var startRelCenter = start - center;
        var endRelCenter = target - center;

        var elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            var slerpPos = Vector3.Slerp(startRelCenter, endRelCenter, elapsedTime / duration);
            var nextPos = new Vector3(0, 0, 0);
            nextPos.y = yAmplitude * Mathf.Sin(((Mathf.PI * 2) / timePeriod) * _timeSinceStart);
            nextPos.z = zAmplitude * Mathf.Sin(((Mathf.PI * 2) / timePeriod) * _timeSinceStart);
            slerpPos += nextPos;
            _currentTransform.position = slerpPos;
            _currentTransform.position += center;

            elapsedTime += Time.deltaTime;
            _timeSinceStart += Time.deltaTime;

            yield return null;
        }
        _countTargets++;
        _timeSinceStart = 0;
        StartCoroutine(Movement(_currentTransform.position, _endPosition, new Vector3(0, -1, 0), duration));

        if (_countTargets == 2)
        {
            Destroy(gameObject);
        }
    }
}
