using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleLevelRefresh : MonoBehaviour
{
    private Animation _refreshAnimation;
    private int _inactiveChildrenCount;
    private int _childrenCount = 30;


    void Start()
    {
        _refreshAnimation = GetComponent<Animation>();
    }

    void Update()
    {
        if (_childrenCount != _inactiveChildrenCount) return;

        RefreshPlatform();
    }

    public void UpdateInactiveChildrenCount()
    {
        _inactiveChildrenCount += 1;
    }

    private void RefreshPlatform()
    {
        _refreshAnimation.CrossFade("Refresh");

        _inactiveChildrenCount = 0;
    }
}
