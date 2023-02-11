using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private VoidEventChannelSO voidEventChannelSo;
    private void Start()
    {
        GetUnusedItem()
            .gameObject
            .SetActive(false);
    }

    protected virtual void OnMouseDown()
    {
        GetUnusedItem()
            .SetActive(
            true);
        voidEventChannelSo.RaiseEvent();
    }

    private GameObject GetUnusedItem()
    {
        var modelTransform = transform.GetChild(0);
        var unused = modelTransform.GetChild(0);

        return unused.gameObject;
    }
}
