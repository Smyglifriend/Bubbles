using System.Net;
using TMPro;
using UnityEngine;

public class SreenSize : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI sreenSize;
    private void Update()
    {
        var text = Screen.width.ToString() + " " + Screen.height.ToString();
        sreenSize.text = text;
    }
}
