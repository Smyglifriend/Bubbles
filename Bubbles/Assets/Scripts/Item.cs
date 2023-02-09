using System;
using Unity.VisualScripting;
using UnityEngine;

public class Item : MonoBehaviour
{
    protected virtual void OnMouseDown()
    {
        var unused = transform.GetChild(0);
        unused.gameObject.SetActive(true);
    }
}
