using TMPro;
using UnityEngine;
using UnityEngine.Localization.Components;
using UnityEngine.Localization.Settings;

public class LevelInfoManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI levelName;
    [SerializeField] private LocalizeStringEvent eventt;

    private LevelData _levelData;


    public void UpdateDisplayUI()
    {
        if (_levelData == null) return;
        //eventt.StringReference.SetReference("LocalizationTable", _levelData.LevelName);
        levelName.text = LocalizationSettings.StringDatabase.GetLocalizedString("LocalizationTable", _levelData.LevelName);
    }

    public void UpdateDisplayUI(LevelData levelData)
    {
        _levelData = levelData;
        levelName.text = LocalizationSettings.StringDatabase.GetLocalizedString("LocalizationTable", levelData.LevelName);
    }
}
