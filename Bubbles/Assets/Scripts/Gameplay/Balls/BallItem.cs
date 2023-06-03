using UnityEngine;

public class BallItem : MonoBehaviour, IClickable
{
    [SerializeField] private VoidEventChannelSO clickItemVoidEventChannelSO;
    [SerializeField] private GameObject destroyEffect;


    public void ClickItem()
    {
        clickItemVoidEventChannelSO.RaiseEvent();
        Instantiate(destroyEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
