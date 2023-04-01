using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleLevelRefresh : MonoBehaviour
{
    [SerializeField] private VoidEventChannelSO refreshItemsEventChannelSo;

    private Animation _refreshAnimation;
    private int _inactiveChildrenCount;
    private int _childrenCount = 61;


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
        Debug.Log(_inactiveChildrenCount);
    }

    private void RefreshPlatform()
    {
        _refreshAnimation.CrossFade("BubbleLevelRefresh");

        _inactiveChildrenCount = 0;
    }

    private void RefreshItem()
    {
        refreshItemsEventChannelSo.RaiseEvent();
    }
}
