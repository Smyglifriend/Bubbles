using UnityEngine;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour
{
    [SerializeField] private LevelDataEventChanelSO levelDataEventChanelSo;
    [SerializeField] private LevelData levelData;

    public void ButtonClick()
    {
        levelDataEventChanelSo.RaiseEvent(levelData);
    }

    public void ApplyLevelData(LevelData data)
    {
        levelData = data;
        var icon = GetComponent<Image>();
        if (data.Icon != null)
            icon.sprite = data.Icon;
    }
}
