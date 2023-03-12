using TMPro;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class LevelInfoManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI levelName;


    public void UpdateDisplayUI(LevelData levelData)
    {
        levelName.text = LocalizationSettings.StringDatabase.GetLocalizedString("LocalizationTable", levelData.LevelName);
    }
}
