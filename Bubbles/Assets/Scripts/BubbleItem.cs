using System;
using UnityEngine;

public class BubbleItem : Item
{
    [SerializeField] private GameObject bubblePrefab;

    private void Start()
    {
        var model = transform.GetChild(0);
    }
}
