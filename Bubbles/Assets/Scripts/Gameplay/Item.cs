using System.Collections;
using UnityEngine;

public class Item : MonoBehaviour, IClickable
{
    [SerializeField] VoidEventChannelSO clickItemVoidEventChannelSO;
    [SerializeField] private GameObject inusedModel;
    [SerializeField] private GameObject usedModel;

    private int _countClick;


    void Start()
    {
        _countClick = 0;
    }

    public void ClickItem()
    {
        if (_countClick == 1)
            return;
        if (!inusedModel.activeSelf)
        {
            usedModel.SetActive(false);
            inusedModel.SetActive(true);
        }
        else
        {
            usedModel.SetActive(true);
            inusedModel.SetActive(false);
        }

        clickItemVoidEventChannelSO.RaiseEvent();
        _countClick = 1;
    }

    public void RefreshClickCounter()
    {
        _countClick = 0;
    }

    public void RefreshItem()
    {
        inusedModel.SetActive(true);
    }
}
