using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlaneMover : MonoBehaviour
{
    private int _unActiveChildrenCount;
    private int _children;
    
    void Start()
    {
        _children = transform.childCount;
        // = GetComponentsInChildren<Transform>(true)
        // .Where(child => child != this.transform)
        // .ToList();
    }
    
    void Update()
    {
        if (_children != _unActiveChildrenCount) return;
        
        MovePlane(); 
        _unActiveChildrenCount = 0;
    }

    public void UpdateUnActiveChildrenCount()
    {
        _unActiveChildrenCount += 1;
        Debug.Log(_unActiveChildrenCount);
    }

    private void MovePlane()
    {
        //transform.Rotate(0f, 0f, 180f);
    }
}
