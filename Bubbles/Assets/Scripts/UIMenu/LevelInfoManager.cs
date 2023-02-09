using System;
using TMPro;
using UnityEngine;

public class LevelInfoManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI levelName;
    [SerializeField] private TextMeshProUGUI description;
    //[SerializeField] private Image icon;

    public void UpdateDisplayUI(LevelData levelData)
    {
        levelName.text = levelData.LevelName;
        description.text = levelData.Description;
        //icon.sprite = levelData.Icon.sprite;
    }
}
