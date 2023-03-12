using UnityEngine;

public class MenuEvenHandler : MonoBehaviour
{
    public void ShowMenu()
    {
        var menu = transform.GetChild(0);
        if (!menu.gameObject.activeSelf)
        {
            menu.gameObject.SetActive(true);
        }
    }
    
    public void HideMenu()
    {
        var menu = transform.GetChild(0);
        if (menu.gameObject.activeSelf)
        {
            menu.gameObject.SetActive(false);
        }
    }
}
