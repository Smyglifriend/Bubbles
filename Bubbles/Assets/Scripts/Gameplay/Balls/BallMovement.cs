using System.Collections;
using System.Net;
using TMPro;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private float duration = 10f;

    private Transform _currentTransform;
    private Vector3 _startPostion;
    private Vector3 _inermediatePosition = new Vector3(1f, 1f);
    private Vector3 _endPosition;
    private int _countTargets;
    private Vector3 _centerOffset;


    private void Start()
    {
        _currentTransform = transform;
        _startPostion = new Vector3(_currentTransform.position.x, _currentTransform.position.y);
        _endPosition = new Vector3(_currentTransform.position.x * -1, _currentTransform.position.y * -1);
        _centerOffset = new Vector3(0, 1, 0);

        StartCoroutine(Movement(_startPostion, _inermediatePosition, _centerOffset, duration));
    }

    IEnumerator Movement(Vector3 start, Vector3 target, Vector3 centerOffset,  float duration)
    {
        var center = (start + target) * 0.5F;
        center -= centerOffset;

        var startRelCenter = start - center;
        var endRelCenter = target - center;

        var elapsedTime = 0f;
        while (elapsedTime < duration)
        {
            _currentTransform.position = Vector3.Slerp(startRelCenter, endRelCenter, elapsedTime / duration);
            _currentTransform.position += center;
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        _countTargets++;
        StartCoroutine(Movement(_currentTransform.position, _endPosition, new Vector3( 0, -1, 0),duration));
        if (_countTargets == 2)
        {
            Destroy(gameObject);
        }

        //center = (_currentTransform.position + _endPosition) * 0.5F;

        //center -= new Vector3(0, -1, 0);

        //startRelCenter = _currentTransform.position - center;
        //endRelCenter = _endPosition - center;
        //elapsedTime = 0f;
        //while (elapsedTime < duration)
        //{
        //    _currentTransform.position = Vector3.Slerp(startRelCenter, endRelCenter, elapsedTime / duration);
        //    _currentTransform.position += center;
        //    elapsedTime += Time.deltaTime;
        //    yield return null;
        //}
    }
}
