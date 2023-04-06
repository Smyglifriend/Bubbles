using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleMaster : MonoBehaviour
{
    [SerializeField] private Camera camera;
    [SerializeField] private float specialValue = 1;
    [SerializeField] private float baseSpecialValue = 1;
    
    private void Update()
    {
        camera.fieldOfView = baseSpecialValue + (float) Screen.height / Screen.width * specialValue;
        Debug.Log((float)Screen.height/Screen.width);
    }
}
