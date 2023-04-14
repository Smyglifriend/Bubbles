using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsLevel : MonoBehaviour
{
    [SerializeField] GameObject[] checkPoints = new GameObject[4];

    Vector3 _screenPos;

    private void Start()
    {
        SetCheckPointsPosition();
    }

    public void SetCheckPointsPosition()
    {
        _screenPos = Camera.main.ScreenToWorldPoint(
           new Vector3(Screen.width, Screen.height, transform.position.z));
        checkPoints[0].transform.position = new Vector3(-_screenPos.x - 1f, -_screenPos.y - 1f, _screenPos.z);
        checkPoints[1].transform.position = new Vector3(-_screenPos.x- 1f, _screenPos.y + 1f, _screenPos.z);
        checkPoints[2].transform.position = new Vector3(_screenPos.x + 1f, _screenPos.y + 1f, _screenPos.z);
        checkPoints[3].transform.position = new Vector3(_screenPos.x + 1f, -_screenPos.y - 1f, _screenPos.z);
    }
}
