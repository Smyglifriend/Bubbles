using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private VoidEventChannelSO clickItemVoidEventChannelSo;
    [SerializeField] private GameObject inusedModel;
    [SerializeField] private GameObject usedModel;
    private int _countClick;

    private void Start()
    {
        _countClick = 0;
    }

    protected virtual void OnMouseDown()
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

        clickItemVoidEventChannelSo.RaiseEvent();
        _countClick = 1;
    }

    public void RefreshClickCounter()
    {
        _countClick = 0;
    }
}
