using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New LevelData", menuName = "Level Data", order = 51)]
public class LevelData : ScriptableObject
{
    [SerializeField] private string levelName;
    [SerializeField] private string description;
    [SerializeField] private Sprite icon;
    [SerializeField] private GameObject lvlPrefab;


    public string LevelName => levelName;

    public Sprite Icon => icon;

    public string Description => description;

    public GameObject LvlPrefab => lvlPrefab;
}
