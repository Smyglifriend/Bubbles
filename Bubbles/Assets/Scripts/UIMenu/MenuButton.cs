using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    [SerializeField] private VoidEventChannelSO voidEventChannelSo;
    
    public void ButtonClick()
    {
        voidEventChannelSo.RaiseEvent();
    }
}
