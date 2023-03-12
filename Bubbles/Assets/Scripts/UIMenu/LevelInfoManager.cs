using TMPro;
using UnityEngine;

public class LevelInfoManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI levelName;
    [SerializeField] private TextMeshProUGUI description;

    public void UpdateDisplayUI(LevelData levelData)
    {
        levelName.text = levelData.LevelName;
        description.text = levelData.Description;
    }
}
