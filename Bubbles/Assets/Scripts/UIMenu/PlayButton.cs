using UnityEngine;

public class PlayButton : MonoBehaviour
{
    [SerializeField] private VoidEventChannelSO voidEventChannelSo;

    public void ButtonClick()
    {
        voidEventChannelSo.RaiseEvent();
    }
}
