using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New LevelData", menuName = "Level Data", order = 51)]
public class LevelData : ScriptableObject
{
    [SerializeField] private string levelName;
    [SerializeField] private Sprite icon;
    [SerializeField] private string description;

    public string LevelName => levelName;
    public Sprite Icon => icon;
    public string Description => description;
}
