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
        usedModel.SetActive(true);
        inusedModel.SetActive(true);
        _countClick = 0;
    }

    public void ClickItem()
    {
        if (_countClick == 1)
            return;
        if (!inusedModel.activeSelf)
        {
            usedModel.SetActive(false);
        }
        else
        {
            inusedModel.SetActive(false);
        }

        clickItemVoidEventChannelSO.RaiseEvent();
        _countClick = 1;
    }

    //public void RefreshClickCounter()
    //{
        
    //}

    public void RefreshItem()
    {
        _countClick = 0;
        inusedModel.SetActive(true);
    }
}
