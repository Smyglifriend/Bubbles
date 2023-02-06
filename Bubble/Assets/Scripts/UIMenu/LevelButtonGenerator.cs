using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelButtonGenerator : MonoBehaviour
{
    [SerializeField] private GameObject level;
    [SerializeField] private List<LevelData> levelDatas;


    void Start()
    {
        foreach (var levelData in levelDatas)
        {
            var levelButton = level.GetComponent<LevelButton>();
            levelButton.ApplyLevelData(levelData);
            
            Instantiate(level, transform.position, Quaternion.identity, transform);
        }
    }
}
