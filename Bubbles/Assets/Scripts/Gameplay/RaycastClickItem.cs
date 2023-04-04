using System.Collections.Generic;
using UnityEngine;

public class RaycastClickItem : MonoBehaviour
{
    [SerializeField] private LayerMask maskItem;

    Camera _camera;


    private void Start()
    {
        _camera = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = _camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 1000, maskItem))
            {
                var item = hit.transform.gameObject.GetComponent<IClickable>();
                item?.ClickItem();
            }
        }
    }
}
